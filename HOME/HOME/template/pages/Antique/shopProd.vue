	<template id="shopProd_Comment">
			<div class="mright">
                <div class="shop_menu">
                    <nuxt-link to="/Antique/shopProd_Comment/shopProd_Comment1" class="shop_m_i"  style="width:120px;">
                        <span class="shop_img shop_m_img shop_pl_goods_s"></span>
                        <span class="shop_m_name">我的商品评论</span>
                    </nuxt-link>
                    
                    <nuxt-link to="/Antique/shopProd_Comment/shopProd_Comment2" class="shop_m_i" >
                        <span class="shop_img shop_m_img shop_sc_goods"></span>
                        <span class="shop_m_name">商品收藏</span>
                    </nuxt-link>
                    <div class="shop_m_iopen">
                        
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