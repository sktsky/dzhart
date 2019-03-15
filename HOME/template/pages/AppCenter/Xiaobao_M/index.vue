	<!-- 开通消保 begin -->
	<template id="Xiaobao_M">
			<div class="mright Xiaobao">
                <div class="menu">
                    <router-link to="/Xiaobao_M" class="menu_n menu_y" @click="routerBack()">开通消保</router-link>
                    <div class="menu_fill1" style="height:53px;"></div>
                    <div style="clear:both;"></div>
                </div>
                <img src="images/xiaobaoTopImg.png" alt="" style="margin:20px 0px 0px 10px;">
                <div class="Spacing1">当前账户资金余额：<span id="lbCurMoney" class="obvious">0.00</span></div>
                <div id="PnTradePwd">
	
                <div class="Spacing1">交易密码：<input name="txtPayPwd" id="txtPayPwd" style="width:120px;" type="password"></div>
				</div>
                <div class="Spacing1"><input name="btnAdd" value="同意消保协议并开通" onclick="return CheckNum();" id="btnAdd" class="XiaoBaoBtnAdd" type="submit"></div>
                <div class="MainTitel">消费者保障服务</div>
                <ul class="ContentFrame">
				    <li>
					    <h6>Q1：什么是消保？</h6>
					    <p>
						    消保是消费者权益保障协议的简称，是用户用以提升信誉形象的必备认证之一。【
						    <a href="http://news.cang.com/infos/201109/166951.html" target="_blank"><span>消保协议内容</span>
						    </a>】
					    </p>
				    </li>
				    <li>
					    <h6>Q2：消保专题介绍</h6>
					    <p>
						    消费者保障服务，介绍华夏消保相关公告，消保服务相关问题 的详细说明。【
						    <a href="http://news.cang.com/zhuanti/zhuanti-2176.html" target="_blank"><span>消保专题介绍</span>
						    </a>】
					    </p>
				    </li>
				    <li>
					    <h6>Q3:如何加入？</h6>
					    <p>
						    联系JERRY扣除500元消保押金。 【账户余额不足？
						    <a href="http://pay.cang.com/member/trade/pay-in.aspx"><span>实时在线充值</span></a> 或 <a href="http://www.cang.com/pay.asp"><span>线下其它方式充值</span></a>
						    】
					    </p>
				    </li>
				    <li>
					    <h6>Q4:消保的三大好处：</h6>
					    <ol>
						    <li>
							    <p>
								    1.用户列入独立消保专区.
							    </p>
						    </li>
						    <li>
							    <p>
								    2.藏品优先审核.
							    </p>
						    </li>
						    <li>
							    <p>
								    3.拥有消保认证标志.
							    </p>
						    </li>	
					    </ol>	
				    </li>
				    <li>
					    <h6>Q5：消保申请成功后能退吗？</h6>
					    <p>
						    当然能退，不过退出后1年内不得再次申请加入，要三思啊。退出手续请站内信联系JERRY，手续费参照Q6内容.
					    </p>
				    </li>
				    <li>
					    <h6>Q6：什么时候会用到消保的保障金？</h6>
					    <p>
						    一般情况下是不会动用滴，除非--用户违反【
						    <a href="http://news.cang.com/infos/201109/166951.html" target="_blank">
							    <span>消保协议内容</span>
						    </a>
						    】
					    </p>
				    </li>
				    <li>
					    <h6>Q7：开通办理及取消消保业务的手续费是多少？</h6>
					    <p>
						    用户办理开通消保业务不收取手续费，用户申请退出消保须扣除500藏作为手续费。
					    </p>
				    </li>
				    <li>
					    <h6>Q8:对于违背消保协议的用户如何惩罚？</h6>
					    <p>
						    用户在服务申请通过审核后，所售商品累积3次（包括3次） 投诉，华夏网将退回该商 家所余保证金，将其清理出华夏消保用户队伍，并以公告形式公示华夏收藏网所有藏友。
					    </p>
				    </li>
			    </ul>
            </div>
	</template>	

<script>
	import '~/assets/css/Custom.css'
	import '~/assets/css/jystyle.css'
	export default {
		
	}
</script>

<style>
</style>