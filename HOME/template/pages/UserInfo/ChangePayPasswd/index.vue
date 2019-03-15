<!-- 设置交易密码 -->
<template id="ChangePayPasswd">
	<div class="mright ChangePayPasswd">
		<h2 style="color:#646464; margin:20px 0 0 20px;">设置交易密码</h2>
		<dl style="margin-left:40px;margin-top:40px;">
			<dd>
				<el-form :model="ruleForm" status-icon :rules="rules" ref="ruleForm" label-width="150px" size="medium" class="demo-ruleForm">
					<el-form-item label="用户名：">
						<b>yeyou33</b>
					</el-form-item>
					<el-form-item label="交易密码：" prop="pass">
						<el-input type="password" v-model="ruleForm.pass" autocomplete="off" style="width:180px;padding-right:20px;"></el-input><label>6～16字符（字母、数字、特殊符号）</label>
					</el-form-item>
					<el-form-item label="再次输入交易密码：" prop="checkPass">
						<el-input type="password" v-model="ruleForm.checkPass" autocomplete="off" style="width:180px;padding-right:20px;"></el-input><label>为了交易安全，请设置跟登录密码不一样的密码</label>
					</el-form-item>
					<el-form-item>
						<el-button type="primary" @click="submitForm('ruleForm')">提交</el-button>

					</el-form-item>
				</el-form>
			</dd>
		</dl>

		<br>
		<br>
		<div class="remind1">
			<div class="title">友情提醒</div>
			<ul class="show">
				<li>忘记密码了，
					<a href="#">短信联系管理员</a>。</li>
				<li>请妥善保存好自己的密码，不要随意透露。</li>
				<li>在发生资金变动的流程环节，会根据您的设置要求您输入交易密码，使您的账户资产更加安全。</li>
			</ul>
		</div>
		<br>
		<div class="remind">
			<b>联系客服人工处理 <a href="http://pay.cang.com/myhome/msg/msgWrite.aspx?name=Jerry" target="_blank">点击发站内信给Jerry</a></b><br> 您可以通过提供相关身份信息，申请客服人工找回。
			<br> 1 填写账户信息核实身份；<br> 2 客服人工审核2个工作日；<br> 3 审核通过，成功修改。<br>
			<br>
		</div>
		<br>
		
	</div>
</template>

<script>
	import '~/assets/css/jystyle.css'
	export default {
		data() {
			//密码表单验证
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
				},
				rules: {
					pass: [{
						validator: validatePass,
						trigger: 'blur'
					}],
					checkPass: [{
						validator: validatePass2,
						trigger: 'blur'
					}]
				}
			};
		},
		methods: {
			submitForm(formName) {

			}
		}
	}
</script>

<style>

</style>