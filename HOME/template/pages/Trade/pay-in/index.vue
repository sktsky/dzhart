	<!-- 用户充值 -->
	<template id="pay-in">
			<div class="mright pay_in">
        <div class="menu">
            <a href="/" class="menu_n menu_y">用户充值</a><div class="menu_fill1"></div><div class="clearboth"></div>
        </div>
        <div class="title" style="margin-top:30px;">实时在线充值</div>
        <div class="show_frame">
            <div class="ico stepWords8">拥有网上银行账户</div>
            <div class="ico stepWords6 margin_left_10">填写充值金额</div>
            <div class="ico stepWords6 margin_left_10">选择支付网银</div>
            <div class="ico stepWords4 margin_left_10">付款成功</div>
            <div class="ico stepWords8End margin_left_10">一分钟后查询到账</div><div style="clear:both;"></div>
            <p class="p1">您好！只有开通网上银行功能的银行卡才可以使用在线充值方式，一分钟快速把现金存入您的现金帐户。方便，快速，安全，无须等待本网确认。</p>
            
            <p class="p2">此方式充值，需收取手续费（网银0.5%、信用卡0.5%、支付宝0.6%），上不封顶。（如网银充值，到帐1000元，需要付款1005元。金额大的，建议使用银行转帐到华夏收藏网银行账户）。<br>
            <a href="http://www.cang.com/pay.html" target="_blank" style="color:blue">汇款方式</a></p>
            <br><br>
            <nuxt-link to="/Pay_inYibao"  class="btn" style="float:left;margin-left:35px">网银充值</nuxt-link>
            <nuxt-link to="/Pay_inAlipay"  class="btn" style="float:left;margin-left:35px">支付宝充值</nuxt-link> <div style="clear:both;"></div>
            
        </div>
        <div class="title margin_top_30">银行汇款确认</div>
        <div class="show_frame">
            <div class="ico stepWords6">线下银行汇款</div>
            <div class="ico stepWords9 margin_left_10">汇款至本网指定账户</div>
            <div class="ico stepWords7 margin_left_10">填写汇款确认单</div>
            <div class="ico stepWords4 margin_left_10">网站确认</div>
            <div class="ico stepWords8End margin_left_10">账户到账</div><div style="clear:both;"></div>
            <p class="p1">您好！请确认您已经通过：网上银行、银行柜台、ATM机或支付宝等途径向本网指定的帐户汇款；如果您还没有汇款，请先汇款。下面为本网指定的收款银行帐户。</p>
            <br><br>
            <nuxt-link to="/remit"  class="btn" style="margin-left:240px; display:block;">汇款确认</nuxt-link>
            
        </div>
        <div class="title margin_top_30">本网指定的收款银行帐户</div>
        <div class="show_frame" style="margin-bottom:20px;">
            <table class="pay_in_table">
                <tbody><tr>
                    <td><a href="http://www.ccb.com/" target="_blank"><img src="/images/www_ccb_cn.gif" alt=""></a></td>
                    <td>收款人：杭州趣得网络技术有限公司<br>中国建设银行杭州仓基上分理处<br>帐号：<b>3300 1616 4450 5300 0451</b></td>
                    <td><a href="http://www.icbc.com.cn/" target="_blank"><img src="/images/icbc_com_cn.gif" alt=""></a></td>
                    <td style="width:210px;">收款人：杭州趣得网络技术有限公司<br>工商银行杭州观音桥支行<br>帐号：<b>1202 0517 1990 0073 765</b></td>
                </tr>
                <tr>
                    <td><a href="http://www.95599.cn/" target="_blank"><img src="/images/www_95599_cn.gif" alt=""></a></td>
                    <td>收款人：杭州趣得网络技术有限公司<br>农行杭州和睦支行<br>帐号：<b>1901 0201 0400 1372 6</b></td>
                    <td><a href="http://www.cmbchina.com/" target="_blank"><img src="/images/www_cmbchina_com.gif" alt=""></a></td>
                    <td>收款人：杭州趣得网络技术有限公司<br>招商银行杭州城北小微企业专营<br>帐号：<b>5719 0796 3810 302</b></td>
                </tr>
                <tr>
                    <td><a href="http://www.psbc.com/" target="_blank"><img src="/images/www_psbc_com.jpg" alt=""></a></td>
                    <td>收款人：杭州趣得网络技术有限公司<br>中国邮政储蓄银行杭州市学院路支行<br>帐号：<b>9330 0601 0018 5889 00</b></td>
                    <td><a href="http://www.paypal.com/" target="_blank"><img src="/images/paypal_logo.gif" alt=""></a></td>
                    <td>收款人：杭州趣得网络技术有限公司<br>美元：job@cang.com</td>
                </tr>
            </tbody></table>
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