	<!-- 信誉评价 -->
	<template id="pingjia_list">
		<div class="mright pay_in Grey PayAccount">
               <div class="menu">
                   <nuxt-link to="/Trade/pingjia_list/pingjia_list1" class="menu_n "><span>我的买家信誉</span></nuxt-link>
                   <nuxt-link to="/Trade/pingjia_list/pingjia_list2" class="menu_n "><span>我的卖家信誉</span></nuxt-link>
                   <nuxt-link to="/Trade/pingjia_list/pingjia_list3" class="menu_n "><span>店铺评价</span></nuxt-link>
                   <nuxt-link to="/Trade/pingjia_list/pingjia_list4" class="menu_n "><span>我的评价</span></nuxt-link>
                   <div class="menu_fill4" style="height:53px;"></div><div class="clearboth"></div>
               </div>
				<nuxt-child/>
               

              
               <div class="page" style="margin-right:40px;">
                   
               </div>  
           </div>
	</template>

<script>
	import '~/assets/css/Custom.css'
	export default{
		
	}
</script>

<style>
</style>