<!-- 提现记录 -->
<template id="paylog2">
	<div>
		<table class="SaleInfoTable" style="text-align:center; margin-top:20px; clear:both;">
			<tbody>
				<tr>
					<td style="width:100px;">行号</td>
					<td style="width:200px;">提款姓名</td>
					<td style="width:100px;">金额</td>
					<td style="width:150px;">申请时间</td>
					<td style="width:100px;">状态</td>
				</tr>
			</tbody>
			<tbody v-for="msg in cashlist" :key="msg.index">
				<tr>
					<td style="width:200px;">{{msg.cnum}}</td>
					<td>{{msg.name}}</td>
					<td>{{msg.money}}</td>
					<td style="width:230px;">{{msg.time}}</td>
					<td>{{msg.type.fail}}</td>
				</tr>
			</tbody>
		</table>
		<div class="page" style="margin-right:40px;">
		</div>
	</div>
</template>

<script>
	import '~/assets/css/Custom.css'
	import { getData } from '~/plugins/axios.js'
	export default {
		data() {
			return {
				cashlist: []
			};
		},
		created: function() {
			var self = this;
			getData('mock/5bfbab3a95f7220381b70926/cash', 'get').then(function(res) {

				self.cashlist = res.data.cashlist

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