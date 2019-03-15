    <!-- 网店管理 -->
	<template id="shop_list">
			<div class="mright"> 
            <div class="shop_menu">
                <nuxt-link to="/Antique/shop_list/shop_list1" class="shop_m_i" >
                    <span class="shop_img shop_m_img shop_m_slist_s"></span>
                    <span class="shop_m_name">店铺管理</span>
                </nuxt-link>
                <nuxt-link to="/Antique/shop_list/shop_list2" class="shop_m_i" >
                    <span class="shop_img shop_m_img shop_m_dec"></span>
                    <span class="shop_m_name">店铺装修</span>
                </nuxt-link>
                <nuxt-link to="/Antique/shop_list/shop_list3" class="shop_m_i" >
                    <span class="shop_img shop_m_img shop_m_top"></span>
                    <span class="shop_m_name">店铺置顶</span>
                </nuxt-link>
                <nuxt-link to="/Antique/shop_list/shop_list4" class="shop_m_i" >
                    <span class="shop_img shop_m_img shop_m_ggao"></span>
                    <span class="shop_m_name">店铺公告管理</span>
                </nuxt-link>
                <nuxt-link to="/Antique/shop_list/shop_list5" class="shop_m_i">
                    <span class="shop_img shop_m_img shop_m_fp"></span>
                    <span class="shop_m_name">店铺发票</span>
                </nuxt-link>
                <nuxt-link to="/Antique/shop_list/shop_list6" class="shop_m_i">
                    <span class="shop_img shop_m_img shop_m_rep"></span>
                    <span class="shop_m_name">店铺信息修改</span>
                </nuxt-link>
                <div class="shop_m_iso" style="line-height:50px;">
                  <a class="shop_open_cl" href="http://www.cang.com/shop/apply.aspx" target="_blank">申请古玩店铺</a>
                  <a class="shop_open_cl" href="http://shuhua.cang.com/register" target="_blank">申请书画店铺</a>
                </div>
            </div>
			<nuxt-child/>
        </div>
	</template>	

<script>
	import '~/assets/css/shop.css'
	export default{
		
	}
</script>

<style>
</style>