<!-- 地摊导入begin -->
<template id="ImportProduct">
	<form method="post" action="/" id="form1">

		<div id="ImportProduct">

			<table class="sales-list">
				<tr>
					<th class="cols1"><input type="submit" name="btnCheckItem" value="反选" id="btnCheckItem" /></th>
					<th class="cols2">状态</th>
					<th class="cols3">编号</th>
					<th class="cols4">标题</th>
					<th class="cols5">价格</th>
					<th class="cols6">类别</th>
					<th class="cols7">上传时间</th>
				</tr>

				<tr v-for="msg in list" :key="msg.index">
					<td class="cols1"><input id="rptList_checkItem_0" type="checkbox" name="rptList$ctl00$checkItem" /></td>
					<td class="cols2"><span id="rptList_lbState_0" style="color:Red;"></span></td>
					<td class="cols3"><span id="rptList_lbID_0">{{msg.number}}</span></td>
					<td class="cols4">
						<a href="http://www.cang.com/trade/show-19565354-2.html" target="_blank">{{msg.title}}</a>
					</td>
					<td class="cols5">{{msg.price}}</td>
					<td class="cols6">{{msg.type}}</td>
					<td class="cols7">{{msg.time}}</td>
				</tr>

			</table>
			<div class="page">

				<!-- AspNetPager V7.2 for VS2005 & VS2008  Copyright:2003-2008 Webdiyer (www.webdiyer.com) -->
				<!--记录总数只有一页，AspNetPager已自动隐藏，若需在只有一页数据时显示AspNetPager，请将AlwaysShow属性值设为true！-->
				<!-- AspNetPager V7.2 for VS2005 & VS2008 End -->

				<div class="inOperation">
					<select name="DDLInType" id="DDLInType">
						<option value="0">导入类型...</option>
						<option value="1">古玩店铺</option>
						<option value="2">书画店铺</option>
						<option value="3">古玩和书画店铺</option>

					</select>
					<input type="submit" name="btnImport" value="导入" id="btnImport" />
				</div>
				<div class="clear"></div>
			</div>

		</div>
	</form>

</template>

<script>
	import '~/assets/css/shop.css'
	import importApi from '~/api/commodity'
	export default {
		data() {
			return {
				list: []
			}
		},
		created: function() {
			var self = this;
			importApi.leading().then(function(res) {
				self.list = res.data.list
			})
		}
	}
</script>

<style>

</style>