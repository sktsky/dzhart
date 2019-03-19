<template>
	<div>

		<div id="shortcut-2013">
			<div class="w">
				<ul class="fl lh">
					<li class="fore1" id="loginbar" clstag="homepage|keycount|home2013|01b">您好！欢迎来到大中华艺术网！
						<a href="javascript:login()">[登录]</a>&nbsp;
						<a href="javascript:regist()">[免费注册]</a>
					</li>
				</ul>
				<ul class="fr lh">
					<li class="fore2 ld" clstag="homepage|keycount|home2013|01c">
						<s></s>
						<a href="http://jd2008.jd.com/JdHome/OrderList.aspx" rel="nofollow">我的收藏</a>
					</li>
					<li class="fore2-1 ld" id="jd-vip">
						<s></s>
						<a target="_blank" rel="nofollow" href="http://vip.jd.com">会员俱乐部</a>
					</li>
					<li class="fore3 ld menu" id="app-jd" data-widget="dropdown" clstag="homepage|keycount|home2013|01d">
						<s></s><i></i><span class="outline"></span><span class="blank"></span>
						<a href="http://app.jd.com/" target="_blank">手机中华</a><b></b>
					</li>
					<li class="fore4 ld menu" id="biz-service" data-widget="dropdown" clstag="homepage|keycount|home2013|01e">
						<s></s>
						<span class="outline"></span>
						<span class="blank"></span> 客户服务
						<b></b>
						<div class="dd">
							<div>
								<a href="http://help.jd.com/index.html" target="_blank">帮助中心</a>
							</div>
							<div>
								<a href="http://myjd.jd.com/repair/orderlist.action" target="_blank" rel="nofollow">售后服务</a>
							</div>
							<div>
								<a href="http://chat.jd.com/jdchat/custom.action" target="_blank" rel="nofollow">在线客服</a>
							</div>
							<div>
								<a href="http://myjd.jd.com/opinion/list.action" target="_blank" rel="nofollow">投诉中心</a>
							</div>
							<div>
								<a href="http://www.jd.com/contact/service.html" target="_blank">客服邮箱</a>
							</div>
						</div>
					</li>
					<li class="fore5 ld menu" id="site-nav" data-widget="dropdown" clstag="homepage|keycount|home2013|01f">
						<s></s>
						<span class="outline"></span>
						<span class="blank"></span> 网站导航
						<b></b>
						<div class="dd lh">
							<dl class="item fore1">
								<dt>中华栏目</dt>
								<dd>
									<div>
										<a target="_blank" href="http://mobile.jd.com/index.do">网站首页</a>
									</div>
									<div>
										<a target="_blank" href="http://jdstar.jd.com/">拍卖中心</a>
									</div>
									<div>
										<a target="_blank" href="http://my.jd.com/personal/guess.html">鉴定估价</a>
									</div>
									<div>
										<a target="_blank" href="http://shipingou.jd.com/">地摊</a>
									</div>
									<div>
										<a target="_blank" href="http://club.jd.com/">古玩城</a>
									</div>
									<div>
										<a target="_blank" href="http://read.jd.com/">海外馆</a>
									</div>
									<div>
										<a target="_blank" href="http://diy.jd.com/">收藏头条</a>
									</div>
									<div>
										<a target="_blank" href="http://xihuan.jd.com/">我的收藏</a>
									</div>
								</dd>
							</dl>
							<dl class="item fore2">
								<dt>企业服务</dt>
								<dd>
									<div>
										<a target="_blank" href="http://giftcard.jd.com/company/index">企业客户</a>
									</div>
									<div>
										<a target="_blank" href="http://sale.jd.com/p10997.html">办公直通车</a>
									</div>
								</dd>
							</dl>
							<dl class="item fore3">
								<dt>旗下网站</dt>
								<dd>
									<div>
										<a target="_blank" href="http://en.jd.com/">English Site</a>
									</div>
								</dd>
							</dl>
						</div>
					</li>
				</ul>
				<span class="clr"></span>
			</div>
		</div>

		<div id="webapp" v-cloak>
			<!-- header begin -->
			<div class="headern">
				<!--loge-->
				<div class="toploge">
					<div class="headloge">
						<div class="logo fl">
							<a href="#"><img src="../assets/images/logo.png" alt=""></a>
							<a class="nline" href="#">
								<h2 class="fl">我的家园</h2>
							</a>
						</div>
					</div>
				</div>
				<!--top菜单  begin-->
				<div class="topnav">
					<div class="topnav_wrap">
						<div class="nav_box">
							<ul id="nav_bulb" class="nav_bul">
								<li class="nav_bli nav_blis" data="sel">
									<nuxt-link to="/Myhome">首页</nuxt-link>
								</li>
								<li class="nav_bli" data="">
									<nuxt-link to="/UserInfo">个人信息</nuxt-link>
								</li>
								<li class="nav_bli" data="">
									<nuxt-link to="/Trade">交易系统</nuxt-link>
								</li>
								<li class="nav_bli" data="">
									<nuxt-link to="/Msglist/msglistsd">站内短信</nuxt-link>
								</li>
								<li class="nav_bli" data="">
									<nuxt-link to="/AppCenter/Xiaobao_M">应用中心</nuxt-link>
								</li>
								<li class="nav_bli" data="">
									<nuxt-link to="/Quicks">快速指南</nuxt-link>
								</li>
							</ul>
							<div class="n_bl_menu">
								<div class="n_bl_mlist">
								</div>
							</div>
							<div class="n_bl_menu">
								<div class="n_bl_mlist">
									<ul>
										<li v-for="items in navList" :key="items.index" :class="{active:items.isActive}" @click="activeFun(items)">
											<nuxt-link v-bind:to="items.id">
												{{items.text}}
											</nuxt-link><span>|</span>
										</li>
									</ul>
								</div>
							</div>

							<div class="n_bl_menu">
								<div class="n_bl_mlist">

									<ul>
										<li v-for="items in navList2" :key="items.index" :class="{active:items.isActive}" @click="activeFunb(items)">
											<nuxt-link v-bind:to="items.id">
												{{items.text}}
											</nuxt-link><span>|</span>
										</li>
									</ul>
								</div>
							</div>

							<div class="n_bl_menu">
								<div class="n_bl_mlist">
									<ul>
										<li v-for="items in navList3" :key="items.index" :class="{active:items.isActive}" @click="activeFunc(items)">
											<nuxt-link v-bind:to="items.id">
												{{items.text}}
											</nuxt-link><span>|</span>
										</li>
									</ul>
								</div>
							</div>

							<div class="n_bl_menu">
								<div class="n_bl_mlist">
									<ul>
										<li v-for="items in navList5" :key="items.index" :class="{active:items.isActive}" @click="activeFune(items)">
											<nuxt-link v-bind:to="items.id">
												{{items.text}}
											</nuxt-link><span>|</span>
										</li>
										<li v-for="items in navList6" :key="items.index" :class="{active:items.isActive}" @click="activeFunf(items)">
											<a v-bind:href="items.id">
												{{items.text}}
											</a><span>|</span>
										</li>
									</ul>
								</div>
							</div>
							<div class="n_bl_menu">
								<div class="n_bl_mlist">
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
			<!-- top菜单 end -->

			<div style="margin:10px auto 0 auto;text-align:center;width:1157px;height:80px;">
				<a href="#" target="_blank">
					<img src="../assets/images/201801171739046623.jpg" alt="华夏古玩网" style="width:1157px; height:80px;" border="0"></a>
			</div>

			<div id="home_f_box" class="home_f_box"></div>
			<div style="background:none; top:345px;" class="home_f_box">
				<a href="#" target="_blank"><img src="../assets/images/hyjfk_bg2.png"></a>
			</div>
			<div class="homemask"></div>

			<div class="bodywrap">

				<!-- 左侧导航栏 begin -->
				<div class="nleft">
					<div id="sidebar">
						<ul>
							<li class="submenu">
								<a href="javascript:void(0);">
									<img alt="交易系统" src="../assets/images/jy-icon.png">
									<span>交易系统</span> <span class="arrow"></span></a>
								<ul>
									<li v-for="items in nLeft" :key="items.index" :class="{Leftshow:items.isActive}" @click="showFun(items)">
										<nuxt-link v-bind:to="items.id">
											{{items.text}}
										</nuxt-link>
									</li>
								</ul>
								<div style="clear: both">
								</div>
							</li>
						</ul>
						<ul>
							<li class="submenu">
								<a href="javascript:void(0);">
									<img alt="鉴定估价" src="../assets/images/jd-icon.png">
									<span>鉴定估价</span> <span class="arrow"></span></a>
								<ul>
									<li v-for="items in nLeft2" :key="items.index" :class="{Leftshow:items.isActive}" @click="showFuna(items)">
										<nuxt-link v-bind:to="items.id">
											{{items.text}}
										</nuxt-link>
									</li>
								</ul>
								<div style="clear: both">
								</div>
							</li>
						</ul>
						<ul>
							<li class="submenu">
								<a href="javascript:void(0);">
									<img alt="地摊交易" src="../assets/images/dt-icon.png">
									<span>地摊交易</span> <span class="arrow"></span></a>
								<ul>
									<li v-for="items in nLeft3" :key="items.index" :class="{Leftshow:items.isActive}" @click="showFunb(items)">
										<nuxt-link v-bind:to="items.id">
											{{items.text}}
										</nuxt-link>
									</li>
								</ul>
								<div style="clear: both">
								</div>
							</li>
						</ul>
						<ul>
							<li class="submenu">
								<a href="javascript:void(0);">
									<img alt="古玩商城" src="../assets/images/wd-icon.png">
									<span>古玩商城</span> <span class="arrow"></span></a>
								<ul>
									<li v-for="items in nLeft4" :key="items.index" :class="{Leftshow:items.isActive}" @click="showFunc(items)">
										<nuxt-link v-bind:to="items.id">
											{{items.text}}
										</nuxt-link>
									</li>
								</ul>
								<div style="clear: both">
								</div>
							</li>
						</ul>

						<ul>
							<li class="submenu">
								<a href="javascript:void(0);">
									<img alt="在线拍卖" src="../assets/images/pm-icon.png">
									<span>在线拍卖</span> <span class="arrow"></span></a>
								<ul>
									<li v-for="items in nLeft5" :key="items.index" :class="{Leftshow:items.isActive}" @click="showFund(items)">
										<nuxt-link v-bind:to="items.id">
											{{items.text}}
										</nuxt-link>
									</li>
								</ul>
								<div style="clear: both">
								</div>
							</li>
						</ul>
						<ul>
							<li class="submenu">
								<a href="javascript:void(0);">
									<img src="../assets/images/xw-icon.png">
									<span>华夏收藏APP</span> <span class="arrow"></span></a>
								<ul>
									<li v-for="items in nLeft6" :key="items.index" :class="{Leftshow:items.isActive}" @click="showFune(items)">
										<nuxt-link v-bind:to="items.id">
											{{items.text}}
										</nuxt-link>
									</li>
									<li v-for="items in nLeft7" :key="items.index" :class="{Leftshow:items.isActive}" @click="showFunf(items)">
										<nuxt-link v-bind:to="items.id">
											{{items.text}}
										</nuxt-link>
										<img src="../assets/images/nleftnew20170602.png" style="position:absolute;right:6px;top: 0px;">
									</li>
								</ul>
								<div style="clear: both">
								</div>
							</li>
						</ul>

					</div>
				</div>
				<!-- 左侧导航栏 end  -->

				<!-- 组件渲染容器 -->
				<nuxt/>
				<!-- 组件渲染容器 -->

				<!-- Footer begin -->
				<div class="w" clstag="homepage|keycount|home2013|37a">
					<div id="service-2013">
						<dl class="fore1">
							<dt><b></b><strong>新手上路</strong></dt>
							<dd>
								<div>
									<a href="http://help.jd.com/help/question-56.html" target="_blank" rel="nofollow">新手注册</a>
								</div>
								<div>
									<a href="http://help.jd.com/help/question-57.html" target="_blank" rel="nofollow">常用工作人员</a>
								</div>
								<div>
									<a href="http://help.jd.com/help/question-181.html" target="_blank" rel="nofollow">24小时在线帮助</a>
								</div>
								<div>
									<a href="http://help.jd.com/help/question-61.html" target="_blank" rel="nofollow">交易安全</a>
								</div>
							</dd>
						</dl>
						<dl class="fore4">
							<dt><b></b><strong>买家服务</strong></dt>
							<dd>
								<div>
									<a href="http://help.jd.com/help/question-64.html" target="_blank" rel="nofollow">汇款方式</a>
								</div>
								<div>
									<a href="http://help.jd.com/help/question-360.html" target="_blank" rel="nofollow">如何下单</a>
								</div>
								<div>
									<a href="http://help.jd.com/help/distribution-768.html" target="_blank" rel="nofollow">如何参与竞价</a>
								</div>
								<div>
									<a href="http://help.jd.com/help/question-892.html#help2215" target="_blank" rel="nofollow">搜索藏品</a>
								</div>
							</dd>
						</dl>
						<dl class="fore4">
							<dt><b></b><strong>卖家服务</strong></dt>
							<dd>
								<div>
									<a href="http://myjd.jd.com/afs/help/afshelp.action" target="_blank" rel="nofollow">上传藏品</a>
								</div>
								<div>
									<a href="http://help.jd.com/help/question-99.html" target="_blank" rel="nofollow">开通网店</a>
								</div>
								<div>
									<a href="http://help.jd.com/help/question-100.html" target="_blank" rel="nofollow">图片处理</a>
								</div>
								<div>
									<a href="http://myjd.jd.com/repair/repairs.action" target="_blank" rel="nofollow">发帖规则</a>
								</div>
							</dd>
						</dl>
						<dl class="fore5">
							<dt><b></b><strong>大中华特色</strong></dt>
							<dd>
								<div>
									<a href="http://help.jd.com/help/question-79.html" target="_blank">网友交流会</a>
								</div>
								<div>
									<a href="http://help.jd.com/help/question-86.html" target="_blank">私人博物馆</a>
								</div>
								<div>
									<a href="http://fuwu.jd.com/" target="_blank" rel="nofollow">收藏圈</a>
								</div>
								<div>
									<a href="http://mobile.jd.com/" target="_blank" rel="nofollow">短信通</a>
								</div>
							</dd>
						</dl>
						<dl class="fore5">
							<dt><b></b><strong>联系方式</strong></dt>
							<dd>
								<div>
									<a href="http://help.jd.com/help/question-79.html" target="_blank">交易专线：0571-88370639 0571-87816879</a>
								</div>
								<div>
									<a href="http://help.jd.com/help/question-86.html" target="_blank">客户服务：0571-87357345</a>
								</div>
								<div>
									<a href="http://fuwu.jd.com/" target="_blank" rel="nofollow">广告招商：0571-88396091</a>
								</div>
								<div>
									<a href="http://mobile.jd.com/" target="_blank" rel="nofollow">华夏联络处</a>
								</div>
							</dd>
						</dl>

						<span class="clr"></span>
					</div>
				</div>

				<div class="w" clstag="homepage|keycount|home2013|38a">
					<div id="footer-2013">
						<div class="links">
							<a href="http://www.jd.com/intro/about.aspx" target="_blank" rel="nofollow">网站首页</a>|
							<a href="http://www.jd.com/contact/" target="_blank" rel="nofollow">版权声明</a>|
							<a href="http://zhaopin.jd.com/" target="_blank" rel="nofollow">关于我们</a>|
							<a href="http://www.jd.com/contact/joinin.aspx" target="_blank" rel="nofollow">豁免条款</a>|
							<a href="http://jzt.jd.com" target="_blank" rel="nofollow">友情链接</a>|
							<a href="http://app.jd.com/" target="_blank" rel="nofollow">网站排行 </a>|
							<a href="http://club.jd.com/links.aspx" target="_blank">企业招聘</a>|
							<a href="http://media.jd.com/" target="_blank">信誉处理 </a>|
							<a target="_blank" href="http://club.jd.com/">用户留言</a>|
							<a target="_blank" href="http://gongyi.jd.com">有奖建议</a>|
							<a target="_blank" href="http://en.jd.com/">广告招商</a>|
							<a>Alexa排名</a>|
							<a>联系我们</a>|
							<a>网站地图</a>|
							<a>全球机构</a>
							|
							<a>官网微博</a>|
							<a>官网微信</a>
						</div>
					</div>
				</div>
				<!-- Footer end -->
			</div>
		</div>
	</div>

</template>
<script>
	import '~/assets/css/taotao.css'
	import '~/assets/css/jystyle.css'
	export default {
		data() {
			return {

				//top部导航栏 begin
				navList: [{
						text: '个人资料',
						isActive: false,
						id: '/UserInfo/PersonalIndex'
					},
					{
						text: '安全设置',
						isActive: false,
						id: '/UserInfo/Safe'
					},
					{
						text: '手机绑定',
						isActive: false,
						id: '/UserInfo/PwdVerify'
					},
					{
						text: '开店申请',
						isActive: false,
						id: '/UserInfo/Openshop'
					},
					{
						text: '邮箱验证',
						isActive: false,
						id: '/UserInfo/PwdVerify2'
					},
					{
						text: '身份认证',
						isActive: false,
						id: '/UserInfo/UserCard'
					},
					{
						text: '登录密码',
						isActive: false,
						id: '/UserInfo/UserPwd'
					},
					{
						text: '交易密码',
						isActive: false,
						id: '/UserInfo/ChangePayPasswd'
					},
					{
						text: '收货地址',
						isActive: false,
						id: '/UserInfo/myAddress'
					},
					{
						text: '网站登录授权管理',
						isActive: false,
						id: '/UserInfo/LoginType'
					},
					{
						text: '拍卖出价资格',
						isActive: false,
						id: '/UserInfo/MyAuctionPower2'
					},
					{
						text: '专场保证金',
						isActive: false,
						id: '/UserInfo/DepositStatus/DepositStatus1'
					},
				],
				navList2: [{
						text: '我的买单',
						isActive: false,
						id: '/Trade'
					},
					{
						text: '我的卖单',
						isActive: false,
						id: '/Trade/sold_list'
					},
					{
						text: '我的投诉',
						isActive: false,
						id: '/Trade/punish_list/punish_list1'
					},
					{
						text: '退款管理',
						isActive: false,
						id: '/Trade/Refund_list/Refund_list1'
					},
					{
						text: '用户充值',
						isActive: false,
						id: '/Trade/pay-in'
					},
					{
						text: '提现申请',
						isActive: false,
						id: '/Trade/drawmoney'
					},
					{
						text: '账户明细',
						isActive: false,
						id: '/Trade/paylog/paylog1'
					},
					{
						text: '收货地址',
						isActive: false,
						id: '/Trade/myAddress'
					},
					{
						text: '银行账号',
						isActive: false,
						id: '/Trade/PayAccount'
					},
					{
						text: '信誉评价',
						isActive: false,
						id: '/Trade/pingjia_list/pingjia_list1'
					},
					{
						text: '购买藏币',
						isActive: false,
						id: '/Trade/cangbi/cangbi1'
					},
					{
						text: '藏币收支',
						isActive: false,
						id: '/Trade/cangbi/CangBiLIst1'
					},
					{
						text: '藏币广告',
						isActive: false,
						id: '/Trade/AdActionList/AdActionList1'
					}
				],
				navList3: [{
						text: '收件箱',
						isActive: false,
						id: '/Msglist/msglistsd'
					},
					{
						text: '系统短信',
						isActive: false,
						id: '/Msglist/msglists1/msglists1'
					},
					{
						text: '未读短信',
						isActive: false,
						id: '/Msglist/msgLists2/msgLists2'
					},
					{
						text: '标识短信',
						isActive: false,
						id: '/Msglist/msgLists3/msgLists3'
					},
					{
						text: '写短信',
						isActive: false,
						id: '/Msglist/msglistsf'
					},
					{
						text: '发件箱',
						isActive: false,
						id: '/Msglist/msglistse'
					},
					{
						text: '垃圾箱',
						isActive: false,
						id: '/Msglist/msgLists4/msgLists4'
					},
				],
				navList5: [{
						text: '开通消保',
						isActive: false,
						id: '/AppCenter/Xiaobao_M'
					},
					{
						text: '直通车',
						isActive: false,
						id: '/AppCenter/AppCenterindex'
					},
					{
						text: '瓷器测试',
						isActive: false,
						id: '/AppCenter/Clause'
					},
				],
				navList6: [{
						text: '专场展销',
						isActive: false,
						id: '/'
					},
					{
						text: '广告推广',
						isActive: false,
						id: '/'
					},
					{
						text: '碰运气',
						isActive: false,
						id: '/'
					},
					{
						text: 'IP查询',
						isActive: false,
						id: '/'
					},
					{
						text: '快递查询',
						isActive: false,
						id: '/'
					},
				],
				//top部导航栏 end

				//侧边导航栏 begin
				nLeft: [{
						text: '我的买单',
						isActive: false,
						id: '/Trade'
					},
					{
						text: '我的卖单',
						isActive: false,
						id: '/Trade/sold_list'
					},
					{
						text: '我的投诉',
						isActive: false,
						id: '/Trade/punish_list/punish_list1'
					},
					{
						text: '退款管理',
						isActive: false,
						id: '/Trade/Refund_list/Refund_list1'
					},
					{
						text: '用户充值',
						isActive: false,
						id: '/Trade/pay-in'
					},
					{
						text: '提现申请',
						isActive: false,
						id: '/Trade/drawmoney'
					},
					{
						text: '账户明细',
						isActive: false,
						id: '/Trade/paylog/paylog1'
					},
					{
						text: '收货地址',
						isActive: false,
						id: '/UserInfo/myAddress'
					},
					{
						text: '银行账号',
						isActive: false,
						id: '/Trade/PayAccount'
					},
					{
						text: '信誉评价',
						isActive: false,
						id: '/Trade/pingjia_list/pingjia_list1'
					},
					{
						text: '购买藏币',
						isActive: false,
						id: '/Trade/cangbi/cangbi1'
					},
					{
						text: '藏币收支',
						isActive: false,
						id: '/Trade/cangbi/CangBiLIst1'
					}
				],
				nLeft2: [{
						text: '发　　帖',
						isActive: false,
						id: '/Appraisal/Estimation_M/Estimation_M2/Estimation_M2_b'
					},
					{
						text: '有偿鉴定',
						isActive: false,
						id: '/Appraisal/Estimation_M/MyAntiqueEstimation'
					},
					{
						text: '我的帖子',
						isActive: false,
						id: '/Appraisal/Estimation_M/Estimation_M1'
					},
					{
						text: '我的评论',
						isActive: false,
						id: '/Appraisal/Estimation_M/Estimation_M3'
					},
					{
						text: '鉴 定 券',
						isActive: false,
						id: '/Appraisal/Estimation_M/Estimation_M4'
					},
					{
						text: '私人博物馆',
						isActive: false,
						id: '/Appraisal/M_zhuanti_List/M_zhuanti_List1'
					}
				],
				nLeft3: [{
						text: '地摊上传',
						isActive: false,
						id: '/Stalltrade/trade_m/trade_m2'
					},
					{
						text: '交易评论',
						isActive: false,
						id: '/Stalltrade/trade_m/trade_m3'
					},
					{
						text: '所有地摊',
						isActive: false,
						id: '/Stalltrade/trade_m/trade_m1'
					},
					{
						text: '地摊收藏',
						isActive: false,
						id: '/Stalltrade/trade_m/trade_m4'
					},
					{
						text: '待售藏品',
						isActive: false,
						id: '/Stalltrade/trade_m/trade_m1'
					},
					{
						text: '已售藏品',
						isActive: false,
						id: '/Stalltrade/trade_m/trade_list'
					},
					{
						text: '工艺品区',
						isActive: false,
						id: '/Stalltrade/trade_m/trade_list2'
					}
				],
				nLeft4: [{
						text: '网店管理',
						isActive: false,
						id: '/Antique/shop_list/shop_list1'
					},
					{
						text: '网店介绍',
						isActive: false,
						id: '/compare'
					},
					{
						text: '发布商品',
						isActive: false,
						id: '/Antique/Commodity/ShopProd_M'
					},
					{
						text: '商品分类',
						isActive: false,
						id: '/Antique/Commodity/shopKind'
					},
					{
						text: '商品管理',
						isActive: false,
						id: '/Antique/Commodity/Shangjia'
					},
					{
						text: '古玩店铺',
						isActive: false,
						id: ''
					},
					{
						text: '商品评论',
						isActive: false,
						id: '/Antique/shopProd/shopProd_Comment1'
					},
					{
						text: '商品收藏',
						isActive: false,
						id: '/Antique/shopProd/shopProd_Comment2'
					},
					{
						text: '我的求购',
						isActive: false,
						id: '/Antique/myBuyInfo/myBuyInfo1'
					},
					{
						text: '求购发布',
						isActive: false,
						id: '/commerce'
					},
					{
						text: '推广教程',
						isActive: false,
						id: '/commerceadd'
					}
				],
				nLeft5: [{
						text: '拍品上传',
						isActive: false,
						id: '/Auction/AuctionProduct_M/AuctionProduct_M6'
					},
					{
						text: '到期拍品',
						isActive: false,
						id: '/Auction/AuctionProduct_M/MyAuction'
					},
					{
						text: '我的拍品',
						isActive: false,
						id: '/Auction/AuctionProduct_M/AuctionProduct_M1'
					},
					{
						text: '我的专场',
						isActive: false,
						id: '/Auction/Auctionlist/Auction_list'
					},
					{
						text: '我的报价',
						isActive: false,
						id: '/Auction/AuctionProduct_M/AuctionProduct_M3'
					},
					{
						text: '别人报价',
						isActive: false,
						id: '/Auction/AuctionProduct_M/AuctionProduct_M4'
					},
					{
						text: '拍品收藏',
						isActive: false,
						id: '/Auction/AuctionProduct_M/AuctionProduct_M2'
					},
					{
						text: '出价资格',
						isActive: false,
						id: '/Auction/MyAuctionPower/MyAuctionPower2'
					},
					{
						text: '专拍申请',
						isActive: false,
						id: '/Auction/Auctionlist/Auction_Apply'
					},
					{
						text: '专场保证金',
						isActive: false,
						id: '/Auction/DepositStatus/DepositStatus'
					}
				],
				nLeft6: [{
						text: '专场发布',
						isActive: false,
						id: '/rules'
					},
					{
						text: '专场管理',
						isActive: false,
						id: '/AuctionList2'
					},
					{
						text: '拍品上传',
						isActive: false,
						id: '/SellerCertification'
					},
					{
						text: '拍品管理',
						isActive: false,
						id: '/AuctionProductList2'
					},
					{
						text: '宝贝上传',
						isActive: false,
						id: '/taobao_m'
					},
					{
						text: '宝贝管理',
						isActive: false,
						id: '/BaobeiList2'
					}
				],
				nLeft7: [{
						text: '宝贝折扣',
						isActive: false,
						id: '/discountGoods1'
					},
					{
						text: '拍品折扣',
						isActive: false,
						id: '/discountGoods2'
					},
					{
						text: '优 惠 券',
						isActive: false,
						id: '/discountGoods3'
					},
				]
				//侧边导航栏 end
			}
		},
		methods: {
			//顶部导航栏高亮显示 begin
			activeFun: function(data) {
				this.navList.forEach(function(obj) {
					obj.isActive = false;
				});
				data.isActive = !data.isActive;
			},
			activeFunb: function(data) {
				this.navList2.forEach(function(obj) {
					obj.isActive = false;
				});
				data.isActive = !data.isActive;
			},
			activeFunc: function(data) {
				this.navList3.forEach(function(obj) {
					obj.isActive = false;
				});
				data.isActive = !data.isActive;
			},
			activeFune: function(data) {
				this.navList5.forEach(function(obj) {
					obj.isActive = false;
				});
				data.isActive = !data.isActive;
			},
			activeFunf: function(data) {
				this.navList6.forEach(function(obj) {
					obj.isActive = false;
				});
				data.isActive = !data.isActive;
			},
			//顶部导航栏高亮显示 end

			//侧边导航栏高亮显示 begin
			showFun: function(data) {
				this.nLeft.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft2.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft3.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft4.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft5.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft6.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft7.forEach(function(obj) {
					obj.isActive = false;
				});
				data.isActive = !data.isActive;
			},
			showFuna: function(data) {
				this.nLeft.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft2.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft3.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft4.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft5.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft6.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft7.forEach(function(obj) {
					obj.isActive = false;
				});
				data.isActive = !data.isActive;
			},
			showFunb: function(data) {
				this.nLeft.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft2.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft3.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft4.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft5.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft6.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft7.forEach(function(obj) {
					obj.isActive = false;
				});
				data.isActive = !data.isActive;
			},
			showFunc: function(data) {
				this.nLeft.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft2.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft3.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft4.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft5.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft6.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft7.forEach(function(obj) {
					obj.isActive = false;
				});
				data.isActive = !data.isActive;
			},
			showFund: function(data) {
				this.nLeft.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft2.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft3.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft4.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft5.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft6.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft7.forEach(function(obj) {
					obj.isActive = false;
				});
				data.isActive = !data.isActive;
			},
			showFune: function(data) {
				this.nLeft.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft2.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft3.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft4.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft5.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft6.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft7.forEach(function(obj) {
					obj.isActive = false;
				});
				data.isActive = !data.isActive;
			},
			showFunf: function(data) {
				this.nLeft.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft2.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft3.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft4.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft5.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft6.forEach(function(obj) {
					obj.isActive = false;
				});
				this.nLeft7.forEach(function(obj) {
					obj.isActive = false;
				});
				data.isActive = !data.isActive;
			}
			//侧边导航栏高亮显示 end
		},
		mounted() {
			//头部导航悬停显示下拉导航菜单
			$(function() {
				$("#nav_bulb li").hover(function() {
					$(this).addClass('nav_blis').siblings('li').removeClass('nav_blis');
					var index = $(this).index();
					$('.n_bl_menu').eq(index).addClass('selected').siblings('div').removeClass('selected');
				})
				//顶部导航悬停显示下拉导航菜单
				$("#shortcut-2013 .menu").mousemove(function(){
					$(this).addClass('hover').siblings('li').removeClass('hover');
				})
				$("#shortcut-2013 .menu").mouseout(function(){
					$(this).removeClass('hover')
				})
			});
		}
	}
</script>
<style>

</style>