<template>
  <div>
    <!-- 个人资料 begin -->
    <div class="mright">
      <h2 style="color:#646464; margin:20px 0 0 20px;">基本资料</h2>
      <table class="userinfo_table base-info">
        <tbody>
          <tr>
            <td class="col1">用户名：</td>
            <td class="col2">
              <label>
                <b>sktsky</b>
              </label>
            </td>
          </tr>
          <tr>
            <td class="col1">用户头像：</td>
            <td class="col2">
              <span class="pf-avatar-box" id="pf-avatar-box">
                <img :src="headPicList" width="80" height="80">
              </span>
            </td>
          </tr>
          <tr>
            <td class="col1">手机号码：</td>
            <td class="col2">
              <div style="float:left;padding-top:5px;" v-for="(key1,index1) in phonelList" :key="index1">
                <b>{{key1}}</b>
              </div>
              <div class="goto" style="float:left; margin-left:6px;">
                <nuxt-link to="/UserInfo/PwdVerify">
                  <el-button plain size="mini" type="primary">修改绑定</el-button>
                </nuxt-link>
              </div>
            </td>
          </tr>
          <tr>
            <td class="col1">邮箱：</td>
            <td class="col2">
              <div style="float:left;padding-top:5px;" v-for="(key2,index2) in emailList" :key="index2">
                <b>{{key2}}</b>
              </div>
              <div class="goto" style="float:left; margin-left:6px;">
                <nuxt-link to="/UserInfo/PwdVerify2">
                  <el-button plain size="mini" type="primary">修改绑定</el-button>
                </nuxt-link>
              </div>
            </td>
          </tr>
          <tr>
            <td class="col1">所在地：</td>
            <td class="col2">
              <div style="float:left;" v-for="(key3,index3) in provinceList" :key="index3">
                <el-tag type="danger">{{key3}}</el-tag>
              </div>
            </td>
          </tr>
          <tr>
            <td class="col1">性别：</td>
            <td class="col2">
              <div style="float:left;" v-for="(key4,index4) in genderList" :key="index4">
                <b>{{key4}}</b>
              </div>
            </td>
          </tr>
          <tr>
            <td class="col1">生日：</td>
            <td class="col2">
              <div style="float:left;">
                <el-date-picker v-model="birthdayList" :disabled="true" type="date" placeholder="选择日期"></el-date-picker>
              </div>
            </td>
          </tr>
          <tr>
            <td class="col1">QQ号码：</td>
            <td class="col2">
              <div style="float:left;" v-for="(key5,index5) in qqList" :key="index5">
                <b>{{key5}}</b>
              </div>
            </td>
          </tr>
          <tr>
            <td class="col1">微信：</td>
            <td class="col2">
              <div style="float:left;" v-for="(key6,index6) in weixinList" :key="index6">
                <b>{{key6}}</b>
              </div>
            </td>
          </tr>
          <tr>
            <td class="col1">爱好：</td>
            <td class="col2">
              <div style="float:left;" v-for="(key7,index7) in hobbyList" :key="index7">
                <el-tag type="danger">{{key7}}</el-tag>
              </div>
            </td>
          </tr>
          <tr>
            <td class="col1">联系地址：</td>
            <td class="col2">
              <div style="float:left;" v-for="(key8,index8) in addressList" :key="index8">
                <b>{{key8}}</b>
              </div>
            </td>
          </tr>
          <tr>
            <td class="col1">个人简介：</td>
            <td class="col2">
              <div style="float:left;" v-for="(key9,index9) in profileList" :key="index9">
                <b>{{key9}}</b>
              </div>
            </td>
          </tr>
          <tr>
            <td class="col1"></td>
            <td class="col2">
              <el-button
                icon="el-icon-edit-outline"
                @click="handleEdit()"
                round
                type="primary"
              >修改个人信息</el-button>
            </td>
          </tr>
        </tbody>
      </table>
      <br>
      <el-dialog title="个人信息编辑" :model="form" label-width="80px" :visible.sync="dialogFormVisible">
        <el-form label-width="80px">
          <el-row>
            <el-col :span="12">
              <el-form-item label="用户名">
                <el-input :disabled="true" v-model="form.name" placeholder="用户名"></el-input>
              </el-form-item>
            </el-col>
          </el-row>
          <el-form-item label="上传头像:">
            <el-upload
              ref="upload"
              action="http://localhost:8082/upload.do"
              name="picFile"
              list-type="picture-card"
              :on-preview="handlePictureCardPreview"
              :on-success="handleSuccess"
              :before-upload="beforeAvatarUpload"
            >
              <i class="el-icon-plus"></i>
            </el-upload>
            <el-dialog :visible.sync="dialogVisible">
              <img width="100%" :src="dialogImageUrl" alt>
            </el-dialog>
          </el-form-item>
          <el-row>
            <el-col :span="12">
              <el-form-item label="手机号码">
                <el-input :disabled="true" v-model="form.phone" placeholder="手机号码"></el-input>
              </el-form-item>
            </el-col>
          </el-row>
          <el-row>
            <el-col :span="12">
              <el-form-item label="邮箱">
                <el-input :disabled="true" v-model="form.email" placeholder="邮箱"></el-input>
              </el-form-item>
            </el-col>
          </el-row>
          <el-form-item label="所在地">
            <el-cascader
              size="large"
              :options="options"
              v-model="form.province"
              @change="handleChange"
            ></el-cascader>
          </el-form-item>
          <el-form-item label="性别:">
            <el-radio-group v-model="form.gender">
              <el-radio v-model="form.gender" label="男" border></el-radio>
              <el-radio v-model="form.gender" label="女" border></el-radio>
              <el-radio v-model="form.gender" label="其他" border></el-radio>
            </el-radio-group>
          </el-form-item>
          <el-form-item label="生日:">
            <el-date-picker
              v-model="form.birthday"
              type="date"
              placeholder="选择日期"
              format="yyyy 年 MM 月 dd 日"
              value-format="yyyy-MM-dd"
            ></el-date-picker>
          </el-form-item>
          <el-row>
            <el-col :span="12">
              <el-form-item label="QQ号码">
                <el-input v-model="form.qq" placeholder="QQ号码"></el-input>
              </el-form-item>
            </el-col>
          </el-row>
          <el-row>
            <el-col :span="12">
              <el-form-item label="微信">
                <el-input v-model="form.weixin" placeholder="微信"></el-input>
              </el-form-item>
            </el-col>
          </el-row>
          <el-form-item label="爱好:">
            <el-col :span="24">
              <el-checkbox-group v-model="form.hobby">
                <el-checkbox label="瓷器"></el-checkbox>
                <el-checkbox label="玉器"></el-checkbox>
                <el-checkbox label="字画"></el-checkbox>
                <el-checkbox label="钱币"></el-checkbox>
                <el-checkbox label="木器"></el-checkbox>
                <el-row>
                  <el-checkbox label="铜器"></el-checkbox>
                  <el-checkbox label="珠宝"></el-checkbox>
                  <el-checkbox label="钟表西洋器"></el-checkbox>
                  <el-checkbox label="文献书籍"></el-checkbox>
                </el-row>
                <el-checkbox label="杂项"></el-checkbox>
              </el-checkbox-group>
            </el-col>
          </el-form-item>
          <el-row>
            <el-col :span="18">
              <el-form-item label="联系地址:">
                <el-input v-model="form.address"></el-input>
              </el-form-item>
            </el-col>
          </el-row>
          <el-row>
            <el-col :span="18">
              <el-form-item label="个人简介:">
                <el-input type="textarea" v-model="form.profile" :rows="5"></el-input>
              </el-form-item>
            </el-col>
          </el-row>
          <el-form-item>
            <el-button icon="el-icon-circle-check" type="primary" @click="save()">保存</el-button>
            <el-button icon="el-icon-circle-close" @click="dialogFormVisible = false">关闭</el-button>
          </el-form-item>
        </el-form>
      </el-dialog>
    </div>
  </div>
</template>

<script>
import "~/assets/css/element.css"; //element自定义样式
import "~/assets/css/element-icons.ttf";
import "~/assets/css/element-icons.woff";
import "~/assets/css/UserInfo.css"; //用户页面样式
import "~/assets/css/jystyle.css"; //家园样式
import personalIndexApi from "@/api/personalIndex"; //用户数据api
// import { getData } from "~/plugins/axios.js";
import { regionData, CodeToText } from "element-china-area-data";
import qs from "qs";
export default {
  data() {
    return {
      items: [],
      phonelList:"",
      provinceList: [], //所在地
      options: regionData, //地区数据源
      dialogImageUrl: "", //上传图片回显地址
      dialogVisible: false, //上传图片回显初始状态
      hobbyList: [], //爱好
      qqList: "", //qq
      weixinList: "", //weixin
      addressList: "", //详细地址
      profileList: "", //个人简介
      birthdayList: "", //生日
      genderList: "", //性别
      emailList: "", //邮箱
      phoneList: "", //手机
      headPicList: "", //头像
      form: {
        sellerId: "1", //商家名称
        headPic: "", //上传头像
        province: [], //所在地
        gender: "", //性别
        birthday: "", //生日
        qq: "", //QQ
        weixin: "", //微信
        hobby: [], //爱好
        address: "", //地址
        profile: "" //个人简介
      },
      dialogFormVisible: false //编辑窗口是否可见
    };
  },
  created() {
    this.fetchData();
  },
  methods: {
    //获得用户信息
    fetchData() {
      personalIndexApi.getList().then(
        res => {
          this.items = res.data;
          var obj = res.data;
          var arr = [];
          for (let i in obj) {
            let o = {};
            o[i] = obj[i];
            arr.push(o);
          }
          //console.log(arr);
          this.items = arr;
          //console.log(self.items[5].headPic);
          //字符串转为数组
          //var strNew = eval(self.items[5].headPic);
          //console.log(strNew[0])

          // self.newheadPic = eval(self.items[11].province);
          //console.log(self.newheadPic)
          this.provinceList = eval(this.items[11].province);
          this.headPicList = this.items[5].headPic;
          this.emailList = this.items[3].email;
          this.phoneList = this.items[9].phone;
          this.genderList = this.items[4].gender;
          this.qqList = this.items[12].qq;
          this.weixinList = this.items[14].weixin;
          this.addressList = this.items[0].address;
          this.profileList = this.items[10].profile;
          this.birthdayList = this.items[1].birthday;
          this.hobbyList = eval(this.items[6].hobby);
        },
        function() {
          console.log("请求失败");
        }
      );
    },
    //保存数据提交
    save() {
      personalIndexApi.save(this.form).then(require => {
        //消息提示
        this.$message({
          message: require.data.message,
          type: require.data.success ? "success" : "error"
        });
      });
      this.dialogFormVisible = false; //关闭窗口
    },
    //打开编辑窗口
    handleEdit() {
      this.dialogFormVisible = true; //打开窗口
    },
    //图片上传成功后赋值
    handleSuccess(response) {
      //console.log(file)
      console.log(response);
      this.form.headPic = response.url;
      //console.log(self.form.file);
    },

    handlePictureCardPreview(file) {
      this.dialogImageUrl = file.url;
      this.dialogVisible = true;
    },
    beforeAvatarUpload(file) {
      const isJPG = file.type === "image/jpeg";
      const isLt2M = file.size / 1024 / 1024 < 2;

      if (!isJPG) {
        this.$message.error("上传头像图片只能是 JPG 格式!");
      }
      if (!isLt2M) {
        this.$message.error("上传头像图片大小不能超过 2MB!");
      }
      return isJPG && isLt2M;
    },
    //区域码转换
    handleChange(value) {
      this.form.province = [
        CodeToText[value[0]],
        CodeToText[value[1]],
        CodeToText[value[2]]
      ];
    }
  }
};
</script>

<style>
.text {
  font-size: 14px;
}

.item {
  padding: 18px 0;
}

.box-card {
  width: 800px;
}
</style>