<!-- 我申请的退款 -->
<template id="Refund_list2">
	<div>
		<table class="SaleInfoTable" style="text-align: center; margin-top: 20px; clear: both;">
			<tbody>
				<tr>
					<td style="width: 60px;">退款编号</td>
					<td style="width: 60px;">订单编号</td>
					<td style="width: 200px;">藏品名称</td>
					<td style="width: 80px;">买家</td>
					<td style="width: 60px;">交易金额</td>
					<td style="width: 60px;">退款金额</td>
					<td style="width: 80px;">申请时间</td>
					<td style="width: 100px;">退款状态</td>
					<td style="width: 60px;">操作</td>
				</tr>
			</tbody>
			<tbody v-for="msg in applylist" :key="msg.index">
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
					<td>{{msg.buyer}}</td>
					<td style="color:#e4393c;">{{msg.money}}</td>
					<td style="color:#e4393c;">{{msg.money2}}</td>
					<td style="width: 100px;">
						{{msg.time}}
					</td>
					<td>{{msg.state2}}</td>
					<td class="LinkABlue" style="width: 110px;">
						<div>
							<input type="submit" name="repList$ctl01$btnClose" value="删除" onclick="return confirm('您确认关闭此订单，不买了，建议联系一下卖家？');" id="repList_btnClose_0" class="sold-list-btn-2">
						</div>
					</td>
				</tr>
			</tbody>
		</table>

		<div class="page" style="margin-right: 40px;">

			<!-- AspNetPager V7.2 for VS2005 & VS2008  Copyright:2003-2008 Webdiyer (www.webdiyer.com) -->
			<!--记录总数只有一页，AspNetPager已自动隐藏，若需在只有一页数据时显示AspNetPager，请将AlwaysShow属性值设为true！-->
			<!-- AspNetPager V7.2 for VS2005 & VS2008 End -->

		</div>
	</div>
</template>
<!-- 我申请的退款end -->

<script>
	import '~/assets/css/Custom.css'
	import { getData } from '~/plugins/axios.js'
	export default {
		data() {
			return {
				applylist: []
			};
		},
		created: function() {
			var self = this;
			getData('mock/5bfa74024728c752b654dac3/refund/apply', 'get').then(function(res) {

				self.applylist = res.data.applylist

			}, function() {
				console.log('请求失败')
			})

		}
	}
</script>

<style>

</style>