<!--首页-->
<template id="myhome">
	<div>
		<div class="main">

			<!--用户信息 begin-->
			<div class="version_user">
				<a href="#" target="_blank" class="version_head">
					<img src="../assets/images/no-user.png"></a>
				<div class="version_info">
					<a href="#" target="_blank" class="version_name">sktsky</a>
					<p>	藏友号14603583 
									<span>
			            <a href="" target="_self"><i class="fa fa-id-card-o sdicon5"
			                    title="身份认证点击开通"></i></a><a href=""
			                target="_self"><i class="fa fa-envelope-open sdicon5" title="邮箱认证点击开通"></i></a><i
			                class="fa fa-podcast sdicon4" title="手机认证"></i><a href=""
			                target="_self"><i class="fa fa-cart-plus sdicon5" title="消保认证点击开通"></i></a><a href=""
			                target="_self"><i class="fa fa-address-book sdicon5" title="银牌店铺点击开通"></i></a><a
			                href="" target="_self"><i class="fa  fa-address-book sdicon5"
			                    title="金牌店铺点击开通"></i></a><a href=""
			                target="_self"><i class="fa fa-address-book sdicon5" title="钻石店铺点击开通"></i></a>
			
			       	  </span>
					</p>
				</div>
			</div>
			<ul>
				<li>

					<ul class="email">

						<li>
							<a href="">
								<p>短信</p>
								<span id="allmsgnum">0</span>
							</a>
						</li>
						<li class="star">
							<a href="">
								<p>系统消息</p>
								<span id="sysmsgnum">0</span>
							</a>
						</li>
					</ul>
				</li>
				<li class="capital">
					<div class="title">
						<a href="" class="title-left">账户金额：</a>
					</div>
					<ul class="account">
						<li>
							<h1>0.00元</h1>
							<a href=""><span class="detailed">账户明细</span></a>
							<div class="btns">
								<nuxt-link to="/pay-in" class="btn1">
									<p>用户充值</p>
								</nuxt-link>
								<nuxt-link to="/drawmoney" class="btn1">
									<p>提现申请</p>
								</nuxt-link>
							</div>
						</li>
					</ul>
				</li>
			</ul>

			<ul>
				<li class="orders-b buyers">
					<div class="title">
						<nuxt-link to="/Trade" class="title-left">我的买单 </nuxt-link>
						<a href=""><span class="num">0</span> </a>
						<nuxt-link to="/Trade" href=""><span>历史成交记录</span> </nuxt-link>
					</div>
					<ul class="orders-buy">
						<li>
							<a href="">
								<p>待确认价格</p><span class="jd_num">0</span>
							</a>
						</li>
						<li>
							<a href="">
								<p>待付款</p><span class="jd_num">0</span>
							</a>
						</li>
						<li>
							<a href="">
								<p>待验货</p><span class="jd_num">0</span>
							</a>
						</li>
					</ul>
					<div class="title">
						<a href="javascript:void(0);" class="title-left title_credit">买家信誉<i class="iconfont icon-v0 icon-creditp" title="1"></i><strong>1</strong></a>
					</div>
					<div class="text_credit">
						<p>退款率:<span> 0.00%</span></p>
						<p>平台介入率: <span>0.00%</span></p>
						<p>本月违约: 0 </p>
					</div>
				</li>

			</ul>
			<ul class="ad">
				<a href="#"><img src="../assets/images/201708241328580693.jpg" alt="华夏微拍" border="0"></a>
			</ul>

			<ul>
				<li class="my-jd">
					<div class="title">
						<nuxt-link to="/MyAntiqueEstimations" class="title-left">鉴定估价
						</nuxt-link>
						<a href="" class="btn4">
							<p>估价上传</p>
						</a>
					</div>
					<ul class="jd-post">
						<li>
							<nuxt-link to="/MyAntiqueEstimation">
								<p>待鉴定</p>
								<span class="jd_num">0</span>
							</nuxt-link>
						</li>
						<li>
							<nuxt-link to="/MyAntiqueEstimation">
								<p>已鉴定</p>
								<span class="jd_num">0</span>
							</nuxt-link>
						</li>

					</ul>
				</li>
			</ul>

			<ul>
				<li class="cangbi cangbi1">
					<div class=""><span class="earn_tibetan">+10</span>藏币
						<p>现在起上传身份证通过实名制身份验证即可获得10藏币。</p>
					</div>
					<nuxt-link to="/UserCard" class="btn-light">验 证</nuxt-link>
				</li>
				<li class="cangbi cangbi2">
					<div class=""><span class="earn_tibetan">+20</span>藏币
						<p>每推荐一个藏友来注册可获20藏币。</p>
					</div>
					<a id="urlclip" href="javascript:void(0);" data="#" class="btn-medium">复制网址</a>

				</li>
				<li class="cangbi cangbi3">
					<div class=""><span class="earn_tibetan">+30</span>藏币
						<p>首次下载短信通可获得30藏币。</p>
					</div>
					<a href="#" target="_blank" class="btn-dark">下 载</a>
				</li>
				<li class="cangbi cangbi4">
					<div class=""><span class="earn_tibetan">更多</span>藏币
						<p>每天登陆或增加在线时长都可以增加藏币量，详情请看藏币奖励规则。</p>
					</div>
					<a href="#" target="_blank" class="btn-light">去看看</a>
				</li>
			</ul>
		</div>
		<div style="float: left; width: 240px; margin:0 0 10px 16px;">

			<a href="#" target="_blank"><img src="../assets/images/2018092511003430365878.jpg" alt="收藏门道第十五期" border="0"></a>

			<div class="nright">
				<ul class="coin">
					<li>
						<div class="title">
							<h6 style="margin-bottom: 0; float: left;">我的藏币</h6>
							<span class="coin_star">
                                <font style="float: left;">藏币等级</font><img src="../assets/images/user1.gif" alt="一绿角">
                            </span>
						</div>
					</li>
					<table style="margin-left: 10px;" width="212" cellspacing="0" cellpadding="0">
						<tbody>
							<tr>
								<td>
									<a href="" style="text-decoration: none;"><span id="userlevel" class="shuzi">150</span></a><span class="usable">可用藏币</span>
									<a href="" style="color: #09f; font-weight: bold; line-height: 30px; margin-left: 5px;">[购买]</a>
								</td>
							</tr>
							<tr>
								<td onclick="_hmt.push(['_trackEvent', '签到', 'click', 'literature'])">

									<a href="javascript:void(0);" id="addchick" class="btn2 btn-sign" style="width: 62px; float: left" onclick="ucheck();">签 到</a>
									<a id="chicktitle" class="btn2" style="background: none; color: #999999">马上签到领取2藏币</a>

								</td>
							</tr>
						</tbody>
					</table>
				</ul>
				<ul class="remen">
					<li>
						<div class="title">
							<img src="../assets/images/hot.png">
							<h6>鉴定估价</h6>
						</div>
					</li>

					<li>
						<a href="#" target="_blank">
							<p style="white-space: nowrap; overflow: hidden; text-overflow: ellipsis; word-break: break-all;">小葵花妈妈开课了！ 南红八大保养技巧 给到您</p>
						</a>
					</li>

					<li>
						<a href="#" target="_blank">
							<p style="white-space: nowrap; overflow: hidden; text-overflow: ellipsis; word-break: break-all;">12.1公斤 德诚 精品 一对</p>
						</a>
					</li>

					<li>
						<a href="#" target="_blank">
							<p style="white-space: nowrap; overflow: hidden; text-overflow: ellipsis; word-break: break-all;">hey，祥东珠宝阿辉，一个专注保山精品南红，只做原矿的玉商</p>
						</a>
					</li>

					<li>
						<a href="#" target="_blank">
							<p style="white-space: nowrap; overflow: hidden; text-overflow: ellipsis; word-break: break-all;">清代 绢底 石迂澍 翠鸟 荷花</p>
						</a>
					</li>

					<li>
						<a href="#" target="_blank">
							<p style="white-space: nowrap; overflow: hidden; text-overflow: ellipsis; word-break: break-all;">清代 精品 粤绣 挂屏 一对</p>
						</a>
					</li>

				</ul>
				<!-- end TuiJian -->

				<ul class="remen">
					<li>
						<div class="title">
							<img src="../assets/images/hot.png">
							<h6>网站热门</h6>
						</div>
					</li>
					<li>
						<a href="#" target="_blank">
							<p><span>①润心斋主第三十场瓷杂珠宝晚拍8.15~16</span></p>
						</a>
					</li>
					<li>
						<a href="#" target="_blank">
							<p><span>②BOOT个人第四十二场翡翠琥珀专拍8.15~16</span></p>
						</a>
					</li>
					<li>
						<a href="#" target="_blank">
							<p>③【季度大拍】全场买就反1%</p>
						</a>
					</li>
					<li>
						<a href="#" target="_blank">
							<p>④交易使用帮助:0571-87816879</p>
						</a>
					</li>
					<li>
						<a href="" target="_blank">
							<p>⑤免费创建私人博物馆</p>
						</a>
					</li>
					<li>
						<a href="#" target="_blank">
							<p>⑥文物修复是收藏的必然趋势！华夏修复活动</p>
						</a>
					</li>
					<li>
						<a href="#" target="_blank">
							<p>⑦加入消保用户 <img src="../assets/images/xiaobao.png" alt="消保用户" style="border:0px;"></p>
						</a>
					</li>
					<li>
						<a href="#" target="_blank">
							<p>⑧【地摊热推】行家眼里的好瓷器</p>
						</a>
					</li>
					<li>
						<a href="#" target="_blank">
							<p>⑨请你来代言！华夏版主招募！</p>
						</a>
					</li>
					<li>
						<a href="#" target="_blank">
							<p>⑩【推荐】个人专场 自己创建专场，方便快捷</p>
						</a>
					</li>
				</ul>
				<!--end remen-->
				<!-- 网站热门 -->
				<ul class="haoyou">
					<li id="frienddy">
						<div class="title">
							<img src="../assets/images/haoyou.png">
							<h6>好友动态</h6>

							<a href="javascript:void(0);" title="拍卖" class="friendpm" data="friendpm" onmouseover="frienddiv('friendpm')">拍卖</a>
							<a href="javascript:void(0);" title="地摊" class="frienddth" data="frienddt" onmouseover="frienddiv('frienddt')">地摊</a>
							<a href="javascript:void(0);" title="商品" class="friendsp" data="friendsp" onmouseover="frienddiv('friendsp')">商品</a>
						</div>
					</li>
					<span id="friendsp" style="display: none;"></span>
					<span id="frienddt" style="display: block;">
                        <li>
                            <ul>
                                <li>暂时好友拍卖没有动态</li>
                            </ul>
                        </li>
                    </span>
					<span id="friendpm" style="display: none;"></span>
					<span id="friendgj" style="display: none;"></span>

				</ul>
				<!--end haoyou-->
			</div>
		</div>
	</div>
</template>

<script>
	import '~/assets/css/jystyle.css'
	import '~/assets/css/jystyle(2).css'
	export default {

	}
</script>

<style>

</style>