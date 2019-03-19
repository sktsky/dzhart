    <!-- 鉴定估价 -->
    	<template id="Estimation_M">
			<div class="mright">
                <div class="jd_menu">
                    <nuxt-link to="/Appraisal/Estimation_M/Estimation_M1" class="jd_m_i">
                        <span class="jd_img jd_m_img jd_m_all"></span>
                        <span class="jd_m_name">我的帖子</span>
                    </nuxt-link>
                    <nuxt-link to="/Appraisal/Estimation_M/Estimation_M2/Estimation_M2_b" class="jd_m_i">
                        <span class="jd_img jd_m_img jd_m_up_s"></span>
                        <span class="jd_m_name">发 帖</span>
                    </nuxt-link>
                    <nuxt-link to="/Appraisal/Estimation_M/Estimation_M3" class="jd_m_i">
                        <span class="jd_img jd_m_img jd_m_com"></span>
                        <span class="jd_m_name">我的评论</span>
                    </nuxt-link>
                    <nuxt-link to="/Appraisal/Estimation_M/Estimation_M4" class="jd_m_i">
                        <span class="jd_img jd_m_img jd_m_coupon"></span>
                        <span class="jd_m_name">我的鉴定劵</span>
                    </nuxt-link>
                </div>
                <nuxt-child/>
            </div>
	</template>

<script>
	import '~/assets/css/jianding.css'
	export default{
		
	}
</script>

<style>
</style>