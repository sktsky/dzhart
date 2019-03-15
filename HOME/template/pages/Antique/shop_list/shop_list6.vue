	<!-- 店铺信息修改2 begin -->
	<template id="shop_list6">
            <div id="shop_cz_box" class="shop_cz_box">
                <table width="100%" class="tbl_tbp" border="0">
                  <tbody><tr>
                    <td colspan="2">[店铺开通/续费日期：<font id="txtRegDate" color="red">2018/12/23</font>，下一次续费日期：<font id="txtRegNextDate" color="red">2019/12/23</font>]</td>
                  </tr>
                  <tr>
                    <td style="width:70px;">商店名称：</td>
                    <td id="txtShopName">良品铺子</td>

                  </tr>
                  <tr>
                    <td>店长姓名：</td>
                    <td id="txtUserName">张良</td>

                  </tr>
                  <tr>
                    <td>所在省市：</td>
                    <td>
                    <div class="shop_m_xzbox fl">
                        <ul class="shop_m_xzsel_ul" style="display:none; ">
                            <li class="">北京</li>
                            <li class="">上海</li>
                            <li class="">天津</li>
                            <li class="">重庆</li>
                            <li class="">江苏</li>
                            <li class="">浙江</li>
                            <li class="">广东</li>
                            <li class="">海南</li>
                            <li class="">福建</li>
                            <li class="">山东</li>
                            <li class="">江西</li>
                            <li class="">四川</li>
                            <li class="">安徽</li>
                            <li class="">河北</li>
                            <li class="">河南</li>
                            <li class="">湖北</li>
                            <li class="">湖南</li>
                            <li class="">陕西</li>
                            <li class="">山西</li>
                            <li class="">黑龙江</li>
                            <li class="">辽宁</li>
                            <li class="">吉林</li>
                            <li class="">广西</li>
                            <li class="">云南</li>
                            <li class="">贵州</li>
                            <li class="">甘肃</li>
                            <li class="">内蒙</li>
                            <li class="">宁夏</li>
                            <li class="">西藏</li>
                            <li class="">新疆</li>
                            <li class="">青海</li>
                            <li class="">香港</li>
                            <li class="">澳门</li>
                            <li class="">台湾</li>
                            <li class="">国外</li>
	                    </ul>
                        <input name="ddlUserPro" type="text" id="ddlUserPro" onfocus="$(this).blur()" value="广东">
                    </div>

                    <input name="txtCity" type="text" id="txtCity" style="display: inline;height: 24px;line-height: 24px;width: 110px;
background: none;padding: 3px 5px;border: 1px solid #CCC;margin-left: 15px;float: left;">
                    </td>
                  </tr>
                  <tr>
                    <td>联系方式：</td>
                    <td><input name="txtUserContact" type="text" value="13521729935" id="txtUserContact" style="display: inline;height: 24px;line-height: 24px;
width: 247px;background: none;padding: 3px 5px;border: 1px solid #CCC;float: left;"></td>
                  </tr>
                  <tr>
                    <td>店铺公告：</td>
                    <td>
                    <textarea name="txtShopInfo" rows="2" cols="20" id="txtShopInfo" style="height: 80px;line-height: 18px;width: 600px;border: 1px solid #CCC;outline: 0;padding: 5px;resize: none;"></textarea>
                    </td>
                  </tr>
                  <tr>
                    <td>店铺介绍：</td>
                    <td>
                    <textarea name="txtShopDes" rows="2" cols="20" id="txtShopDes" style="height: 80px;line-height: 18px;width: 600px;border: 1px solid #CCC;outline: 0;padding: 5px;resize: none;"></textarea>
                    </td>
                  </tr>
                  <tr>
                    <td>经营范围：</td>
                    <td>
                    <textarea name="txtShopRange" rows="2" cols="20" id="txtShopRange" style="height: 80px;line-height: 18px;width: 600px;border: 1px solid #CCC;outline: 0;padding: 5px;resize: none;"></textarea>
                    </td>
                  </tr>
                  <tr>
                    <td>购买说明：</td>
                    <td><textarea name="txtHowBuy" rows="2" cols="20" id="txtHowBuy" style="height: 80px;line-height: 18px;width: 600px;border: 1px solid #CCC;outline: 0;padding: 5px;resize: none;"></textarea></td>
                  </tr>
                  <tr>
                    <td>店铺标识：</td>
                    <td>
                    <iframe id="Spic1" src="./店铺资料修改 _ 华夏收藏网_files/uploadShopLogo.html" width="235" frameborder="no" scrolling="no" height="70"></iframe><a href="javascript:void(0);" onclick="RePic()" style="color:#646464;font-weight:bold;">[点击清除当前图片]</a><font class="red">（注：宽：230px,高：70px）</font><input name="f_pic1" type="hidden" id="f_pic1">
                    </td>
                  </tr>
                  <tr>
                    <td>&nbsp;</td>
                    <td>
                    <input type="submit" name="btnMod" value="修改" id="btnMod" class="shop_img btn_y80_25">
                    <input type="reset" value="重写" name="B2" class="shop_img btn_b80_25">
                    </td>
                  </tr>
                </tbody></table>
                
            </div>
	</template>	

<script>
</script>

<style>
</style>