<!-- 求购评论 -->
<template id="myBuyInfo3">
	<div class="binfo_cz_box">
		<div class="binfo_pt_box" style="display:none;">
			<div class="binfo_pt_pages">
				<div class="p_input_html">
					第<input class="p_input_page" type="text" value="1" data="1">页
					<input class="p_input_go" type="button" value="GO" onclick="gopage('myCommerceReply.aspx?keys=',this,0)">
				</div>
				<a class="nextpage " href="javascript:void(0);">下一页</a>
				<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
				<div class="p_info_html">
					<span>1</span>/0
				</div>
			</div>
		</div>
		<div id="binfo_noth_box" class="binfo_noth_box">
			提示：<br> 1、当前无任何记录；
			<br> 2、如果您想对求购信息进行评论点击
			<a href="http://www.cang.com/commerce/" target="_blank" style="font-weight:bold;color:blue;">求购信息》</a><br> 3、如果您想进行藏品求购请点击
			<a href="http://www.cang.com/commerce/add.html" target="_blank" style="font-weight:bold;color:blue;">发布求购》</a><br> 4、如果还有其它问题，请
			<a href="http://www.cang.com/contact.asp" target="_blank" style="font-weight:bold;color:blue;">联系我们》</a><br>
		</div>

		<div class="binfo_pt_box" style="display:none;">
			<div class="binfo_pt_pages">
				<div class="p_input_html">
					第<input class="p_input_page" type="text" value="1" data="1">页
					<input class="p_input_go" type="button" value="GO" onclick="gopage('myCommerceReply.aspx?keys=',this,0)">
				</div>
				<a class="nextpage " href="javascript:void(0);">下一页</a>
				<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
				<div class="p_info_html" style="">
					<span>1</span>/0
				</div>
			</div>
		</div>
	</div>
</template>

<script>
	import '~/assets/css/buyinfo.css'
	export default {

	}
</script>

<style>

</style>