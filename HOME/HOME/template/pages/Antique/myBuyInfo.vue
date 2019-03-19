	<!-- 我的求购  -->
	<template id="myBuyInfo">
			<div class="mright"> 
            <div class="binfo_menu">
                <nuxt-link to="/Antique/myBuyInfo/myBuyInfo1" class="binfo_m_i">
                    <span class="binfo_img binfo_m_img binfo_m_all_s"></span>
                    <span class="binfo_m_name">我的求购</span>
                </nuxt-link>
                <nuxt-link to="/Antique/myBuyInfo/myBuyInfo2" class="binfo_m_i"  target="_blank">
                    <span class="binfo_img binfo_m_img binfo_m_up"></span>
                    <span class="binfo_m_name">发布求购</span>
                </nuxt-link>
                <nuxt-link to="/Antique/myBuyInfo/myBuyInfo3" class="binfo_m_i" >
                    <span class="binfo_img binfo_m_img binfo_m_com"></span>
                    <span class="binfo_m_name">求购评论</span>
                </nuxt-link>
                <nuxt-link to="/Antique/myBuyInfo/myBuyInfo4" class="binfo_m_i" >
                    <span class="binfo_img binfo_m_img binfo_m_sc"></span>
                    <span class="binfo_m_name">我的收藏</span>
                </nuxt-link>
                <div class="binfo_m_iso">
                    <div class="binfo_img binfo_m_isb">
                        <div class="binfo_m_issbox fl">
                            <ul class="binfo_m_issel_ul">
                                <li>关键字</li>
		                    </ul>
                            <input name="ddlType" value="关键字" readonly="readonly" id="ddlType" class="fl" onfocus="$(this).blur()" type="text">
                        </div>
                        <input name="txtKey" maxlength="15" id="txtKey" class="binfo_m_iskey fl" type="text">
                        <input name="btnSo" value="" id="btnSo" class="binfo_m_isbut fl" type="submit">
                    </div>
                </div>
            </div>
			<nuxt-child/>
        </div>
	</template>

<script>
	import '~/assets/css/buyinfo.css'
	export default{
		
	}
</script>

<style>
</style>