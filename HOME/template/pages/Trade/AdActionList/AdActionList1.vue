<!-- 全部报价 -->
<template id="AdActionList1">
	<div>
		<table class="Table">
			<tbody>
				<tr style="text-align:center; font-weight:700;">
					<td style="width:100px;">位置</td>
					<td style="width:400px">广告位信息</td>
					<td style="width:120px;">报价价格（藏币）</td>
					<td style="width:120px;">报价时间</td>
					<td style="width:120px;">状态/报价/操作</td>
				</tr>
			</tbody>
			<tbody v-for="msg in offerlist" :key="msg.index">
				<tr>
					<td>{{msg.position}}</td>
					<td>{{msg.evaluate}}</td>
					<td>{{msg.money}}</td>
					<td>{{msg.time}}</td>
					<td>{{msg.state}}</td>
				</tr>
			</tbody>
		</table>
		<div style="margin-right:20px;">

		</div>
		<input id="txtID" type="hidden">
		<input id="txtCurprice" type="hidden">
		<input id="txtStartprice" type="hidden">
		<input id="txtUserName" value="sktsky" type="hidden">
		<input id="txtCangbi" value="150" type="hidden">

	</div>
</template>

<script>
	import '~/assets/css/Custom.css'
	import { getData } from '~/plugins/axios.js'
	export default {
		data() {
			return {
				offerlist: []
			};
		},
		created: function() {
			var self = this;
			getData('mock/5bfcdf487b0f173d0a13af27/cangbi/offer').then(function(res) {

				self.offerlist = res.data.offerlist

			}, function() {
				console.log('请求失败')
			})

		}
	}
</script>

<style>

</style>