<!--安全设置-->
<template>
  <div class="mright">
    <h2 style="color:#646464; margin:20px 0 0 20px;">安全设置</h2>
    <div class="list_info">您上次登录时间是 2018-08-17 11:24:19 ， 登录IP是：10.81.85.227
      <br>
      <br>
      <b>建议您启用全部安全设置，以保证您的账号安全</b>
      <br>
      <br>
      <table>
        <tbody>
          <tr>
            <td>
              <div class="safe-grade">安全指数：</div>
            </td>
            <td>
              <div class="score-step">
                <el-progress
                  :text-inside="true"
                  :stroke-width="20"
                  :percentage="80"
                  color="#E4393C"
                  status="exception"
                ></el-progress>
              </div>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
    <div class="list_info">
      <div class="menu_img imgico1"></div>
      <div class="litite">登录密码</div>
      <div class="litite liInfo">定期修改登录密码，可提高账户安全性。</div>
      <div class="litite" id="score_detaila">
        <router-link to="/UserPwd">立即修改</router-link>
      </div>
      <div class="clear"></div>
    </div>
    <div class="list_info">
      <div class="menu_img ico-card-0"></div>
      <div class="litite">身份认证</div>
      <div class="litite liInfo">身份认证后，你的权限更多。</div>
      <div class="litite" id="score_detailb">
        <router-link to="/UserCard">立即认证</router-link>
      </div>
      <div class="clear"></div>
    </div>
    <div class="list_info">
      <div class="menu_img imgico2"></div>
      <div class="litite">交易密码</div>
      <div class="litite liInfo">互联网账号存在被盗风险，建议您定期更改交易密码以保护账户安全。</div>
      <div class="litite" id="score_detailc">
        <router-link to="/ChangePayPasswd">立即设置</router-link>
      </div>
      <div class="clear"></div>
    </div>
    <div class="list_info">
      <div class="menu_img imgico12"></div>
      <div class="litite">手机认证</div>
      <div class="litite liInfo">您认证的手机号是：155***5970</div>
      <div class="litite" id="score_detaild">
        <router-link to="/PwdVerify">更换手机号码</router-link>
      </div>
      <div></div>
      <div class="clear"></div>
    </div>
    <div class="list_info">
      <div class="menu_img imgico23 imgico13"></div>
      <div class="litite">邮箱认证</div>
      <div class="litite liInfo">认证后可用邮箱找回密码</div>
      <div class="litite" id="score_detaile">
        <router-link to="/PwdVerify2">修改邮箱</router-link>
      </div>
      <div class="clear"></div>
    </div>
    <br>
    <br>
    <div class="remind">
      <b>
        联系客服人工处理
        <!-- <a
          href="http://pay.cang.com/myhome/msg/msgWrite.aspx?name=jerry"
          target="_blank"
        >点击发站内信给Jerry
		</a> -->
      </b>
      <br>您可以通过提供相关身份信息，申请客服人工找回。
      <br>1 填写账户信息核实身份；
      <br>2 客服人工审核2个工作日；
      <br>3 审核通过，成功修改。
      <br>
      <br>
      <b>安全服务提示</b>
      <br>确认您登录的是华夏收藏网网址：www.dzhart.art，注意防范进入钓鱼网站，不要轻信各种即时通讯工具发送的商品或支付链接，谨防诈骗。
      <br>建议您安装杀毒软件，并定期更新操作系统等软件补丁，确保账户及交易安全。
      <br>
    </div>
    <br>
    <br>
  </div>
</template>

<script>
import "~/assets/css/element.css"; //element自定义样式
import "~/assets/css/element-icons.ttf";
import "~/assets/css/element-icons.woff";
import "~/assets/css/UserInfo.css";
export default {};
</script>

<style>
/*  安全指数进度条  */
.score-step,
.score-state-left,
.score-state-right,
.score-btn,
.mod-account-avatar {
  background: url(/images/ucenter_1.png) no-repeat 0 0;
}
.score-step {
  background-position: 0 -138px;
  width: 435px;
  height: 20px;
  margin: 14px 0 0 0;
  display: inline;
  float: left;
}
.score-state-left {
  float: left;
  width: 5px;
  height: 10px;
  background-position: 0 -180px;
}
.score-state-right {
  float: left;
  height: 10px;
  background-position: right -180px;
}
.score-num {
  color: #f00000;
}
.score-num {
  font-size: 28px;
  font-family: \5fae\8f6f\96c5\9ed1, \9ed1\4f53;
  margin-left: 10px;
  line-height: 34px;
  float: left;
}
.pay_in .calculator td {
  padding: 5px;
}
</style>