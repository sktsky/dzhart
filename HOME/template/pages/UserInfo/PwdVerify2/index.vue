<!-- 邮箱验证begin -->
<template id="PwdVerify2">
  <div class="mright">
    <h2 style="color:#646464; margin:20px 0 0 20px;">邮箱验证</h2>
    <div class="step">
      <el-steps :active="active" finish-status="success">
        <el-step title="输入邮箱地址"></el-step>
        <el-step title="发送邮箱验证码"></el-step>
        <el-step title="认证完成"></el-step>
      </el-steps>
      <div class="1" v-if=" active === 1">
        <table class="userinfo_table">
          <tbody>
            <tr class="texMail1">
              <td class="col1">认证邮箱：</td>
              <td class="col2">
                邮箱认证后将获得
                <span class="Orange">10</span>藏币和
                <span class="Orange">1</span>信誉值.
              </td>
            </tr>
            <tr>
              <td class="col1">新邮箱地址：</td>
              <td class="col2">
                <el-input style="width:248px;" placeholder="请输入内容" v-model="input" clearable></el-input>
              </td>
            </tr>
            <tr>
              <td></td>
            </tr>
          </tbody>
        </table>
        <el-button style="margin-top: 12px; margin-left:250px;" @click="next">下一步</el-button>
      </div>
      <div class="2" v-if=" active === 2">
        <table class="userinfo_table">
          <tbody>
            <tr>
              <td class="col1">您的邮箱是：</td>
              <td class="col2">
                <label id="lbMobile1" style="font-weight:700;">332886253@qq.com</label>
                <a href="Mail_a.aspx" style="color:#3366cc; margin-left:20px;">返回重新输入</a>
              </td>
            </tr>
            <tr>
              <td class="col1"></td>
              <td class="col2">
                <el-button type="primary" plain>点击发送验证链接到邮箱</el-button>
              </td>
            </tr>
          </tbody>
        </table>

        <el-button style="margin-top: 12px; margin-left:250px;" @click="next">下一步</el-button>
      </div>
      <div class="3" v-if=" active === 3">
        <table class="userinfo_table bindmobile" style="display: table;">
          <tbody>
            <tr>
              <td class="col1">验证结果：</td>
              <td class="col2">
                <el-col :span="12">
                  <el-card shadow="always">验证完成！</el-card>
                </el-col>
              </td>
            </tr>
          </tbody>
        </table>
        <el-button style="margin-top: 12px; margin-left:250px;">返回个人信息</el-button>
      </div>
      <br>
      <div class="remind">
        <b>联系客服人工处理
          <!-- <a
            href="http://pay.cang.com/myhome/msg/msgWrite.aspx?name=Jerry"
            target="_blank"
          >点击发站内信给Jerry</a>-->
        </b>
        <br>您可以通过提供相关身份信息，申请客服人工找回。
        <br>1 填写账户信息核实身份；
        <br>2 客服人工审核2个工作日；
        <br>3 审核通过，成功修改。
        <br>
        <br>
      </div>
      <br>
      <br>
      <br>
      <br>
      <br>
    </div>
  </div>
</template>

<script>
import "~/assets/css/UserInfo.css";
export default {
  data() {
    return {
      active: 1,
      input: ""
    };
  },
  methods: {
    next() {
      if (this.active++ > 2) this.active = 1;
    }
  }
};
</script>

<style>
</style>