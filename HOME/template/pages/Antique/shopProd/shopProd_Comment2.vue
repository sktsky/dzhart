<!-- 商品收藏  -->
<template id="shopProd_Comment2">
	<div id="shop_cz_box" class="shop_cz_box">
		<div class="shop_pt_box" style="display:none;">
			<div class="shop_pt_allCheck" style="display:none;">
				<div class="shop_img allCheckbox"></div>
			</div>
			<div class="shop_pt_pb" style="display:none;">取消</div>
			<div class="shop_pt_pages" style="display:none;">
				<div class="p_input_html">
					第<input class="p_input_page" value="1" data="1" type="text">页
					<input class="p_input_go" value="GO" onclick="gopage('shopProd_Collect.aspx',this,0)" type="button">
				</div>
				<a class="nextpage " href="javascript:void(0);">下一页</a>
				<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
				<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
			</div>
		</div>
		<div class="shop_cz_tbcon">
			<table class="shop_cz_tbl" cellspacing="1">
				<tbody>
					<tr class="bg">
						<th>图片</th>
						<th>商品编号/名称/收藏日期</th>
						<th>操作</th>
					</tr>
					<tr class="shop_cz_tr" onmousemove="$(this).addClass('shop_cz_trsel');" onmouseout="$(this).removeClass('shop_cz_trsel');" v-for="msg in canglist" :key="msg.index">
						<td class="shop_cz_tblimg">
							<a href="http://www.cang.com/shop/1081904.html" target="_blank"><img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
						</td>
						<td>
							<div class="shop_cz_ifb">
								<a href="http://www.cang.com/shop/1081904.html" target="_blank" class="b">{{msg.name}}</a>
							</div>
							<div class="shop_cz_ifb"> 编号：
								<a href="http://www.cang.com/shop/1081904.html" target="_blank">{{msg.number}}</a>
							</div>
							<div class="shop_cz_ifb">收藏时间：{{msg.time}}</div>
						</td>
						<td cclass="shop_cz_tblcz">
							<div class='shop_cz_ifbut'>
								<a href='javascript:void(0);' onclick='goods_action(2019156,"DelCollect")' class='btn_delcollect'>{{msg.operation}}</a>
							</div>
						</td>
					</tr>
				</tbody>
			</table>

			<div class="shop_pt_box" style="display:none;">
				<div class="shop_pt_allCheck" style="display:none;">
					<div class="shop_img allCheckbox"></div>
				</div>
				<div class="shop_pt_pb" style="display:none;">取消</div>
				<div class="shop_pt_pages">
					<div class="p_input_html">
						第<input class="p_input_page" value="1" data="1" type="text">页
						<input class="p_input_go" value="GO" onclick="gopage('shopProd_Collect.aspx',this,0)" type="button">
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
	import CollectionApi from '~/api/commodity'
	export default {
		data() {
			return {
				canglist: []
			}
		},
		created: function() {
			var self = this;
			CollectionApi.Collection().then(function(res) {
				self.canglist = res.data.canglist
			})
		}
	}
</script>

<style>

</style>