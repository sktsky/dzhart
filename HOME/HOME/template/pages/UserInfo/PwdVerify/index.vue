<!-- 手机绑定 -->
<template>
  <div class="mright">
    <h2 style="color:#646464; margin:20px 0 0 20px;">安全认证</h2>

    <div class="step">
      <el-steps :active="active" finish-status="success">
        <el-step title="输入手机号"></el-step>
        <el-step title="发送手机验证码"></el-step>
        <el-step title="认证完成"></el-step>
      </el-steps>
      <div class="1" v-if="active === 1">
        <table class="userinfo_table">
          <tbody>
            <tr class="texTel1">
              <td class="col1">绑定手机：</td>
              <td class="col2">
                成功绑定后将获得
                <span class="Orange">10</span>藏币和
                <span class="Orange">1</span>信誉值.
              </td>
            </tr>
            <tr>
              <td class="col1">手机区域号：</td>
              <td class="col2">
                <el-select v-model="form.areacode" placeholder="请选择">
                  <el-option
                    v-for="item in phonevalue"
                    :key="item.value"
                    :label="item.label"
                    :value="item.value"
                  ></el-option>
                </el-select>
              </td>
            </tr>
            <tr>
              <td class="col1">手机号码：</td>
              <td class="col2">
                <el-col :span="12">
                  <el-input v-model="form.phoneId" placeholder="请输入手机号"></el-input>
                </el-col>
              </td>
            </tr>
          </tbody>
        </table>
        <el-button style="margin-top: 12px; margin-left:250px;" @click="next">下一步</el-button>
      </div>
      <div class="2" v-if=" active === 2">
        <table class="userinfo_table bindmobile" style="display: table;">
          <tbody>
            <tr>
              <td class="col1">验证方式：</td>
              <td class="col2">
                <b>手机</b>
              </td>
            </tr>
            <tr>
              <td class="col1">已绑定手机号：</td>
              <td class="col2">
                <label id="lbBindMobile" style="font-weight:700;">{{form.phoneId}}</label>
              </td>
            </tr>
            <tr>
              <td class="col1"></td>
              <td class="col2">
                <el-button type="primary" plain>点击发送验证码到手机</el-button>
              </td>
            </tr>
            <tr>
              <td class="col1">验证码：</td>
              <td class="col2">
                <el-col :span="12">
                  <el-input v-model="form.VerificationCode" placeholder="请输入验证码"></el-input>
                </el-col>
              </td>
            </tr>
            <tr>
              <td></td>
            </tr>
          </tbody>
        </table>
        <el-button style="margin-top: 12px; margin-left:250px;" @click="send()">下一步</el-button>
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
        <nuxt-link to="/UserInfo/PersonalIndex">
          <el-button style="margin-top: 12px; margin-left:250px;">返回个人信息</el-button>
        </nuxt-link>
      </div>
      <div class="clear"></div>
    </div>

    <table class="userinfo_table unbind" style="display: none;">
      <tbody>
        <tr>
          <td class="col1">用户名：</td>
          <td class="col2">
            <b>sktsky</b>
          </td>
        </tr>

        <tr>
          <td class="col1">交易密码：</td>
          <td class="col2">
            <input id="texTel" maxlength="50" class="input-text" type="password">
          </td>
        </tr>
        <tr>
          <td></td>
        </tr>
      </tbody>
    </table>

    <br>

    <div class="remind">
      <b>
        联系客服人工处理
        <a
          href="http://pay.cang.com/myhome/msg/msgWrite.aspx?name=jerry"
          target="_blank"
        >点击发站内信给Jerry</a>
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
</template>


<script>
import "~/assets/css/element.css"; //element自定义样式
import "~/assets/css/element-icons.ttf";
import "~/assets/css/element-icons.woff";
import "~/assets/css/UserInfo.css";
import phoneApi from "@/api/phone"; //手机验证api
export default {
  data() {
    return {
      active: 1,
      phonevalue: [
        {
          value: "86",
          label: "中国 china +86"
        },
        {
          value: "852",
          label: "香港 Hong Kong +852"
        },
        {
          value: "853",
          label: "澳门 Macao +853"
        },
        {
          value: "886",
          label: "台湾 Taiwan +886"
        },
        {
          value: "81",
          label: "日本 Japan +81"
        },
        {
          value: "选82",
          label: "韩国 Korea +82"
        },
        {
          value: "1",
          label: "美国 USA +1"
        },
        {
          value: "1",
          label: "加拿大 Canada +1"
        },
        {
          value: "61",
          label: "澳大利亚 Australia +61"
        },
        {
          value: "7",
          label: "俄罗斯 Russia +7"
        },
        {
          value: "44",
          label: "英国 United Kingdom +44"
        },
        {
          value: "49",
          label: "德国 Germany +49"
        },
        {
          value: "33",
          label: "法国 France +33"
        },
        {
          value: "34",
          label: "西班牙 Spain +34"
        },
        {
          value: "39",
          label: "意大利 Italy +39"
        },
        {
          value: "351",
          label: "葡萄牙 Portugal +351"
        },
        {
          value: "36",
          label: "匈牙利 Hungary +36"
        },
        {
          value: "358",
          label: "芬兰 Finland +358"
        },
        {
          value: "46",
          label: "瑞典 Sweden +46"
        },
        {
          value: "65",
          label: "新加披 Singapore +65"
        },
        {
          value: "60",
          label: "马来西亚 Malaysia +60"
        }
      ],
      phone: "",
      value: "",
      form: {
        areacode: "",
        phoneId: "",
        VerificationCode: "",
        username: "admin",
        password: "123456"
      }
    };
  },
  //下一步
  methods: {
    next() {
      if (this.active++ > 2) this.active = 1;
    },
    send() {
      phoneApi.send(this.form).then(require => {
        //消息提示
        this.$message({
          message: require.data.message,
          type: require.data.success ? "success" : "error"
        });
      });
      this.active = 3;
    }
  }
};
</script>

<style>
</style>