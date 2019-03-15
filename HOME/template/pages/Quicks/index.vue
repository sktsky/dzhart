<!-- 快速指南 -->
<template>
	<div class="mright" id="quick">
		<div class="title1">上传藏品</div>
		<div class="quick-con1">
			<router-link to="/Estimation_M" class="list-1" target="_blank">
				<div class="list-title">
					<div class="title2">估价上传</div>
					<div class="title3"></div>
				</div>
				<div class="list-content li1">
					<span class="orange b">普通鉴定：</span>无条件<br>
					<span class="orange b">有偿鉴定：</span>藏币金额&gt;200,消耗10元和100藏币<br>
					<span class="orange b">加急鉴定：</span>15元<br>
					<span class="orange b">指定鉴定：</span>20元
				</div>
			</router-link>
			<router-link to="/trade_m" class="list-1" target="_blank">
				<div class="list-title">
					<div class="title2">地摊上传</div>
					<div class="title3">藏币余额大于100</div>
				</div>
				<div class="list-content li2" style="background:url(../assets/images/Quickbg.png) no-repeat 46px 0px;"></div>
			</router-link>
			<router-link to="/AuctionProduct_M" class="list-1" target="_blank">
				<div class="list-title">
					<div class="title2">拍卖上传</div>
					<div class="title3">藏币余额大于500，实名认证</div>
				</div>
				<div class="list-content li3">
					<span class="orange b">普通拍卖：</span>信誉值5分<br>
					<span class="orange b">午间拍卖：</span>信誉值50分，无交易纠纷，无投诉历史，押金5000元<br>
					<span class="orange b">晚间拍卖：</span>信誉值100分，无交易纠纷，无投诉历史，押金20000元<br>
				</div>
			</router-link>
			<a class="list-1" href="#">
				<div class="list-title">
					<div class="title2">开个网店</div>
					<div class="title3"></div>
				</div>
				<div class="list-content li4" style="background:url(../assets/images/Quickbg.png) no-repeat -155px 0px;"></div>
			</a>
			<div class="clear"></div>
		</div>

		<div class="title1">参加拍卖</div>
		<div class="rz">
			<router-link to="/UserCard" target="_blank" class="btnrz">实名认证</router-link>
		</div>
		<div class="quick-con2">
			<div class="fl">
				<div class="title2">普通拍卖</div>
				<div class="li5" style="background:url(../assets/images/Quickbg.png) no-repeat -320px 0px;"></div>
			</div>
			<div class="fl">
				<div class="title2">专场拍卖</div>
				<div class="li6" style="background:url(../assets/images/Quickbg.png) no-repeat -520px 0px;"></div>
			</div>
			<div class="fl">
				<div class="title2">精品拍卖</div>
				<div class="li7" style="background:url(../assets/images/Quickbg.png) no-repeat -710px 0px;"></div>
			</div>
			<div class="clear"></div>
		</div>
	</div>
</template>

<script>
	import '~/assets/css/Quick.css'
	export default {

	}	
</script>

<style>

</style>