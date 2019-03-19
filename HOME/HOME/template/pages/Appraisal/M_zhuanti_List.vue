<!-- 私人博物馆 -->
<template id="M_zhuanti_List">
	<div class="mright">
		<div class="museum_menu">
			<div class="museum_mymuseum_n">
				<nuxt-link to="/Appraisal/M_zhuanti_List/M_zhuanti_List1" class="museum_menu_ico museum_img museum_m_my_y"></nuxt-link>
				<nuxt-link to="/Appraisal/M_zhuanti_List/M_zhuanti_List1" class="museum_titli_n">我的博物馆</nuxt-link>
			</div>
			<div class="museum_mymuseum_n">
				<nuxt-link to="/Appraisal/M_zhuanti_List/M_zhuanti_List2" class="museum_menu_ico museum_img museum_m_cr_n"></nuxt-link>
				<nuxt-link to="/Appraisal/M_zhuanti_List/M_zhuanti_List2" class="museum_titli_n">创建博物馆</nuxt-link>
			</div>
			<div class="museum_mymuseum_n">
				<nuxt-link to="/Appraisal/M_zhuanti_List/M_zhuanti_List3" class="museum_menu_ico museum_img museum_m_all_n"></nuxt-link>
				<nuxt-link to="/Appraisal/M_zhuanti_List/M_zhuanti_List3" class="museum_titli_n">所有博物馆</nuxt-link>
			</div>
			<div class="museum_mymuseum_n">
				<nuxt-link to="/Appraisal/M_zhuanti_List/M_zhuanti_List4" class="museum_menu_ico museum_img museum_m_ac_n"></nuxt-link>
				<nuxt-link to="/Appraisal/M_zhuanti_List/M_zhuanti_List4" class="museum_titli_n">活动专区</nuxt-link>
			</div>
			<div class="menu_fill4" style="height:53px;"></div>
			<div class="clearboth"></div>
		</div>
		<nuxt-child/>
		<div class="clearboth"></div>
	</div>
</template>

<script>
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