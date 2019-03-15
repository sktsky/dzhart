<!-- 充值记录 -->
<template id="paylog3">
	<div>
		<table class="SaleInfoTable" style="text-align:center;margin-top:20px; clear:both;">
			<tbody>
				<tr style="text-align:center;">
					<td style="width:140px;">行号</td>
					<td style="width:140px;">汇款银行</td>
					<td style="width:140px;">汇款金额</td>
					<td style="width:140px;">汇款时间</td>
					<td style="width:140px;">提交时间</td>
					<td style="width:140px;">处理状态</td>
				</tr>

			</tbody>
			<tbody v-for="msg in rechargelist" :key="msg.index">
				<tr>
					<td style="width:200px;">{{msg.cnum}}</td>
					<td>{{msg.bankname}}</td>
					<td>{{msg.money}}</td>
					<td style="width:115px;">{{msg.date}}</td>
					<td style="width:115px;">{{msg.time}}</td>
					<td>{{msg.type.success}}</td>
				</tr>
			</tbody>
		</table>
		<div class="page" style="margin-right:40px;">

			<!-- AspNetPager V7.2 for VS2005 & VS2008  Copyright:2003-2008 Webdiyer (www.webdiyer.com) -->
			<!--记录总数只有一页，AspNetPager已自动隐藏，若需在只有一页数据时显示AspNetPager，请将AlwaysShow属性值设为true！-->
			<!-- AspNetPager V7.2 for VS2005 & VS2008 End -->

		</div>
	</div>
</template>

<script>
	import '~/assets/css/Custom.css'
	import paylogApi from '~/api/paylog'
	export default {
		data() {
			return {
				rechargelist: []
			};
		},
		created: function() {
			var self = this;
			paylogApi.Recharge().then(function(res) {

				self.rechargelist = res.data.rechargelist

			}, function() {
				console.log('请求失败')
			})

		}
	}
</script>

<style>
  /*  点击路由切换样式begin */
 .mright .menu .router-link-active{
  		background-color: #f7f7f7;
		border-bottom: 1px solid #f7f7f7;
		display: block;
		width: 103px;
		height: 53px;
		color: #e4393c;
		line-height: 53px;
  }
 .mright .mar_menu .router-link-active{
	    border-bottom: 1px #f7f7f7 solid;
		background-color: #f7f7f7;
		color: #E4393C;
  }
 .mright .mar_menu .router-link-active .mar_m_name{
		color: #E4393C;
  }  
  .Table .tr_heads td{
		border: solid #e5e5e5 1px;
		line-height: 25px;
		text-align: center  
  }
 .mright .Table2{
		border-collapse: collapse;
		border: none;
		color: #646464;
		margin: 30px 0 0 10px; 
 }
 .mright .msg_menu .router-link-active{
		border-bottom: 1px #f7f7f7 solid;
		background-color: #f7f7f7; 
 }
  .mright .msg_menu .router-link-active .msg_m_name{
		text-decoration: none;
		color: #E4393C;
 }
 .router-link-active .msg_m_fa_s{
 		background-position: -267px -89px;
 }
 .router-link-active .msg_m_shou{
 		background-position: -267px -52px;
 }
.router-link-active .msg_m_xie{
		background-position: -267px -201px;
}
.jd_menu .router-link-active{
		border-bottom: 1px #f7f7f7 solid;
		background-color: #f7f7f7;
}
.jd_menu .router-link-active .jd_m_name{
		color: #e4393c;
}
.museum_mymuseum_n .router-link-active{
		color: #e4393c;
}
.td_menu .router-link-active{
		border-bottom: 1px #f7f7f7 solid;
		background-color: #f7f7f7;
}
.td_menu .router-link-active .td_m_name{
		color: #e4393c;
}
.shop_menu .router-link-active {
		border-bottom: 1px #f7f7f7 solid;
		background-color: #f7f7f7;
}
.shop_menu .router-link-active .shop_m_name{
		color: #e4393c;
}
.binfo_menu .router-link-active{
		border-bottom: 1px #f7f7f7 solid;
		background-color: #f7f7f7;
}
.binfo_menu .router-link-active .binfo_m_name{
		color: #e4393c;
}
.pai_menu .router-link-active{
		border-bottom: 1px #f7f7f7 solid;
		background-color: #f7f7f7;
}
.pai_menu .router-link-active .pai_m_name{
		color: #e4393c;
}
.jianl_menu .router-link-active{
		border-bottom: 1px #f7f7f7 solid;
		background-color: #f7f7f7;
}
.jianl_menu  .router-link-active .jianl_m_name{
		color: #e4393c;
}
.dis_menu .router-link-active{
		border-bottom: 1px #f7f7f7 solid;
		background-color: #f7f7f7;
}
.dis_menu .router-link-active .dis_m_name{
		color: #e4393c;
}
.pay_in .router-link-active{
		border-bottom: 1px #f7f7f7 solid;
		background-color: #f7f7f7;
		color: #e4393c;
}
/*  点击路由切换样式 end  */
</style>