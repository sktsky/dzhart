<!-- 我收到的投诉-->
<template id="punish_list2">
	<div>
		<table class="SaleInfoTable" style="text-align:center; margin-top:20px; clear:both;">
			<tbody>
				<tr style="text-align:center;">
					<td style="width:150px;">投诉编号</td>
					<td style="width:150px;">订单编号</td>
					<td style="width:200px;">投诉人</td>
					<td style="width:150px;">投诉时间</td>
					<td style="width:200px;">操作</td>
				</tr>
			</tbody>
			<tbody v-for="msg in complaintlist" :key="msg.index">
				<tr align="center">
					<td>
						<div class="prodname LinkABlue mofter">
							{{msg.id}}
						</div>
					</td>
					<td class="SaleUser LinkABlue">
						{{msg.cnum}}
					</td>
					<td style="width: 30px; font-weight: 700;">{{msg.name}}</td>
					<td style="width: 100px;">
						{{msg.time}}
					</td>
					<td class="LinkABlue" style="width: 110px;">
						<div>
							<input type="submit" name="repList$ctl01$btnClose" value="删除" onclick="return confirm('您确认关闭此订单，不买了，建议联系一下卖家？');" id="repList_btnClose_0" class="sold-list-btn-2">
						</div>
					</td>
				</tr>
			</tbody>
		</table>
		<div class="page">

			<!-- AspNetPager V7.2 for VS2005 & VS2008  Copyright:2003-2008 Webdiyer (www.webdiyer.com) -->
			<!--记录总数只有一页，AspNetPager已自动隐藏，若需在只有一页数据时显示AspNetPager，请将AlwaysShow属性值设为true！-->
			<!-- AspNetPager V7.2 for VS2005 & VS2008 End -->

		</div>
	</div>
</template>

<script>
	import '~/assets/css/Custom.css'
	import { getData } from '~/plugins/axios.js'
	export default {
		data() {
			return {
				complaintlist: []
			};
		},
		created: function() {
			var self = this;
			getData('mock/5bf7cc8f2caeed673a1af57b/Trade_Complaint/Trade_Complaint#complaintlist', 'get').then(function(res) {

				self.complaintlist = res.data.complaintlist

			}, function() {
				console.log('请求失败')
			})

		}
	}
</script>

<style>

</style>