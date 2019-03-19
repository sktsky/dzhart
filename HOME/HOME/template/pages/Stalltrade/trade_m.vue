	<template id="trade_m">
			<div class="mright">
                <div class="td_menu">
                    <nuxt-link to="/Stalltrade/trade_m/trade_m1" class="td_m_i">
                        <span class="td_img td_m_img td_m_all"></span>
                        <span class="td_m_name">所有地摊</span>
                    </nuxt-link>
                    <nuxt-link to="/Stalltrade/trade_m/trade_m2" class="td_m_i">
                        <span class="td_img td_m_img td_m_up_s"></span>
                        <span class="td_m_name">地摊上传</span>
                    </nuxt-link>
                    <nuxt-link to="/Stalltrade/trade_m/trade_m3" class="td_m_i">
                        <span class="td_img td_m_img td_m_com"></span>
                        <span class="td_m_name">地摊评论</span>
                    </nuxt-link>
                    <nuxt-link to="/Stalltrade/trade_m/trade_m4" class="td_m_i">
                        <span class="td_img td_m_img td_m_sc"></span>
                        <span class="td_m_name">我的收藏</span>
                    </nuxt-link>
                    <div class="td_m_iso">
                        <div class="td_img td_m_isb">
                            <div class="td_m_issbox fl">
                                <ul class="td_m_issel_ul">
                                    <li>藏品编号</li>
                                    <li>藏品名称</li>
                                </ul>
                                <input name="ddlType" value="藏品编号" readonly="readonly" id="ddlType" class="fl" onfocus="$(this).blur()" type="text">
                            </div>
                            <input name="txtKey" maxlength="10" id="txtKey" class="td_m_iskey fl" type="text">
                            <input name="btnSo" value="" id="btnSo" class="td_m_isbut fl" type="submit">
                        </div>
                    </div>
                </div>
                <nuxt-child/>
            </div>
	</template>	

<script>
	import '~/assets/css/trade.css'
	export default{
		
	}
</script>

<style>
</style>