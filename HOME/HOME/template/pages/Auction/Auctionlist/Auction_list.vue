<!-- 我的专场 -->
<template>
	<div class="pai_cz_box">
		<input id="zpage" value="0" type="hidden">
		<div class="pai_pt_box" style="display:none;">
			<div class="pai_pt_pages">
				<div class="p_input_html">
					第<input class="p_input_page" value="1" data="1" type="text">页
					<input class="p_input_go" value="GO" onclick="gopage(this,5)" type="button">
				</div>
				<a class="nextpage " href="javascript:void(0);">下一页</a>
				<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
				<div class="p_info_html">共<span>0</span>场 <span>1</span>/0</div>
			</div>
		</div>

		<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
			<tbody>
				<tr class="bg">
					<th style="width:50px;background-color:#FFF;">场次</th>
					<th style="background-color:#FFF;">专场名称</th>
					<th style="width:60px;background-color:#FFF;">拍品总数</th>
					<th style="width:160px;background-color:#FFF;">结拍时间</th>
					<th style="width:80px;background-color:#FFF;">状态</th>
					<th style="width:60px;background-color:#FFF;">成交率(%)</th>
					<th style="width:60px;background-color:#FFF;">退款率(%)</th>
					<th style="width:110px;background-color:#FFF;">操作</th>
				</tr>
				<tr v-for="msg in aulist" :key="msg.index">

					<td align="center" valign="middle" bgcolor="#FFFFFF">
						{{msg.id}}
					</td>
					<td class="pai_td_con" align="center" valign="middle" bgcolor="#FFFFFF">
						{{msg.name}}
					</td>
					<td class="pai_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
						{{msg.sum}}
					</td>
					<td align="center" valign="middle" bgcolor="#FFFFFF">
						{{msg.pattime}}
					</td>
					<td class="pai_td_con" align="center" valign="middle" bgcolor="#FFFFFF">
						{{msg.state}}
					</td>
					<td class="pai_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
						{{msg.deal}}
					</td>
					<td align="center" valign="middle" bgcolor="#FFFFFF">
						{{msg.refund}}
					</td>
					<td class="pai_td_con" align="center" valign="middle" bgcolor="#FFFFFF">
						<span class="colf0">{{msg.operation}}</span>
					</td>
				</tr>
			</tbody>
		</table>

		<div class="pai_pt_box" style="display:none;">
			<div class="pai_pt_pages">
				<div class="p_input_html">
					第<input class="p_input_page" value="1" data="1" type="text">页
					<input class="p_input_go" value="GO" onclick="gopage(this,5)" type="button">
				</div>
				<a class="nextpage " href="javascript:void(0);">下一页</a>
				<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
				<div class="p_info_html">共<span>0</span>场 <span>1</span>/0</div>
			</div>
		</div>
	</div>
</template>

<script>
	import '~/assets/css/paimai.css'
	import listApi from '~/api/auctionl'
	export default {
		data() {
			return {
				aulist: []
			}
		},
		created: function() {
			var self = this;
			listApi.Special().then(function(res) {
				self.aulist = res.data.list
			})
		}
	}
</script>

<style>

</style>