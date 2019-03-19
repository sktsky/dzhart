    <!-- 拍品上传 -->
	<template id="AuctionProduct_M">
			<div class="mright"> 
            <div class="pai_menu">
                <nuxt-link to="/Auction/AuctionProduct_M/AuctionProduct_M1" class="pai_m_i" >
                    <span class="pai_img pai_m_img pai_m_slist"></span>
                    <span class="pai_m_name">我的拍品</span>
                </nuxt-link>
                <nuxt-link to="/Auction/AuctionProduct_M/AuctionProduct_M2" class="pai_m_i" >
                    <span class="pai_img pai_m_img pai_m_sc_s"></span>
                    <span class="pai_m_name">我的收藏</span>
                </nuxt-link>
                <nuxt-link to="/Auction/AuctionProduct_M/AuctionProduct_M3" class="pai_m_i" >
                    <span class="pai_img pai_m_img pai_m_mb"></span>
                    <span class="pai_m_name">我的报价</span>
                </nuxt-link>
                <nuxt-link to="/Auction/AuctionProduct_M/AuctionProduct_M4" class="pai_m_i" >
                    <span class="pai_img pai_m_img pai_m_ob"></span>
                    <span class="pai_m_name">别人报价</span>
                </nuxt-link>
                <nuxt-link to="/Auction/AuctionProduct_M/AuctionProduct_M5" class="pai_m_i" >
                    <span class="pai_img pai_m_img pai_m_dl"></span>
                    <span class="pai_m_name">我的代理价</span>
                </nuxt-link>
                <nuxt-link to="/Auction/AuctionProduct_M/AuctionProduct_M6" class="pai_m_i">
                    <span class="pai_img pai_m_img pai_m_up"></span>
                    <span class="pai_m_name">拍品上传</span>
                </nuxt-link>
            </div>
			<nuxt-child/>
        </div>
	</template>	

<script>
	import '~/assets/css/paimai.css'
	export default{
		
	}
</script>

<style>
</style>