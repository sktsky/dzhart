<!-- 登陆密码 -->
<template id="UserPwd">
	<div class="mright chl-reg">
		<h2 style="color:#646464; margin:20px 0 0 20px;">登录密码</h2>
		<div class="reg-form">
			<dl style="margin-left:40px;margin-top:40px;">
				<dd>
					<el-form :model="ruleForm" status-icon :rules="rules" ref="ruleForm" label-width="130px" size="medium" class="demo-ruleForm">
						<el-form-item label="用户名：">
							<b>yeyou33</b>
						</el-form-item>
						<el-form-item label="旧密码：" prop="oldpass">
							<el-input type="password" v-model="ruleForm.oldpass" autocomplete="off" style="width:170px;"></el-input>
						</el-form-item>
						<el-form-item label="输入新密码：" prop="pass">
							<el-input type="password" v-model="ruleForm.pass" autocomplete="off" style="width:170px;"></el-input>
						</el-form-item>
						<el-form-item label="确认输入密码：" prop="checkPass">
							<el-input type="password" v-model="ruleForm.checkPass" autocomplete="off" style="width:170px;"></el-input>
						</el-form-item>
						<el-form-item>
							<el-button type="primary" @click="submitForm('ruleForm')">提交</el-button>
							<el-button @click="resetForm('ruleForm')">重置</el-button>
						</el-form-item>
					</el-form>
				</dd>
			</dl>

			<div class="remind1">
				<div class="title">友情提醒</div>
				<ul class="show">
					<li>请妥善保存好自己的密码，不要随意透露.</li>
					<li>密码尽可能复杂，不要使用类似"111111","123456","888888","654321",'000000'等密码。</li>
					<li>密码丢失，可以向网站管理员申请索回，网站会将密码以邮件的形式发送到您目前注册的邮箱。</li>
				</ul>
			</div>

			<div class="remind">
				<b>联系客服人工处理 <a href="http://pay.cang.com/myhome/msg/msgWrite.aspx?name=jerry" target="_blank">点击发站内信给Jerry</a></b><br> 您可以通过提供相关身份信息，申请客服人工找回。
				<br> 1 填写账户信息核实身份；<br> 2 客服人工审核2个工作日；<br> 3 审核通过，成功修改。<br>
			</div>
			<br>
			<br>

		</div>
	</div>
</template>

<script>
	import '~/assets/css/jystyle.css'
	export default {
		data() {
			//密码输入框表单验证
			var checkoldpass = (rule, value, callback) => {
				if(value === '') {
					callback(new Error('密码不能为空'));
				} else {

					callback();
				}
			};
			var validatePass = (rule, value, callback) => {
				if(value === '') {
					callback(new Error('请输入密码'));
				} else {
					if(this.ruleForm.checkPass !== '') {
						this.$refs.ruleForm.validateField('checkPass');
					}
					callback();
				}
			};
			//两次密码输入表单验证
			var validatePass2 = (rule, value, callback) => {
				if(value === '') {
					callback(new Error('请再次输入密码'));
				} else if(value !== this.ruleForm.pass) {
					callback(new Error('两次输入密码不一致!'));
				} else {
					callback();
				}
			};
			return {
				ruleForm: {
					pass: '',
					checkPass: '',
					oldpass: ''
				},
				rules: {
					pass: [{
						validator: validatePass,
						trigger: 'blur'
					}],
					checkPass: [{
						validator: validatePass2,
						trigger: 'blur'
					}],
					oldpass: [{
						validator: checkoldpass,
						trigger: 'blur'
					}]
				}
			};
		},
		methods: {
			submitForm(formName) {

			},
			resetForm(formName) {
				//密码重置
				this.$refs[formName].resetFields();
			}
		}
	}
</script>

<style>

</style>