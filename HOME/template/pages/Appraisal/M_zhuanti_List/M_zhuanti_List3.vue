<!-- 所以博物馆 -->
<template id="M_zhuanti_List3">
	<div class="all_museum">

		<table class="info_table">
			<tbody>
				<tr class="tcent">
					<td class="wi50">序号</td>
					<td class="wi435">馆名</td>
					<td class="wi120">创始人</td>
					<td class="wi120">添加时间</td>
					<td class="wi180">操作</td>
				</tr>

				<tr v-for="msg in mylist1" :key="msg.index">
					<td class="tcent">{{msg.id}}</td>
					<td>
						<a href="http://news.cang.com/zhuanti/zhuanti_6667.html" class="col_orange" target="_blank" title="天佶阁博物馆">{{msg.name}}</a>
					</td>
					<td class="tcent">
						<a href="http://www.cang.com/personal/index.asp?yourName=%CC%ED%D9%A5%B8%F3" target="_blank">{{msg.people}}</a>
					</td>
					<td class="tcent">{{msg.time}}</td>
					<td class="tcent col_green">
						<a href="http://pay.cang.com/myhome/zhuanti/M_zhuanti_List.aspx?id=6667&amp;sortid=5">{{msg.operation}}</a>
					</td>
				</tr>

			</tbody>
		</table>

		<div class="Pnl">
			<!-- AspNetPager V7.2 for VS2005 & VS2008  Copyright:2003-2008 Webdiyer (www.webdiyer.com) -->
			<div id="AspNetPager1" class="pages">
				<a disabled="disabled" style="margin-right:5px;">首页</a>
				<a disabled="disabled" style="margin-right:5px;">上一页</a><span class="cpb" style="margin-right:5px;">1</span>
				<a href="http://pay.cang.com/myhome/zhuanti/M_zhuanti_List.aspx?page=2" style="margin-right:5px;">2</a>
				<a href="http://pay.cang.com/myhome/zhuanti/M_zhuanti_List.aspx?page=3" style="margin-right:5px;">3</a>
				<a href="http://pay.cang.com/myhome/zhuanti/M_zhuanti_List.aspx?page=4" style="margin-right:5px;">4</a>
				<a href="http://pay.cang.com/myhome/zhuanti/M_zhuanti_List.aspx?page=5" style="margin-right:5px;">5</a>
				<a href="http://pay.cang.com/myhome/zhuanti/M_zhuanti_List.aspx?page=6" style="margin-right:5px;">6</a>
				<a href="http://pay.cang.com/myhome/zhuanti/M_zhuanti_List.aspx?page=7" style="margin-right:5px;">7</a>
				<a href="http://pay.cang.com/myhome/zhuanti/M_zhuanti_List.aspx?page=8" style="margin-right:5px;">8</a>
				<a href="http://pay.cang.com/myhome/zhuanti/M_zhuanti_List.aspx?page=9" style="margin-right:5px;">9</a>
				<a href="http://pay.cang.com/myhome/zhuanti/M_zhuanti_List.aspx?page=10" style="margin-right:5px;">10</a>
				<a href="http://pay.cang.com/myhome/zhuanti/M_zhuanti_List.aspx?page=11" style="margin-right:5px;">...</a>
				<a href="http://pay.cang.com/myhome/zhuanti/M_zhuanti_List.aspx?page=2" style="margin-right:5px;">下一页</a>
				<a href="http://pay.cang.com/myhome/zhuanti/M_zhuanti_List.aspx?page=211" style="margin-right:5px;">尾页</a>&nbsp;&nbsp;<input value="1" name="AspNetPager1_input" id="AspNetPager1_input" onkeydown="ANP_keydown(event,'AspNetPager1_btn');" style="width:30px;" type="text"><input value="go" name="AspNetPager1" id="AspNetPager1_btn" onclick="if(ANP_checkInput('AspNetPager1_input',211)){ANP_goToPage(document.getElementById('AspNetPager1_input'));};return false;" type="button">
			</div>
			<!-- AspNetPager V7.2 for VS2005 & VS2008 End -->

		</div>

	</div>
</template>

<script>

	import { getData } from '~/plugins/axios.js'
	export default {
		data() {
			return {
				mylist1: []
			}
		},
		created: function() {
			var self = this;
			getData('mock/5c02305110c9227e21fe7944/zhuanti/all').then(function(res) {

				self.mylist1 = res.data.mylist
			})
		}
	}
</script>

<style>
	.museum_mymuseum_n {
		width: 103px;
		height: 53px;
		float: left;
		border-bottom: 1px solid #d0d0d0;
		border-right: 1px solid #d0d0d0;
	}
	
	.bodywrap a {
		color: #666;
		text-decoration: none;
	}
	
	.museum_m_my_y {
		background-position: 0px 0px;
	}
	
	.museum_menu_ico {
		display: block;
		width: 17px;
		height: 17px;
		margin: 8px auto;
	}
	
	.museum_titli_n {
		display: block;
		width: 100%;
		margin: 5px auto;
		text-align: center;
	}
	.tcent {
		text-align: center;
	}
	
	.wi50 {
		width: 50px;
	}
	
	.wi435 {
		width: 435px;
	}
	
	.wi120 {
		width: 120px;
	}
	
	.wi180 {
		width: 180px;
	}		
	.all_museum {
		width: 942px;
		margin: 15px;
	}
	
	.all_museum .info_table {
		border-collapse: collapse;
		border: none;
		color: #646464;
	}
	
	.all_museum .info_table td {
		border: solid #e5e5e5 1px;
		height: 40px;
		vertical-align: middle;
		padding-left: 5px;
	}
	
	.museum_titli_n {
		display: block;
		width: 100%;
		margin: 5px auto;
		text-align: center;
	}
	
	.museum_menu_ico {
		display: block;
		width: 17px;
		height: 17px;
		margin: 8px auto;
	}
	
	.all_museum .info_table a {
		color: #3065cf;
	}
	
	.Pnl {
		width: 96%;
		margin: 5px auto 0px auto;
		padding-top: 5px;
		zoom: 1;
		overflow: hidden;
	}
	
	.clearboth {
		clear: both;
		display: block;
		height: 0;
		font-size: 0;
		overflow: hidden;
	}
</style>