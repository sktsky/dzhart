<!-- 别人报价 -->
<template id="AuctionProduct_M4">
	<div class="pai_cz_box">
		<div class="pai_pt_box" style="display:none;">
			<div class="pai_pt_pages">
				<div class="p_input_html">
					第<input class="p_input_page" value="1" data="1" type="text">页
					<input class="p_input_go" value="GO" onclick="gopage(this,2)" type="button">
				</div>
				<a class="nextpage " href="javascript:void(0);">下一页</a>
				<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
				<div class="p_info_html">只读取30天之内结拍的拍品报价信息 第<span>1</span>页</div>
			</div>
		</div>

		<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
			<tbody>
				<tr class="bg">
					<th style="width:180px;background-color:#FFF;">藏友</th>
					<th style="background-color:#FFF;">报价内容/报价价格</th>
					<th style="width:200px;background-color:#FFF;">报价时间</th>
				</tr>
				<tr v-for="msg in peo" :key="msg.index">

					<td align="center" valign="middle" bgcolor="#FFFFFF">
						{{msg.people}}
					</td>
					<td class="pai_td_con" align="center" valign="middle" bgcolor="#FFFFFF">
						<p>
							<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.content}}</a><br/> 价格：
							<span class="colf0">{{msg.pice}}</span><br />
						</p>
					</td>
					<td class="pai_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
						{{msg.time}}
					</td>

				</tr>
			</tbody>
		</table>

		<div class="pai_pt_box" style="display:none;">
			<div class="pai_pt_pages">
				<div class="p_input_html">
					第<input class="p_input_page" value="1" data="1" type="text">页
					<input class="p_input_go" value="GO" onclick="gopage(this,2)" type="button">
				</div>
				<a class="nextpage " href="javascript:void(0);">下一页</a>
				<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
				<div class="p_info_html">只读取30天之内结拍的拍品报价信息 第<span>1</span>页</div>
			</div>
		</div>
	</div>
</template>

<script>
	import '~/assets/css/paimai.css'
	import otherApi from '~/api/auctionproduct'
	export default {
		data() {
			return {
				peo: []
			}
		},
		created: function() {
			var self = this;
			otherApi.Others().then(function(res) {
				self.peo = res.data.list
			})
		}
	}
</script>

<style>

</style>