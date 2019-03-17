	<!-- 发帖 -->
	<template id="Estimation_M2">
			<div class="jd_cz_box">
                    <div class="jd_ggxx">
                        <a href="#">交流区上传实行新规</a>
                        <span class="jd_img ml20 gx_close" onclick="$(this).parent().hide();"></span>
                        <span class="fr mr">帐户金额：<span>￥: <font id="f_Money">0.0</font></span> <router-link to="/pay-in">充值</router-link>    藏币金额：<span><font id="f_Level">160</font></span> <router-link to="/cangbi">购买藏币</router-link></span>
                    </div>                          
					  <h3><nuxt-link to="/Appraisal/Estimation_M/Estimation_M2/Estimation_M2_b">藏友交流</nuxt-link></h3>
					  <h3><nuxt-link to="/Appraisal/Estimation_M/Estimation_M2/Estimation_M2_a">鉴定估价</nuxt-link></h3>
					<nuxt-child/>
              </div>
                
	</template>

<script>
export default{};
</script>

<style>
</style>