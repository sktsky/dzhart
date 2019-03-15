<!--账户明细-->
<template id="paylog1">
	<div>
		<div class="box_line" style="height:50px; float:right; margin-right:7%;">
			<table style="padding:15px 0 0 20px;" cellspacing="0" cellpadding="0">
				<tbody>
					<tr>
						<td>资金流向：</td>
						<td>
							<label for="chkAll"><input id="chkAll" name="chktype" checked="checked" value="2" type="radio">全部</label>
							<label for="chkIn"><input id="chkIn" name="chktype" value="1" type="radio">收入</label>
							<label for="chkOut"><input id="chkOut" name="chktype" value="0" type="radio">支出</label> </td>

						<td><input id="btnSo" value="查询" class="small_btn" type="button"></td>

					</tr>
				</tbody>
			</table>
		</div>
		<div class="menu_fill3"></div>
		<div style="clear:both;"></div>

		<table class="SaleInfoTable" style="text-align:center; margin-top:20px; clear:both;">
			<tbody>
				<tr style="font-weight:700;">
					<td style="width:150px;">日期</td>
					<td style="width:80px;">类型</td>
					<td style="width:120px;">金额</td>
					<td style="width:380px;">摘要</td>
					<td style="width:100px;">当前余额</td>
				</tr>
			</tbody>
			<tbody v-for="msg in payloglist" :key="msg.index">
				<tr>
					<td>{{msg.time}}</td>
					<td>{{msg.type.income}}</td>
					<td>{{msg.money}}</td>
					<td>{{msg.abstract}}</td>
					<td>{{msg.current}}</td>
				</tr>
			</tbody>
		</table>

		<div class="page" style="margin-right:40px;">

		</div>
	</div>
</template>

<script>
	import '~/assets/css/Custom.css'
	import paylogApi from '~/api/paylog'
	export default {
		data() {
			return {
				payloglist: []
			};
		},
		created: function() {
			var self = this;
			paylogApi.Account().then(function(res) {

				self.payloglist = res.data.payloglist

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