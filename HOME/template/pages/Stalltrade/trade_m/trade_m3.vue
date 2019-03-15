<!-- 地摊评论 -->
<template id="trade_m3">
	<div class="td_cz_box">
		<div class="td_pt_box" style="display:none;">
			<div class="td_pt_allCheck">
				<div class="td_img allCheckbox"></div>
			</div>
			<div class="td_pt_pb">屏蔽</div>
			<div class="td_pt_pages">
				<div class="p_input_html">
					第<input class="p_input_page" value="1" data="1" type="text">页
					<input class="p_input_go" value="GO" onclick="gopage('trade_comment.aspx?f_id=-1',this,0)" type="button">
				</div>
				<a class="nextpage " href="javascript:void(0);">下一页</a>
				<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
				<div class="p_info_html">
					共<span>0</span>件 <span>1</span>/0
				</div>
			</div>
		</div>

		<table class="td_tblcom" width="940" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
			<tbody>
				<tr>
					<th class="td_thcom" style="width:80px;" bgcolor="#FFFFFF">选择</th>
					<th class="td_thcom" bgcolor="#FFFFFF">评论内容</th>
					<th class="td_thcom" style="width:120px;" bgcolor="#FFFFFF">评论时间</th>
					<th class="td_thcom" style="width:80px;" bgcolor="#FFFFFF">操作</th>
				</tr>
				<tr v-for="msg in commentlist" :key="msg.index">
					<td class="td_tdcom" align="center" valign="middle" bgcolor="#FFFFFF">
						<input name="HidComID" type="hidden" value="" data="26739936" />
						<div class="td_img Checkbox"></div>
					</td>
					<td class="td_tdcom td_tdcom_con" align="left" valign="middle" bgcolor="#FFFFFF">
						<p>
							<a href="http://www.cang.com/trade/show-19354057-2.html" target="_blank">{{msg.content}}</a>
						</p>
					</td>
					<td class="td_tdcom" align="center" valign="middle" bgcolor="#FFFFFF">
						{{msg.time}}
					</td>
					<td class="td_tdcom" align="center" valign="middle" bgcolor="#FFFFFF">
						<a class='td_cz btn_chide' href='javascript:void(0);' id='chide_26739936'>{{msg.oper}}</a>
					</td>
				</tr>
			</tbody>
		</table>
		<div class="td_pt_box" style="display:none;">
			<div class="td_pt_allCheck">
				<div class="td_img allCheckbox"></div>
			</div>
			<div class="td_pt_pb">屏蔽</div>
			<div class="td_pt_pages">
				<div class="p_input_html">
					第<input class="p_input_page" value="1" data="1" type="text">页
					<input class="p_input_go" value="GO" onclick="gopage('trade_comment.aspx?f_id=-1',this,0)" type="button">
				</div>
				<a class="nextpage " href="javascript:void(0);">下一页</a>
				<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
				<div class="p_info_html" style="">
					共<span>0</span>件 <span>1</span>/0
				</div>
			</div>
		</div>
	</div>
</template>

<script>
	import '~/assets/css/trade.css'
	import { getData } from '~/plugins/axios.js'
	export default {
		data() {
			return {
				commentlist: []
			}
		},
		created: function() {
			var self = this;
			//获取地摊评论请求
			getData('mock/5c0373ed0694c411d85d83cb/tradelist/trade3', 'get').then(function(res) {
				self.commentlist = res.data.commentlist
			}, function() {
				console.log('请求失败')
			})
		}
	}
</script>

<style>

</style>