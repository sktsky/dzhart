<!-- 我的收藏 -->
<template id="AuctionProduct_M2">
	<div class="pai_cz_box">

		<div class="pai_pt_box" style="display:none;">
			<div class="pai_pt_pages">
				<div class="p_input_html">
					第<input class="p_input_page" value="1" data="1" type="text">页
					<input class="p_input_go" value="GO" onclick="gopage(this,1)" type="button">
				</div>
				<a class="nextpage " href="javascript:void(0);">下一页</a>
				<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
				<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
			</div>
		</div>

		<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
			<tbody>
				<tr class="bg">
					<th style="width:50px;background-color:#FFF;">选择</th>
					<th style="width:140px;background-color:#FFF;">图片</th>
					<th style="background-color:#FFF;">拍品信息</th>
					<th style="width:160px;background-color:#FFF;">收藏时间</th>
					<th style="width:140px;background-color:#FFF;">操作</th>
				</tr>
				<tr v-for="msg in auction" :key="msg.index">
					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<input name="HidSGID" type="hidden" value="" data="974814" />
						<div class="pai_img Checkbox"></div>
					</td>
					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<a href="http://www.cang.com/auction/974814.html" target="_blank"><img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
					</td>
					<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
						<p>
							<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.name}}</a><br/> 编 号：{{msg.number}}类 别：<span class="colf0">{{msg.type}}</span><br />
						</p>
					</td>
					<td class="pai_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						{{msg.time}}
					</td>
					<td class="pai_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
						<p>
							<a href='AuctionProduct_M.aspx?prodid=974814' class='blue'>{{msg.operation1}}</a><br/>
						</p>
					</td>
				</tr>
			</tbody>
		</table>

		<div class="pai_pt_box" style="display:none;">
			<div class="pai_pt_pages">
				<div class="p_input_html">
					第<input class="p_input_page" value="1" data="1" type="text">页
					<input class="p_input_go" value="GO" onclick="gopage(this,1)" type="button">
				</div>
				<a class="nextpage " href="javascript:void(0);">下一页</a>
				<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
				<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
			</div>
		</div>
	</div>
</template>

<script>
	import '~/assets/css/paimai.css'
	import collectionApi from '~/api/auctionproduct'
	export default {
		data() {
			return {
				auction: []
			}
		},
		created: function() {
			var self = this;
			collectionApi.Mycollection().then(function(res) {
				self.auction = res.data.auctionlist
			})
		}
	}
</script>

<style>

</style>