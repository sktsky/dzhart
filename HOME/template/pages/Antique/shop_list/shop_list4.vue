<!-- 店铺公告管理 -->
<template id="shop_list4">
	<div id="shop_cz_box" class="shop_cz_box">

		<div style="margin-bottom:10px; width:100%; overflow:hidden;">
			<a style="display:inline;color:White;height:26px;line-height:26px;text-align:center;background-color:#6CA33B;float:left;font-weight:bold;font-size:14px;padding:0px 8px;-moz-border-radius:3px;-webkit-border-radius:3px;border-radius:3px;cursor:pointer;" href="http://pay.cang.com/myhome/shop/shopGongGao_M.aspx">添加公告</a>
		</div>
		<div class="shop_pt_box" style="display:none;">
			<a style="display:inline;color:White;height:26px;line-height:26px;text-align:center;background-color:#6CA33B;float:left;font-weight:bold;font-size:14px;padding:0px 8px;-moz-border-radius:3px;-webkit-border-radius:3px;border-radius:3px;cursor:pointer;" href="http://pay.cang.com/myhome/shop/shopGongGao_M.aspx">添加公告</a>
			<div class="shop_pt_pages">
				<div class="p_input_html">
					第<input class="p_input_page" type="text" value="1" data="1">页
					<input class="p_input_go" type="button" value="GO" onclick="gopage(&#39;shopGongGao_List.aspx&#39;,this,0)">
				</div>
				<a class="nextpage " href="javascript:void(0);">下一页</a>
				<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
				<div class="p_info_html" style="">
					<span>1</span>/0
				</div>
			</div>
		</div>

		<table id="table" width="940" cellpadding="0" cellspacing="1" bgcolor="#e5e5e5" class="shop_tblcom">
			<tbody>
				<tr>
					<th bgcolor="#FFFFFF">标题信息/浏览量</th>
					<th bgcolor="#FFFFFF" width="200">日期</th>
					<th bgcolor="#FFFFFF" width="60">状态</th>
					<th bgcolor="#FFFFFF" width="80">类型</th>
				</tr>

			</tbody>
		</table>

		<div class="shop_pt_box" style="display:none;">
			<div class="shop_pt_pages">
				<div class="p_input_html">
					第<input class="p_input_page" type="text" value="1" data="1">页
					<input class="p_input_go" type="button" value="GO" onclick="gopage(&#39;shopGongGao_List.aspx&#39;,this,0)">
				</div>
				<a class="nextpage " href="javascript:void(0);">下一页</a>
				<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
				<div class="p_info_html">
					<span>1</span>/0
				</div>
			</div>
		</div>

	</div>
</template>

<script>
	import '~/assets/css/shop.css'
	export default{
		
	}
</script>

<style>

</style>