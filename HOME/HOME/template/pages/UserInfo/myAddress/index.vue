<!-- 收货地址 -->
<template id="myAddress">
	<div class="mright">
		<div id="myAddress">
			<div class="current-item">
				<h2>地址编辑</h2>
				<div style="margin: 40px 0 0 20px;">
					<el-form ref="form" :model="form" size="medium" label-width="120px">
						<el-form-item label="联系人：">
							<el-input v-model="form.name" style="width:248px;"></el-input>
						</el-form-item>
						<el-form-item label="地址区域：">
							<el-cascader expand-trigger="hover" :options="citylist" v-model="form.selectedOptions">
							</el-cascader>
						</el-form-item>
						<el-form-item label="地址：">
							<el-input type="textarea" :rows="2" placeholder="请输入内容" v-model="form.textarea" style="width:248px;">
							</el-input>
						</el-form-item>
						<el-form-item label="邮编：">
							<el-input v-model="form.Zipcode" style="width:248px;"></el-input>
						</el-form-item>
						<el-form-item label="移动电话：">
							<el-input v-model="form.phone" style="width:248px;padding-right:20px;"></el-input><label style="color:#E4393C;">移动电话和固定电话必填一项*</label>
						</el-form-item>
						<el-form-item label="固定电话：">
							<el-input v-model="form.telephone" style="width:248px;"></el-input>
						</el-form-item>
						<el-form-item label="交易密码：">
							<el-input v-model="form.password" style="width:248px;"></el-input>
						</el-form-item>
						<el-form-item>
						<el-button type="primary" @click="onSubmit" style="margin-left:18%">保存地址</el-button>
						</el-form-item>
					</el-form>
				</div>
			</div>
			<h2>地址列表</h2>

			<table class="SaleInfoTable">
				<tbody>
					<tr>
						<th style="width:100px;">联系人</th>
						<th>所在地址</th>
						<th style="width:100px;">邮编</th>
						<th style="width:120px;">手机/电话</th>
						<th style="width:160px;">操作</th>
					</tr>
					<tr v-for="msg in address" :key="msg.index">
						<td style="text-align:center;">{{msg.name}}</td>
						<td style="text-align:center;">{{msg.address}}</td>
						<td style="text-align:center;">{{msg.Zipcode}}</td>
						<td style="text-align:center;">{{msg.phone}}</td>
						<td style="text-align:center;">{{msg.operation}}</td>
					</tr>
				</tbody>
			</table>
		</div>
	</div>
</template>

<script>
	import '~/assets/css/Custom.css'
	import '~/assets/css/UserInfo.css'
	import axios from 'axios'
	export default {
		data() {
			return {
				citylist: [],
				address: [],
				form: {
					name: '',
					selectedOptions: '',
					textarea: '',
					Zipcode: '',
					phone: '',
					telephone: '',
					password: ''
				}
			};
		},
		created: function() {
			var self = this;
			// 获取城市地区
			axios.get('https://www.easy-mock.com/mock/5bf7cc8f2caeed673a1af57b/Trade_Complaint/test').then(function(res) {

				self.citylist = res.data.citylist

			}, function() {
				console.log('请求失败')
			})
			//获取地址列表
			axios.get('https://www.easy-mock.com/mock/5c206fc50fd1077df5e6e924/s/adress').then(function(res) {

				self.address = res.data.list

			}, function() {
				console.log('请求失败')
			})
		},
		onSubmit() {
			console.log('submit!');
		}
	}
</script>

<style>

</style>