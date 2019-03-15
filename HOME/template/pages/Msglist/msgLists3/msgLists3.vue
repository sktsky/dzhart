	<!-- 收件箱 -->
<template>
	<div>
		<div class="msg_s_link">
			<select id="selectReadState" class="msg_s_psel fl mt10">
				<option value="-1" selected="selected">全部</option>
				<option value="0">未读</option>
				<option value="1">已读</option>
			</select>
			<el-tabs v-model="activeName" @tab-click="handleClick">
				<el-tab-pane label="全部消息" name="first">
					<div class="msg_cz_box">
						<div class="msg_cz_bc">
							<span class="msg_img msg_cz_sel item_all_ckbox"></span>
							<span class="msg_img msg_cz_del ml15" onclick="DelMsgs(1)"></span>
							<span class="msg_img msg_cz_qb ml15" onclick="showDiv()"></span>
							<span style="display:none;" class="msg_img msg_cz_bj ml15 mark2"></span>
							<input name="But_sx" value="" id="But_sx" class="msg_img msg_cz_sx ml15" type="submit">

							<span class="msg_cz_page" style="width:360px;">
			
			                    </span>
						</div>

						<h3 class="msg_tc_h3">更早</h3>
						<ul class="msg_tc_ul">
							<li class="msg_tc_li" onmouseover="this.style.backgroundColor = '#f7f7f7'" onmouseout="this.style.backgroundColor = ''" v-for="msg in msglist" :key="msg.id">
								<input class="item_today ml10" name="chkitem" type="checkbox" value='2407837' />
								<input class="lblFrom" type="hidden" value='2407837|管理员16' />
								<span class='msg_img msg_tc_xf ml15'></span>
								<a class="msg_tc_name ml20" href='#' target="_blank">{{msg.name}}</a>
								<span class='msg_img msg_tc_bj_no ml15' onclick='showMark(2407837,this,1)' markdata='0'></span>

								<a class="msg_tc_con ml20" onclick='showreadmsgId(2407837)' href='#'>{{msg.describe}}</a>
								<span class="msg_tc_time ml40">{{msg.time}}</span>
							</li>

						</ul>

						<div class="msg_tc_page">

						</div>
					</div>
				</el-tab-pane>
				<el-tab-pane label="订单消息" name="second">
					<div class="msg_cz_box">
						<div class="msg_cz_bc">
							<span class="msg_img msg_cz_sel item_all_ckbox"></span>
							<span class="msg_img msg_cz_del ml15" onclick="DelMsgs(1)"></span>
							<span class="msg_img msg_cz_qb ml15" onclick="showDiv()"></span>
							<span style="display:none;" class="msg_img msg_cz_bj ml15 mark2"></span>
							<input name="But_sx" value="" id="But_sx" class="msg_img msg_cz_sx ml15" type="submit">

							<span class="msg_cz_page" style="width:360px;">
			
			                    </span>
						</div>

						<h3 class="msg_tc_h3">更早</h3>
						<ul class="msg_tc_ul">
							<li class="msg_tc_li" onmouseover="this.style.backgroundColor = '#f7f7f7'" onmouseout="this.style.backgroundColor = ''" v-for="msg in msglist1" :key="msg.id">
								<input class="item_today ml10" name="chkitem" type="checkbox" value='2407837' />
								<input class="lblFrom" type="hidden" value='2407837|管理员16' />
								<span class='msg_img msg_tc_xf ml15'></span>
								<a class="msg_tc_name ml20" href='#' target="_blank">{{msg.name}}</a>
								<span class='msg_img msg_tc_bj_no ml15' onclick='showMark(2407837,this,1)' markdata='0'></span>

								<a class="msg_tc_con ml20" onclick='showreadmsgId(2407837)' href='#'>{{msg.describe}}</a>
								<span class="msg_tc_time ml40">{{msg.time}}</span>
							</li>

						</ul>

						<div class="msg_tc_page">

						</div>
					</div>
				</el-tab-pane>
				<el-tab-pane label="拍卖消息" name="third">
					<div class="msg_cz_box">
						<div class="msg_cz_bc">
							<span class="msg_img msg_cz_sel item_all_ckbox"></span>
							<span class="msg_img msg_cz_del ml15" onclick="DelMsgs(1)"></span>
							<span class="msg_img msg_cz_qb ml15" onclick="showDiv()"></span>
							<span style="display:none;" class="msg_img msg_cz_bj ml15 mark2"></span>
							<input name="But_sx" value="" id="But_sx" class="msg_img msg_cz_sx ml15" type="submit">

							<span class="msg_cz_page" style="width:360px;">
			
			                    </span>
						</div>

						<h3 class="msg_tc_h3">更早</h3>
						<ul class="msg_tc_ul">
							<li class="msg_tc_li" onmouseover="this.style.backgroundColor = '#f7f7f7'" onmouseout="this.style.backgroundColor = ''" v-for="msg in msglist2" :key="msg.id">
								<input class="item_today ml10" name="chkitem" type="checkbox" value='2407837' />
								<input class="lblFrom" type="hidden" value='2407837|管理员16' />
								<span class='msg_img msg_tc_xf ml15'></span>
								<a class="msg_tc_name ml20" href='#' target="_blank">{{msg.name}}</a>
								<span class='msg_img msg_tc_bj_no ml15' onclick='showMark(2407837,this,1)' markdata='0'></span>

								<a class="msg_tc_con ml20" onclick='showreadmsgId(2407837)' href='#'>{{msg.describe}}</a>
								<span class="msg_tc_time ml40">{{msg.time}}</span>
							</li>

						</ul>

						<div class="msg_tc_page">

						</div>
					</div>
				</el-tab-pane>
				<el-tab-pane label="系统消息" name="fourth">
					<div class="msg_cz_box">
						<div class="msg_cz_bc">
							<span class="msg_img msg_cz_sel item_all_ckbox"></span>
							<span class="msg_img msg_cz_del ml15" onclick="DelMsgs(1)"></span>
							<span class="msg_img msg_cz_qb ml15" onclick="showDiv()"></span>
							<span style="display:none;" class="msg_img msg_cz_bj ml15 mark2"></span>
							<input name="But_sx" value="" id="But_sx" class="msg_img msg_cz_sx ml15" type="submit">

							<span class="msg_cz_page" style="width:360px;">
			
			                    </span>
						</div>

						<h3 class="msg_tc_h3">更早</h3>
						<ul class="msg_tc_ul">
							<li class="msg_tc_li" onmouseover="this.style.backgroundColor = '#f7f7f7'" onmouseout="this.style.backgroundColor = ''" v-for="msg in msglist3" :key="msg.id">
								<input class="item_today ml10" name="chkitem" type="checkbox" value='2407837' />
								<input class="lblFrom" type="hidden" value='2407837|管理员16' />
								<span class='msg_img msg_tc_xf ml15'></span>
								<a class="msg_tc_name ml20" href='#' target="_blank">{{msg.name}}</a>
								<span class='msg_img msg_tc_bj_no ml15' onclick='showMark(2407837,this,1)' markdata='0'></span>

								<a class="msg_tc_con ml20" onclick='showreadmsgId(2407837)' href='msgRead.aspx?msgUrl=1&msgId=2407837'>{{msg.describe}}</a>
								<span class="msg_tc_time ml40">{{msg.time}}</span>
							</li>

						</ul>

						<div class="msg_tc_page">

						</div>
					</div>
				</el-tab-pane>
				<el-tab-pane label="订单消息" name="fifth">
					<div class="msg_cz_box">
						<div class="msg_cz_bc">
							<span class="msg_img msg_cz_sel item_all_ckbox"></span>
							<span class="msg_img msg_cz_del ml15" onclick="DelMsgs(1)"></span>
							<span class="msg_img msg_cz_qb ml15" onclick="showDiv()"></span>
							<span style="display:none;" class="msg_img msg_cz_bj ml15 mark2"></span>
							<input name="But_sx" value="" id="But_sx" class="msg_img msg_cz_sx ml15" type="submit">

							<span class="msg_cz_page" style="width:360px;">
			
			                    </span>
						</div>

						<h3 class="msg_tc_h3">更早</h3>
						<ul class="msg_tc_ul">
							<li class="msg_tc_li" onmouseover="this.style.backgroundColor = '#f7f7f7'" onmouseout="this.style.backgroundColor = ''" v-for="msg in msglist4" :key="msg.id">
								<input class="item_today ml10" name="chkitem" type="checkbox" value='2407837' />
								<input class="lblFrom" type="hidden" value='2407837|管理员16' />
								<span class='msg_img msg_tc_xf ml15'></span>
								<a class="msg_tc_name ml20" href='#' target="_blank">{{msg.name}}</a>
								<span class='msg_img msg_tc_bj_no ml15' onclick='showMark(2407837,this,1)' markdata='0'></span>

								<a class="msg_tc_con ml20" onclick='showreadmsgId(2407837)' href='msgRead.aspx?msgUrl=1&msgId=2407837'>{{msg.describe}}</a>
								<span class="msg_tc_time ml40">{{msg.time}}</span>
							</li>

						</ul>

						<div class="msg_tc_page">

						</div>
					</div>
				</el-tab-pane>
				<el-tab-pane label="拍卖消息" name="sixth">
					<div class="msg_cz_box">
						<div class="msg_cz_bc">
							<span class="msg_img msg_cz_sel item_all_ckbox"></span>
							<span class="msg_img msg_cz_del ml15" onclick="DelMsgs(1)"></span>
							<span class="msg_img msg_cz_qb ml15" onclick="showDiv()"></span>
							<span style="display:none;" class="msg_img msg_cz_bj ml15 mark2"></span>
							<input name="But_sx" value="" id="But_sx" class="msg_img msg_cz_sx ml15" type="submit">

							<span class="msg_cz_page" style="width:360px;">
			
			                    </span>
						</div>

						<h3 class="msg_tc_h3">更早</h3>
						<ul class="msg_tc_ul">
							<li class="msg_tc_li" onmouseover="this.style.backgroundColor = '#f7f7f7'" onmouseout="this.style.backgroundColor = ''" v-for="msg in msglist5" :key="msg.id">
								<input class="item_today ml10" name="chkitem" type="checkbox" value='2407837' />
								<input class="lblFrom" type="hidden" value='2407837|管理员16' />
								<span class='msg_img msg_tc_xf ml15'></span>
								<a class="msg_tc_name ml20" href='#' target="_blank">{{msg.name}}</a>
								<span class='msg_img msg_tc_bj_no ml15' onclick='showMark(2407837,this,1)' markdata='0'></span>

								<a class="msg_tc_con ml20" onclick='showreadmsgId(2407837)' href='#'>{{msg.describe}}</a>
								<span class="msg_tc_time ml40">{{msg.time}}</span>
							</li>

						</ul>

						<div class="msg_tc_page">

						</div>
					</div>
				</el-tab-pane>
				<el-tab-pane label="系统消息" name="seventh">
					<div class="msg_cz_box">
						<div class="msg_cz_bc">
							<span class="msg_img msg_cz_sel item_all_ckbox"></span>
							<span class="msg_img msg_cz_del ml15" onclick="DelMsgs(1)"></span>
							<span class="msg_img msg_cz_qb ml15" onclick="showDiv()"></span>
							<span style="display:none;" class="msg_img msg_cz_bj ml15 mark2"></span>
							<input name="But_sx" value="" id="But_sx" class="msg_img msg_cz_sx ml15" type="submit">

							<span class="msg_cz_page" style="width:360px;">
			
			                    </span>
						</div>

						<h3 class="msg_tc_h3">更早</h3>
						<ul class="msg_tc_ul">
							<li class="msg_tc_li" onmouseover="this.style.backgroundColor = '#f7f7f7'" onmouseout="this.style.backgroundColor = ''" v-for="msg in msglist6" :key="msg.id">
								<input class="item_today ml10" name="chkitem" type="checkbox" value='2407837' />
								<input class="lblFrom" type="hidden" value='2407837|管理员16' />
								<span class='msg_img msg_tc_xf ml15'></span>
								<a class="msg_tc_name ml20" href='#' target="_blank">{{msg.name}}</a>
								<span class='msg_img msg_tc_bj_no ml15' onclick='showMark(2407837,this,1)' markdata='0'></span>

								<a class="msg_tc_con ml20" onclick='showreadmsgId(2407837)' href='#'>{{msg.describe}}</a>
								<span class="msg_tc_time ml40">{{msg.time}}</span>
							</li>

						</ul>

						<div class="msg_tc_page">

						</div>
					</div>
				</el-tab-pane>
			</el-tabs>
		</div>

	</div>
</template>

<script>
	import '~/assets/css/msg.css'
	import '~/assets/css/Custom(2).css'
	import '~/assets/css/jystyle.css'
	import { getData } from '~/plugins/axios.js'
	export default {
		data() {
			return {
				activeName: 'sixth',
				msglist: [],
				msglist1: [],
				msglist2: [],
				msglist3: [],
				msglist4: [],
				msglist5: [],
				msglist6: []
			};
		},
		methods: {
			handleClick(tab, event) {
				console.log(tab, event);
			}
		},
		created: function() {
			//站内短信-全部消息
			getData('mock/5bfdf9117baf9b6a9fa6e80e/msgLists/msglist', 'get').then(res => {
				this.msglist = res.data.msglist
			}), err => {
				console.log(err)
			}
			//站内短信-订单消息
			getData('mock/5bfdf9117baf9b6a9fa6e80e/msgLists/msglist1', 'get').then(res => {
				this.msglist1 = res.data.msglist1
			}), err => {
				console.log(err)
			}
			//站内短信-拍卖消息
			getData('mock/5bfdf9117baf9b6a9fa6e80e/msgLists/msglist2', 'get').then(res => {
				this.msglist2 = res.data.msglist2
			}), err => {
				console.log(err)
			}
			//站内短信-系统消息
			getData('mock/5bfdf9117baf9b6a9fa6e80e/msgLists/msglist3', 'get').then(res => {
				this.msglist3 = res.data.msglist3
			}), err => {
				console.log(err)
			}
			//站内短信-用户消息
			getData('mock/5bfdf9117baf9b6a9fa6e80e/msgLists/msglist4', 'get').then(res => {
				this.msglist4 = res.data.msglist4
			}), err => {
				console.log(err)
			}
			//站内短信-标识短信
			getData('mock/5bfdf9117baf9b6a9fa6e80e/msgLists/msglist5', 'get').then(res => {
				this.msglist5 = res.data.msglist5
			}), err => {
				console.log(err)
			}
			//站内短信-垃圾短信
			getData('mock/5bfdf9117baf9b6a9fa6e80e/msgLists/msglist6', 'get').then(res => {
				this.msglist6 = res.data.msglist6
			}), err => {
				console.log(err)
			}
		}
	}
</script>

<style>

</style>