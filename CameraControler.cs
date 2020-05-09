/****************************************************
	作者：梁权富
	网址：http://www.sunrise720.com
	日期：2019.7.20
	功能：相机控制器
****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using DG.Tweening;
using UnityEngine.XR;
using UnityEngine.EventSystems;
using HedgehogTeam.EasyTouch;
using UnityEngine.Playables;
using OC;
#if UNITY_EDITOR
using UnityEditor;
#endif

[RequireComponent (typeof(Rigidbody))]
[RequireComponent (typeof(CapsuleCollider))]
public class CameraControler : MonoBehaviour {
    private static CameraControler _instance;
    public static CameraControler Instance { get { return _instance; } }

    public CameraTargetScriptableObject sObj;
    public Camera sCamera;//场景层
    public Camera mCamera;//地图层
    public Camera rCamera;//户型层
    Camera[] cameras;//所有摄影机层

    public Vector3 angleDistance;//角度与距离
    //public GameObject vrOrigin;
    //public GameObject ViveRig;

    [HideInInspector]
    public Rigidbody sRigidBody;//刚体
    [HideInInspector]
    public CapsuleCollider sCapsuleCollider;//碰撞体
    Vector3 addAngleDistance;//增量角度与距离
    [HideInInspector]
    public Vector3 lookTargetPosition;//环视目标点位置
    float speedScale = 0.02f;
    float pathAnimation;//路径动画增量
    bool isDoTweenOk;//就位  可以划动
    int pathFrame;//路径当前帧数
    float doubleTapTime;//模拟双击事件时间
    Ease ease = Ease.InOutFlash;
    bool isTouchUp;
    bool isAniamtion;
    PlayableDirector director;


    void Awake()
    {
        _instance = this;
        sRigidBody = GetComponent<Rigidbody>();
        sCapsuleCollider = GetComponent<CapsuleCollider>();
        cameras = GetComponentsInChildren<Camera>();
        SetCameraLayer();
    }

    void Start () {
        if (sObj != null)
            MoveToTarg(sObj);
        else
            Debug.Log("相机没有初始化位置！");
    }


    //物理类刷新
    void FixedUpdate()
    {
        if (!isAniamtion && !director && sObj && isDoTweenOk)
        {
            if (sObj.camMode == CameraTargetScriptableObject.CameraMode.人视穿行)
            {
                if (!Sun.Rise.IsPointerOverUIObject())
                {
                    //触摸事件
                    Gesture curGesture = EasyTouch.current;
                    if (curGesture != null)
                    {
                        if (!curGesture.pickedUIElement)
                        {
                            //单指
                            if (EasyTouch.GetTouchCount() == 1)
                            {
                                //推力  前进 后退
                                if (curGesture.position.y > Screen.height * 0.2f)
                                    sRigidBody.AddForce(transform.forward * sObj.scrollZoomPanSpeed.y * 2f);
                                else
                                    sRigidBody.AddForce(-transform.forward * sObj.scrollZoomPanSpeed.y * 2f);
                            }
                        }
                    }
                    RotateCamera();//让摄像机和角色 始终转向物品
                }
            }
        }
    }

    void Update()
    {
        if (isAniamtion && director)
        {
            transform.localPosition = director.transform.position;
            Vector3 rot = new Vector3(0, director.transform.eulerAngles.y, 0);
            transform.rotation = Quaternion.Euler(rot);
            angleDistance = rot;
            sCamera.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (sObj && isDoTweenOk)
        {
            if (sObj.camMode == CameraTargetScriptableObject.CameraMode.路径动画)
            {
                //路径帧数控制
                if (sObj.pathFrame > 2)
                {
                    pathAnimation = (sObj.pathCreator.path.length / sObj.pathFrame) * pathFrame;
                    pathFrame += 1;
                }
                else
                    pathAnimation += sObj.scrollZoomPanSpeed.y * Time.deltaTime;//路径速度控制

                transform.position = sObj.pathCreator.path.GetPointAtDistance(pathAnimation, sObj.pathEndType);
                Quaternion rot = sObj.pathCreator.path.GetRotationAtDistance(pathAnimation, sObj.pathEndType) * Quaternion.Euler(0, 0, 90);
                angleDistance = sCamera.transform.eulerAngles;

                //路径注视
                if (sObj.pathLookAt)
                    sCamera.transform.LookAt(sObj.lookTargetPosition);
                else
                    transform.eulerAngles = new Vector3(0, rot.eulerAngles.y, 0);
            }


            if (sObj.camMode == CameraTargetScriptableObject.CameraMode.环视目标 ||
                 sObj.camMode == CameraTargetScriptableObject.CameraMode.人视穿行||
                sObj.camMode == CameraTargetScriptableObject.CameraMode.自由飞行)
            {
                if (!Sun.Rise.IsPointerOverUIObject())
                {
                    //触摸事件
                    Gesture curGesture = EasyTouch.current;
                    if (curGesture != null)
                    {
                        if (!curGesture.pickedUIElement)
                        {
                            //单指
                            if (EasyTouch.GetTouchCount() == 1)
                            {
                                Cursor.visible = false; //隐藏鼠标指针 
                                addAngleDistance.y += curGesture.deltaPosition.x * sObj.scrollZoomPanSpeed.x * speedScale;
                                addAngleDistance.x -= curGesture.deltaPosition.y * sObj.scrollZoomPanSpeed.x * speedScale;

                                if(sObj.camMode == CameraTargetScriptableObject.CameraMode.人视穿行)
                                {
                                    if (EasyTouch.EvtType.On_TouchStart == curGesture.type)
                                    {
                                        //模拟双击事件  EasyTouch双击事件与window冲突
                                        bool doubleTap = false;
                                        if (Time.time < doubleTapTime + 0.3f) doubleTap = true;
                                        doubleTapTime = Time.time;
                                        if (doubleTap)
                                        {
                                            //人视穿行 双击自动前行
                                            if (curGesture.GetCurrentPickedObject() && sObj.arrowPrefab)
                                            {
                                                Ray ray = Camera.main.ScreenPointToRay(curGesture.position);
                                                RaycastHit hit;
                                                if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                                                {
                                                    if (hit.normal.y > 0.85f)//法线方向朝上
                                                    {
                                                        //生成箭头
                                                        GameObject arrow = Instantiate(sObj.arrowPrefab);
                                                        arrow.transform.position = hit.point;//碰撞位置

                                                        //arrow.transform.domo(new Vector3(), sObj.tweenTime).SetEase(Ease.Flash).SetLoops(-1);
                                                        arrow.transform.DORotate(new Vector3(0, 180f, 0), sObj.fovTweenLate.y).OnComplete((() =>
                                                        {
                                                            Destroy(arrow);
                                                        })); ;

                                                        //Debug.Log(curGesture.GetCurrentPickedObject().name + "    坐标: " + hit.point);
                                                        Vector3 newPos = new Vector3(hit.point.x, hit.point.y + sCapsuleCollider.height, hit.point.z);
                                                        DOTween.Kill("ToCameraPosition");
                                                        DOTween.To(() => transform.position, x => transform.position = x, newPos, sObj.fovTweenLate.y).SetId("ToCameraPosition").SetEase(ease).SetAutoKill(true)
                                                            .OnComplete((() =>
                                                            {

                                                            }));
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                if (sObj.camMode == CameraTargetScriptableObject.CameraMode.自由飞行)
                                    transform.localPosition += sCamera.transform.forward * sObj.scrollZoomPanSpeed.y * speedScale;

                                if (sObj.camMode == CameraTargetScriptableObject.CameraMode.人视穿行)
                                {
                                    //前进 后退
                                    if (curGesture.position.y > Screen.height * 0.2f)
                                        transform.localPosition += transform.forward * sObj.scrollZoomPanSpeed.y * speedScale;
                                    else
                                        transform.localPosition -= transform.forward * sObj.scrollZoomPanSpeed.y * speedScale;
                                }
                            }
                            //双指
                            else if (EasyTouch.GetTouchCount() == 2)
                            {
                                if (EasyTouch.EvtType.On_TouchStart2Fingers == curGesture.type)
                                    addAngleDistance.z = 0;
                                //缩放
                                if (sObj.camMode == CameraTargetScriptableObject.CameraMode.环视目标)
                                {
                                    //if (EasyTouch.EvtType.On_Pinch == curGesture.type)
                                    //{
                                    //    if(curGesture.deltaPinch != 0)
                                    //        addAngleDistance.z -= (curGesture.deltaPinch > 0 ? 1f : -1f) * sObj.scrollZoomPanSpeed.y;
                                    //}
                                    if (curGesture.deltaPosition.y != 0)
                                        addAngleDistance.z -= (curGesture.deltaPosition.y > 0 ? 0.2f : -0.2f) * sObj.scrollZoomPanSpeed.y;
                                }
                                //划动转角度
                                if (sObj.camMode == CameraTargetScriptableObject.CameraMode.自由飞行 ||
                                    sObj.camMode == CameraTargetScriptableObject.CameraMode.人视穿行)
                                {
                                    addAngleDistance.y += curGesture.deltaPosition.x * sObj.scrollZoomPanSpeed.x * speedScale * 0.2f;
                                    addAngleDistance.x -= curGesture.deltaPosition.y * sObj.scrollZoomPanSpeed.x * speedScale * 0.2f;
                                }
                            }
                            //多指抓
                            else if (EasyTouch.GetTouchCount() > 2)
                            {
                                //缩放  平移
                                if (sObj.camMode == CameraTargetScriptableObject.CameraMode.环视目标)
                                {
                                    Vector3 p0 = transform.position;
                                    Vector3 p01 = p0 - transform.right * curGesture.deltaPosition.x * speedScale * sObj.scrollZoomPanSpeed.z * 0.5f;
                                    //Vector3 p03 = Vector3.zero;
                                    //if (Input.GetKey(KeyCode.LeftShift))
                                    //    p03 = p01 - transform.up * curGesture.deltaPosition.y * speedScale * sObj.scrollZoomPanSpeed.z * 0.5f;
                                    //else
                                    //    p03 = p01 - transform.forward * curGesture.deltaPosition.y * speedScale * sObj.scrollZoomPanSpeed.z * 0.5f;
                                    Vector3 p03 = p01 - transform.forward * curGesture.deltaPosition.y * speedScale * sObj.scrollZoomPanSpeed.z * 0.5f;
                                    lookTargetPosition += p03 - p0;
                                }
                            }

                            if (EasyTouch.EvtType.On_TouchUp == curGesture.type)
                                isTouchUp = true;
                            else
                                isTouchUp = false;
                        }
                    }
                    //pc上才有的事件
                    if (!Application.isMobilePlatform)
                    {
                        if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
                            Cursor.visible = true; //显示鼠标指针

                        //右键事件
                        if (Input.GetMouseButton(1))
                        {
                            if (sObj.camMode == CameraTargetScriptableObject.CameraMode.环视目标)//平移视点
                            {
                                Vector3 p0 = transform.position;
                                Vector3 p01 = p0 - transform.right * Input.GetAxis("Mouse X") * sObj.scrollZoomPanSpeed.z;
                                Vector3 p03 = p01 - transform.forward * Input.GetAxis("Mouse Y") * sObj.scrollZoomPanSpeed.z;
                                lookTargetPosition += p03 - p0;
                            }
                            else  //划动转角度
                            {
                                addAngleDistance.y += Input.GetAxis("Mouse X") * sObj.scrollZoomPanSpeed.x;
                                addAngleDistance.x -= Input.GetAxis("Mouse Y") * sObj.scrollZoomPanSpeed.x;
                            }
                        }

                        //滚轮事件
                        if (Input.GetAxis("Mouse ScrollWheel") != 0)
                        {
                            //限制鼠标移动到游戏窗口外
                            if (!new Rect(0, 0, Screen.width, Screen.height).Contains(Input.mousePosition)) return;
                            if (sObj.camMode == CameraTargetScriptableObject.CameraMode.环视目标)
                                addAngleDistance.z -= (Input.GetAxis("Mouse ScrollWheel") > 0 ? 0.5f : -0.5f) * sObj.scrollZoomPanSpeed.y;
                        }
                        //自由飞行模式-----------------------------------------------
                        if (sObj.camMode == CameraTargetScriptableObject.CameraMode.自由飞行)
                        {
                            if (Input.GetKey(KeyCode.A))
                                transform.localPosition -= transform.right * sObj.scrollZoomPanSpeed.y * speedScale;
                            if (Input.GetKey(KeyCode.D))
                                transform.localPosition += transform.right * sObj.scrollZoomPanSpeed.y * speedScale;
                            if (Input.GetKey(KeyCode.W))
                                transform.localPosition += sCamera.transform.forward * sObj.scrollZoomPanSpeed.y * speedScale;
                            if (Input.GetKey(KeyCode.S))
                                transform.localPosition -= sCamera.transform.forward * sObj.scrollZoomPanSpeed.y * speedScale;
                        }
                    }
                }

                RotateCamera();//让摄像机和角色 始终转向物品

                //环视目标模式-----------------------------------------------
                if (sObj.camMode == CameraTargetScriptableObject.CameraMode.环视目标)
                {
                    if (sObj.lookAutoPlay != 0) angleDistance.y += sObj.lookAutoPlay;
                    transform.position = lookTargetPosition + Quaternion.Euler(angleDistance.x, angleDistance.y, 0) * new Vector3(0, 0, -angleDistance.z);
                }
            }
        }
    }

    void LateUpdate()
    {
        if (sObj != null && isDoTweenOk)
        {
            addAngleDistance *= sObj.fovTweenLate.z;//缓动
            if (sObj.camMode == CameraTargetScriptableObject.CameraMode.人视穿行 && isTouchUp)
                angleDistance.x *= 0.92f;
                //angleDistance.x *= sObj.fovTweenLate.z;//缓动回正
        }
    }
    void RotateCamera()
    {
        angleDistance += addAngleDistance;
        //方向角度限制
        if (angleDistance.y < sObj.rotYRange.x)
        {
            if (sObj.rotYRange.x > -180)
                angleDistance.y = sObj.rotYRange.x;
            else
                angleDistance.y += 360;
        }
        if (angleDistance.y > sObj.rotYRange.y)
        {
            if (sObj.rotYRange.y < 180)
                angleDistance.y = sObj.rotYRange.y;
            else
                angleDistance.y -= 360;
        }
        angleDistance.x = Mathf.Clamp(angleDistance.x, sObj.rotXRange.x, sObj.rotXRange.y);
        angleDistance.z = Mathf.Clamp(angleDistance.z, sObj.lookDistanceRange.x, sObj.lookDistanceRange.y);
        //让摄像机和角色 始终转向物品
        transform.localRotation = Quaternion.Euler(0, angleDistance.y, 0);
        sCamera.transform.localRotation = Quaternion.Euler(angleDistance.x, 0, 0);
    }




    public void MoveToTarg(CameraTargetScriptableObject tagSobj)
    {
        //值初始化 赋值
        isDoTweenOk = false;
        sObj = tagSobj;//赋值
        angleDistance = tagSobj.lookAngleDistance;
        lookTargetPosition = tagSobj.lookTargetPosition;
        sCapsuleCollider.enabled = false;//先关闭碰撞

        DOTween.Kill("ToCameraRotationY");
        DOTween.To(() => transform.localRotation, x => transform.localRotation = x, new Vector3(0, tagSobj.lookAngleDistance.y, 0), tagSobj.fovTweenLate.y).SetId("ToCameraRotationY").SetAutoKill(true).SetEase(ease);
        DOTween.Kill("ToCameraRotationX");
        DOTween.To(() => sCamera.transform.localRotation, x => sCamera.transform.localRotation = x, new Vector3(tagSobj.lookAngleDistance.x, 0, 0), tagSobj.fovTweenLate.y).SetId("ToCameraRotationX").SetAutoKill(true).SetEase(ease);
        DOTween.Kill("ToCameraPosition");
        DOTween.To(() => transform.position, x => transform.position = x, tagSobj.sPosition, tagSobj.fovTweenLate.y).SetId("ToCameraPosition").SetEase(ease).SetAutoKill(true)
            .OnComplete((() =>
            {
                //人视穿行模式--------------------------------------------------------------------------
                if (tagSobj.camMode == CameraTargetScriptableObject.CameraMode.人视穿行)
                {
                    sRigidBody.useGravity = true;//打开重力
                    sRigidBody.isKinematic = false;//关闭自定义动画模式
                    sCapsuleCollider.enabled = true;//打开碰撞
                }
                else
                {
                    sRigidBody.useGravity = false;
                    sRigidBody.isKinematic = true;
                    sCapsuleCollider.enabled = false;
                }

                //VR模式--------------------------------------------------------------------------------
                if (tagSobj.camMode == CameraTargetScriptableObject.CameraMode.HTC头盔) {
                    StartCoroutine(LoadDevice("OpenVR"));
                }
                else
                    StartCoroutine(LoadDevice("None"));


                //路径动画模式--------------------------------------------------------------------------------
                if (tagSobj.camMode == CameraTargetScriptableObject.CameraMode.路径动画)
                {
                    pathAnimation = 0f;
                }

                isDoTweenOk = true;
            }));


        if (UIDay2Night.Instance)
        {
            //改变时间
            if (tagSobj.dayAutoWeather.x > 0)
                UIDay2Night.Instance.SetDayTime(tagSobj.dayAutoWeather.x, tagSobj.fovTweenLate.y);
            //自动变化时间
            if (tagSobj.dayAutoWeather.y > 0)
                UIDay2Night.Instance.AutoSlider(tagSobj.dayAutoWeather.y);
            else
                UIDay2Night.Instance.StopAutoSlider();
            //改变天气
            //if (tagSobj.dayAutoWeather.z != 0)
            //{
            //    UIDay2Night.Instance.weatherToggle.TurnOn();
            //    Day2NightManager.Instance.ChangeWeatherIndex(1);
            //}
            //else
            //{
            //    UIDay2Night.Instance.weatherToggle.TurnOff();
            //    Day2NightManager.Instance.ChangeWeatherIndex(0);
            //}
        }

        //关闭云
        if (tagSobj.overCloudSetting.x == 1)
            sCamera.GetComponent<OverCloudCamera>().renderVolumetricClouds = true;
        else
            sCamera.GetComponent<OverCloudCamera>().renderVolumetricClouds = false;
        //关闭雾
        if (tagSobj.overCloudSetting.y == 1)
            sCamera.GetComponent<OverCloudCamera>().renderAtmosphere = true;
        else
            sCamera.GetComponent<OverCloudCamera>().renderAtmosphere = false;



        //改变系统阴影距离
        if (tagSobj.clippingShadow.z != -1)
        {
            DOTween.Kill("ShadowDistance");
            DOTween.To(() => QualitySettings.shadowDistance, x => QualitySettings.shadowDistance = x, tagSobj.clippingShadow.z, tagSobj.fovTweenLate.y).SetId("ShadowDistance").SetEase(ease).SetAutoKill(true);
        }
        //改变摄影机clipping  Fov
        foreach (Camera cam in cameras)
        {
            DOTween.Kill("ClippingPlanesNear"+ cam.name);
            DOTween.To(() => cam.nearClipPlane, x => cam.nearClipPlane = x, tagSobj.clippingShadow.x, tagSobj.fovTweenLate.y).SetId("ClippingPlanesNear"+ cam.name).SetEase(ease).SetAutoKill(true);
            DOTween.Kill("ClippingPlanesFar" + cam.name);
            DOTween.To(() => cam.farClipPlane, x => cam.farClipPlane = x, tagSobj.clippingShadow.y, tagSobj.fovTweenLate.y).SetId("ClippingPlanesFar" + cam.name).SetEase(ease).SetAutoKill(true);
            DOTween.Kill("FovCamera" + cam.name);
            DOTween.To(() => cam.fieldOfView, x => cam.fieldOfView = x, tagSobj.fovTweenLate.x, tagSobj.fovTweenLate.y).SetId("FovCamera" + cam.name).SetEase(ease).SetAutoKill(true);
        }

    }

    IEnumerator LoadDevice(string newDevice)
    {
        XRSettings.LoadDeviceByName(newDevice);
        yield return null;
        //if (newDevice == "None")
        //{
        //    XRSettings.enabled = false;
        //    XRSettings.eyeTextureResolutionScale = 1f;
        //    sCamera.gameObject.SetActive(true);
        //    cameras.GetComponent<CTAA_PC>().CTAA_Enabled = true;
        //    vrOrigin.GetComponentInChildren<CTAA_PC>().CTAA_Enabled = false;
        //    vrOrigin.SetActive(false);
        //    //打开延时模式  关掉系统抗锯齿 
        //    QualitySettings.antiAliasing = 1;
        //    //print("PC模式");
        //}
        //else
        //{
        //    XRSettings.enabled = true;
        //    if (XRSettings.isDeviceActive)
        //    {
        //        cameras.GetComponent<CTAA_PC>().CTAA_Enabled = false;
        //        cameras.gameObject.SetActive(false);
        //        vrOrigin.SetActive(true);
        //        vrOrigin.GetComponentInChildren<CTAA_PC>().CTAA_Enabled = true;
        //        ViveRig.transform.localPosition = Vector3.zero;
        //        rigidbodys.useGravity = false;
        //        //改变系统阴影距离  
        //        //DOTween.To(() => QualitySettings.shadowDistance, x => QualitySettings.shadowDistance = x, 50, camTarg.tweenTime).SetAutoKill(true);
        //        //打开前置模式  系统抗锯齿 *8
        //        QualitySettings.antiAliasing = 8;

        //        XRSettings.eyeTextureResolutionScale = 1.5f;
        //    }
        //    else
        //    {
        //        UIMessages.Instance.Show("提示", "系统未检测到VR设备!");
        //        UIMessages.Instance.confim = () =>
        //        {
        //            //Application.Quit();
        //            //Debug.Log("-----退出了程序");
        //        };
        //        StartCoroutine(LoadDevice("None"));
        //    }

        //}
    }

    void SetCameraLayer()
    {
        sCamera.gameObject.layer = 8;//场景层
        //sCamera.cullingMask = 
        mCamera.gameObject.layer = 9;//地图层
        rCamera.gameObject.layer = 10;//户型层
    }

    public void OpenAnimation(PlayableDirector dir)
    {
        if (director) return;

        director = dir;
        isAniamtion = true;
        sRigidBody.useGravity = false;
        sRigidBody.isKinematic = true;
        sCapsuleCollider.enabled = false;
        director.Play();
        director.extrapolationMode = DirectorWrapMode.Loop;
        director.GetComponent<Camera>().enabled = false;//动画相机隐藏
    }
    public void CloseAniamtion()
    {
        if (!director) return;

        director.Stop();
        sRigidBody.useGravity = true;//打开重力
        sRigidBody.isKinematic = false;//关闭自定义动画模式
        sCapsuleCollider.enabled = true;//打开碰撞
        isAniamtion = false;
        director = null;
    }



#if UNITY_EDITOR
    [CustomEditor(typeof(CameraControler))]
    public class CameraControlerEditor : Editor
    {
        Editor editor;
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            //获取组件
            CameraControler sTarget = (CameraControler)target;
            //数据不为空
            if (sTarget.sObj != null)
            {
                editor = CreateEditor(sTarget.sObj);
                //editor.DrawDefaultInspector();
                editor.OnInspectorGUI();

                //sObj.SetInOutAll();//刷新所有值
            }
            else
            {
                editor = null;
                //新建按钮
                if (GUILayout.Button("New"))
                {
                    //文件夹路径
                    string assetPath = "Assets/SunRise720/Preset/CameraPosition/";
                    if (!Directory.Exists(assetPath)) { Directory.CreateDirectory(assetPath); }
                    //文件路径
                    string assetName = "Cam";
                    string path = Path.Combine(assetPath, assetName + ".asset");
                    FileInfo fileInfo = new FileInfo(path);
                    //文件同名
                    if (fileInfo.Exists)
                    {
                        assetName += ("_" + Sun.Rise.GetGUIDLast());
                        path = Path.Combine(assetPath, assetName + ".asset");
                    }

                    CameraTargetScriptableObject newAsset = CreateInstance<CameraTargetScriptableObject>();
                    AssetDatabase.CreateAsset(newAsset, path);
                    sTarget.sObj = newAsset;
                }
            }
        }
    }
#endif
}
