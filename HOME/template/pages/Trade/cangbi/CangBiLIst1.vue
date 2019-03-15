<!-- 藏币收支 -->
<template id="CangBiLIst1">
	<div>
		<table class="SaleInfoTable" style="margin:20px 0 0px 20px; text-align:center;">
			<tbody>
				<tr>
					<td style="width:80px;">流水号</td>
					<td style="width:150px;">日期</td>
					<td style="width:350px;">收支来源</td>
					<td style="width:80px;">收入藏币</td>
					<td style="width:80px;">支出藏币</td>
					<td style="width:100px;">藏币余额</td>
				</tr>
			</tbody>
			<tbody v-for="msg in cangbilist" :key="msg.index">
				<tr>
					<td>{{msg.cnum}}</td>
					<td>{{msg.time}}</td>
					<td>{{msg.budget}}</td>
					<td>{{msg.income}}</td>
					<td>{{msg.expenditure}}</td>
					<td>{{msg.balance}}</td>
				</tr>
			</tbody>
		</table>
		<div class="page" style="margin-right:20px;">

		</div>
	</div>
</template>

<script>
	import '~/assets/css/Custom.css'
	import { getData } from '~/plugins/axios.js'
	export default {
		data() {
			return {
				cangbilist: []
			};
		},
		created: function() {
			var self = this;
			//获取藏币收支请求
			getData('mock/5bfcdf487b0f173d0a13af27/cangbi/cangbi', 'get').then(function(res) {

				self.cangbilist = res.data.cangbilist

			}, function() {
				console.log('请求失败')
			})

		}
	}
</script>

<style>

</style>