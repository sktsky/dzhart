<!-- 身份验证 -->
<template id="UserCard">
  <div class="mright UserCard">
    <h2 style="color: #646464; margin: 20px 0 0 20px;">身份认证</h2>
    <div style="margin: 40px 0 0 20px;">
      <el-form
        ref="form"
        :model="form"
        label-width="85px"
        size="medium"
        style="width:60%;padding-left:25px"
      >
        <el-form-item label="用户名：">
          <b>yeyou33</b>
        </el-form-item>
        <el-form-item label="真实姓名：">
          <el-input v-model="form.name" style="width:120px;"></el-input>
        </el-form-item>
        <el-form-item label="证件号码：">
          <el-input v-model="form.number" style="width:248px;"></el-input>
        </el-form-item>
        <el-form-item>
          <el-upload
            class="upload-demo"
            action="http://localhost:8082/upload.do"
            name="picFile"
            :on-preview="handlePreview"
            :on-remove="handleRemove"
            :file-list="fileList"
            list-type="picture"
          >
            <el-button size="small" type="primary">点击上传</el-button>
            <div slot="tip" class="el-upload__tip">只能上传jpg/png文件，且不超过500kb</div>
          </el-upload>
        </el-form-item>
        <el-form-item>
          <b>
            <span style="color:#E4393C">审核不通过</span>常见原因：
            <br>上传顺序没按：1.手持照，2.证件正面照，3.证件反面照 这个顺序上传。
          </b>
        </el-form-item>
        <el-form-item>
          <el-button type="primary" @click="onSubmit">提交</el-button>
        </el-form-item>
      </el-form>
      <div class="reg-card"></div>
      <div class="remind">
        <strong>身份证上传须知</strong>
        <br>1、您还没有进行实名制身份验证，此页面就是上传有效身份证件照片进行实名制身份验证页面；
        <br>2、有效身份证件包括：身份证、驾驶证、护照等能够真实证明自己身份的合法证件；
        <br>3、上传的身份证件照片要清晰可见，不要做任何遮掩；
        <br>4、身份证件照片只有您自己和华夏收藏网管理员可见；
        <br>5、1个身份证件只能使用于1个用户名的认证；
        <br>6、图片尺寸要求长宽均不能超过1000像素,格式为jpg、gif、jpeg、bmp；
        <br>7、证件照片需按顺序为手持证件照、证件正面、证件背面上传；
        <br>8、如果不知证件照片是什么样的，请参考[查看身份证样式]；
        <br>9、身份证件上传之后需要管理员进行审核后才可以通过；
        <br>10、
        <a
          href="http://news.cang.com/Info/77851.html"
          target="_blank"
          style="color: red"
        >不会上传身份证件的请将身份证件图片发送至邮箱cj@hxscw.com（注明网名），我们帮您验证（1-3个工作日完成）。</a>
        <br>
      </div>
    </div>

    <br>
    <br>
  </div>
</template>

<script>
import "~/assets/css/jystyle.css";
import axios from "axios";
export default {
  data() {
    return {
      fileList: [],
      form: {
        name: "",
        number: "",
        file: []
      }
    };
  },
  methods: {
    handleRemove(file, fileList) {
      console.log(file, fileList);
    },
    handlePreview(file) {
      console.log(file);
    },
    onSubmit() {
      //表单上传提交
      var obj = this.form;
      axios
        .post("http://localhost:8082/dzhshop/add.do", obj)
        .then(function(response) {
          console.log(response);
        })
        .catch(function(error) {
          console.log(error);
        });
    }
  }
};
</script>

<style>
</style>