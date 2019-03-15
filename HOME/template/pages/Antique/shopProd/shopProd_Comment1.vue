<!-- 我的商品评论 -->
<template id="shopProd_Comment1">
	<div id="shop_cz_box" class="shop_cz_box">

		<div class="shop_cz_tbcon">

			<table id="table" class="shop_tblcom" width="940" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
				<tbody>
					<tr>
						<th class="shop_thcom" bgcolor="#FFFFFF">内容</th>
						<th class="shop_thcom" width="150" bgcolor="#FFFFFF">评论日期</th>
					</tr>
					<tr v-for="msg in shopprod" :key="msg.index">
						<td class="shop_tdcom shop_tdcom_con">
							<p style="line-height:20px;">
								<a href="http://www.cang.com/shop/2425092.html" target="_blank">{{msg.content}}</a>
							</p>
						</td>
						<td valign="middle" bgcolor="#FFFFFF" align="center">{{msg.time}}</td>
					</tr>
				</tbody>
			</table>

			<div class="shop_pt_box" style="display:none;">
				<div class="shop_pt_pages">
					<div class="p_input_html">
						第<input class="p_input_page" value="1" data="1" type="text">页
						<input class="p_input_go" value="GO" onclick="gopage('shopProd_Comment.aspx',this,0)" type="button">
					</div>
					<a class="nextpage " href="javascript:void(0);">下一页</a>
					<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
					<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
				</div>
			</div>
		</div>
	</div>
</template>

<script>
	import '~/assets/css/shop.css'
	import shopProdApi from '~/api/commodity'
	export default {
		data() {
			return {
				shopprod: []
			}
		},
		created: function() {
			var self = this;
			shopProdApi.Comment().then(function(res) {
				self.shopprod = res.data.shopprod
			})
		}
	}
</script>

<style>

</style>