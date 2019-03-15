	<!-- 发布商品begin -->
	<template>
            <div class="mright">
                <div class="shop_menu">
                    <nuxt-link class="shop_m_i" to="/Antique/Commodity/Search">
                        <span class="shop_img shop_m_img shop_m_all"></span>
                        <span class="shop_m_name">所有商品</span>
                    </nuxt-link>
                    <nuxt-link class="shop_m_i" to="/Antique/Commodity/Shangjia">
                        <span class="shop_img shop_m_img shop_sj_goods"></span>
                        <span class="shop_m_name">上架商品</span>
                    </nuxt-link>
                    <nuxt-link class="shop_m_i" to="/Antique/Commodity/Xiajia">
                        <span class="shop_img shop_m_img shop_xj_goods"></span>
                        <span class="shop_m_name">下架商品</span>
                    </nuxt-link>
                    <nuxt-link class="shop_m_i" to="/Antique/Commodity/Weishen">
                        <span class="shop_img shop_m_img shop_nos_goods"></span>
                        <span class="shop_m_name">待审商品</span>
                    </nuxt-link>
                    <nuxt-link class="shop_m_i" to="/Antique/Commodity/shopKind">
                        <span class="shop_img shop_m_img shop_m_fp"></span>
                        <span class="shop_m_name">商品分类</span>
                    </nuxt-link>
                    <nuxt-link class="shop_m_i" to="/Antique/Commodity/ShopProd_M">
                        <span class="shop_img shop_m_img shop_up_goods_s"></span>
                        <span class="shop_m_name">商品上传</span>
                    </nuxt-link>
                    <nuxt-link class="shop_m_i" to="/Antique/Commodity/ImportProduct">
                        <span class="shop_img shop_m_img shop_m_asles"></span>
                        <span class="shop_m_name">地摊导入</span>
                    </nuxt-link>                

                    <div class="shop_m_iso">
                        <div class="shop_img shop_m_isb1">
                            <input id="txtKey" class="shop_m_iskey1 fl" type="text" value="请输入藏品编号或藏品名称" onfocus="if($(this).val()==&#39;请输入藏品编号或藏品名称&#39;){$(this).val(&#39;&#39;);}" onblur="if($(this).val().replace(/(^\s*)|(\s*$)/g,&#39;&#39;)==&#39;&#39;){$(this).val(&#39;请输入藏品编号或藏品名称&#39;);}">
                            <input id="btnSo" class="shop_m_isbut1 fl" type="button" value="搜 索" onclick="var key = $(&#39;#txtKey&#39;).val().replace(/(^\s*)|(\s*$)/g, &#39;&#39;); if (key == &#39;&#39; || key == &#39;请输入藏品编号或藏品名称&#39;) { return false; } else { window.location.href = &#39;shopProd_Search.aspx?keys=&#39; + escape(key); }">
                        </div>
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