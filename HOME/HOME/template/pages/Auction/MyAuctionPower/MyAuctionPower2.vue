<!-- 专场保证金里的拍卖出价资格 begin -->
<template id="MyAuctionPower2">
			<div class="pai_cz_box">
                <div style="font-size:14px;border:1px #CCC solid;padding:10px;color:#646464;line-height:20px;">
                    <span class="showtxt">您的拍卖出价资格：</span><span class="showtxt2">普通拍卖</span><span class="fail"></span><span class="showtxt2">专场拍卖</span><span class="fail"></span><span class="showtxt2">精品拍卖</span><span class="fail"></span><br><br>您有以下方式可以申请出价资格
                    <div id="noPower" style="padding-top:10px;line-height:1.6">1、通过交付一定的保证金申申请出价资格<a href="http://pay.cang.com/myhome/paimai/AuctionForegift.aspx" style="margin-left:20px;color:Red">立即申请</a><br></div>
                    
                    
                </div>
                <input name="HidID" id="HidID" value="0" type="hidden">
                <div style="width:100%;overflow:hidden;color:#646464;font-size:14px;margin-top:25px;">
                     <span class="b">拍卖规则：</span><br>
                        <textarea name="txtRule" rows="16" cols="20" id="txtRule" style="line-height:25px;width:100%;border:0px;color:#646464;font-size:14px;margin-top:15px;">1、普拍条件：押金在100元以上；午间小拍，专拍条件：押金在1000元以上；精品拍卖押金必须在5000元以上。
						2、本网采用4分钟延时拍卖，因为不是实时刷新，以及用户网络环境有异，可能会出现5分多钟还有出价，均属正常，以能有效出价为准；
						3、出价幅度机制，100(含)以下加价5元，101-500(含)加价10，501-1000(含)加价20，1001-5000(含)加价50，5001-10000(含)加价100，10000以上加价200，查看公告；
						4、报价必须不能低于起拍价（起拍价为0元的，报价必须高于0元），也不能高于一口价，上传本人只能评论不能报价；
						5、竞价品一旦超时,只有交易员和藏品上传人才可以评论回复；
						6、由于网速和浏览器功能等问题，在提示超时后，请按F5刷新本页再次确认是否超时；
						7、竞价结束后，本网视能提交报价的最后一个报价且不低于保留价的有效买家为最终买家。</textarea>   
                </div> 
                
            </div>
	</template>

<script>
	import '~/assets/css/paimai.css'
	export default{
		
	}
</script>

<style>
</style>