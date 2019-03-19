<!-- 申请开店 -->
<template id="openshop">
  <div class="mright">
    <h2 style="color:#646464; margin:20px 0 0 20px;">申请开店</h2>
    <el-steps :active="active" finish-status="success" simple style="margin-top: 20px">
      <el-step title="同意网站相关规定"></el-step>
      <el-step title="填写相关资料"></el-step>
      <el-step title="汇款开通"></el-step>
    </el-steps>

    <div v-if=" active === 0 ">
      <div class="step">
        <div style="width:100%;height:auto;">
          <p style="margin-top:30px;font-size:16px;color:#333333;">一、公司简介</p>
          <p
            style="font-size:16px;color:#333333;"
          >&nbsp;&nbsp;华夏收藏网创建于2003年4月，古玩收藏、鉴定估价、淘宝捡漏、在线拍卖的专业性网站，是国内运营规范的艺术类收藏知名 品牌网站。本站有100万注册用户，日均20万UV，给广大的藏友爱好者提供了一个坚实可靠的古玩交易平台。</p>
          <p style="margin-top:20px;font-size:16px;color:#333333;">二、开店优势</p>
          <p style="font-size:16px;color:#333333;">①超低手续费；
            <br>②零藏币上传；
            <br>③一键导入功能；
            <br>④藏品集中展示；
            <br>⑤藏品优先审核；
            <br>⑥多形式的网店活动（可申请网店促销，秒杀等活动）；
            <br>⑦一对一网店运营指导；
            <br>⑧多渠道藏品推送（可申请免费展销会，微拍上传以及APP专拍）；
            <br>⑨吸引大买家下单；
            <br>⑩商家信誉值快速提升；
          </p>
          <p style="margin-top:15px;">
            <input type="checkbox" checked="checked" onchange="ss()">我已阅读并同意
            <a href="javascript:void(0)" style=" text-decoration:underline;">《华夏收藏网个人/网店交易守则》</a>
          </p>
        </div>
      </div>
      <el-button type="primary" style="margin-top: 12px; margin-left:50%;" @click="next">下一步</el-button>
    </div>

    <div v-if=" active === 1 ">
      <div class="step">
        <el-form ref="form" :model="form" label-width="80px">
          <el-form-item label="用户名称">
            <el-input v-model="form.username"></el-input>
          </el-form-item>
          <el-form-item label="网店名称">
            <el-input v-model="form.nickName"></el-input>
          </el-form-item>
          <el-form-item label="网店类别">
            <el-select v-model="form.shoptype" placeholder="请选择">
              <el-option
                v-for="item in catList"
                :key="item.value"
                :label="item.name"
                :value="item.name"
              ></el-option>
            </el-select>
          </el-form-item>
          <el-form-item label="店长姓名">
            <el-input v-model="form.shopname"></el-input>
          </el-form-item>
          <template>
            <el-form-item label="所在省份">
              <el-select v-model="form.province" placeholder="请选择">
                <el-option
                  v-for="item in cityList"
                  :key="item.value"
                  :label="item.province"
                  :value="item.province"
                ></el-option>
              </el-select>
            </el-form-item>
          </template>
          <el-form-item label="联系电话">
            <el-input v-model="form.telephone"></el-input>
          </el-form-item>
          <el-form-item>
            <el-button type="primary" @click="send()">立即提交</el-button>
            <el-button>取消</el-button>
          </el-form-item>
        </el-form>
        <div class="clear"></div>
      </div>
    </div>

    <div v-if=" active === 2 ">
      <div class="step">
        <div
          style="margin-top:30px;padding-bottom:10px;font-size:16px;color:#333333;font-weight:bold;"
        >尊敬的用户 , 您在大中华艺术网申请的网上商店已成功申请</div>
        <p
          style="font-size:16px;color:#333333;font-weight:bold;padding-bottom:10px;"
        >点击下面立即开通进入我的店铺管理，汇款成功后可立即开通网上商店；</p>
        <br>
        <el-button type="primary">立即开通</el-button>
      </div>
    </div>

    <br>
    <br>
    <br>
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
import "~/assets/css/UserInfo.css";
import "~/assets/css/jystyle.css";
import openshopApi from "@/api/openshop";
import { regionData, CodeToText } from "element-china-area-data";
export default {
  data() {
    return {
      options: regionData, //地区数据源
      active: 0,
      form: {
        username: "admin", //用户名
        nickName: "", //网店名称
        shoptype: "", //网店类别
        shopname: "", //店长姓名
        province: "", //所在省份
        telephone: "" //联系电话
      }
    };
  },
  methods: {
    //申请提交
    send() {
      openshopApi.send(this.form).then(require => {
        this.$message({
          message: require.data.message,
          type: require.data.success ? "success" : "error"
        });
      });
      this.active = 2;
    },
    //下一步骤
    next() {
      if (this.active++ > 2) this.active = 0;
    }
  },
  // created: function() {
  //   var self = this;
  //   //获取网店类别
  //   axios
  //     .get("http://localhost:8082/itemCat/findByParentId.do?parentId=0")
  //     .then(
  //       function(res) {
  //         self.catList = res.data;
  //       },
  //       function() {
  //         console.log("请求失败");
  //       }
  //     );
  // }
};
</script>

<style>
</style>