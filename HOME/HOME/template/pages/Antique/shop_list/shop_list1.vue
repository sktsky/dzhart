<!-- 店铺管理  -->
<template id="shop_list1">
	<div class="shop_cz_box">
		<div id="d_shop">您可以点此
			<a href="http://www.cang.com/shop/apply.asp" target="_blank"><b>申请古玩城店铺!</b></a>
			<a href="http://shuhua.cang.com/register" target="_blank"><b>申请书画城店铺!</b></a>
		</div>

		<table class="shop_tbl" width="940" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
			<tbody>
				<tr>
					<th class="shop_th" style="width:50px;background-color:#FFF;">编号</th>
					<th class="shop_th" style="background-color:#FFF;">店铺名称</th>
					<th class="shop_th" style="width:100px;background-color:#FFF;">店长名</th>
					<th class="shop_th" style="width:80px;background-color:#FFF;">申请日期</th>
					<th class="shop_th" style="width:80px;background-color:#FFF;">开放时间</th>
					<th class="shop_th" style="width:80px;background-color:#FFF;">类型</th>
					<th class="shop_th" style="width:120px;background-color:#FFF;">状态</th>
					<th class="shop_th" style="width:170px;background-color:#FFF;">操作</th>
				</tr>
				<tr v-for="msg in shoplist" :key="msg.index">
					<td style="background-color:#FFF;">{{msg.id}}</td>
					<td style="background-color:#FFF;">{{msg.name}}</td>
					<td style="background-color:#FFF;">{{msg.shopname}}</td>
					<td style="background-color:#FFF;">{{msg.time}}</td>
					<td style="background-color:#FFF;">{{msg.opentime}}</td>
					<td style="background-color:#FFF;">{{msg.type}}</td>
					<td style="background-color:#FFF;">{{msg.state}}</td>
					<td style="background-color:#FFF;">{{msg.operation}}</td>
				</tr>
			</tbody>
		</table>
	</div>
</template>

<script>
	import '~/assets/css/shop.css'
	import shopApi from '~/api/shoplist'
	export default {
		data() {
			return {
				shoplist: []
			}
		},
		created: function() {
			var self = this;
			shopApi.shoplist().then(function(res) {
				self.shoplist = res.data.shoplist
			}, function() {
				console.log('请求失败')
			})
		}
	}
</script>

<style>

</style>