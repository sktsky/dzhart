<!-- 我的代理价 -->
<template id="AuctionProduct_M5">
	<div>
		<div class="pai_s_link">
			<el-tabs v-model="activeName" @tab-click="handleClick">
				<el-tab-pane label="全部代理价(0)" name="first">
					<div class="pai_cz_box">
						<input id="HidFlag" type="hidden" value="-1">
						<input id="zpage" type="hidden" value="0">
						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" type="text" value="1" data="1">页
									<input class="p_input_go" type="button" value="GO" onclick="gopage(this,1)">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>

						<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
							<tbody>
								<tr class="bg">
									<th style="width:140px;background-color:#FFF;">图片</th>
									<th style="background-color:#FFF;">拍品信息</th>
									<th style="width:140px;background-color:#FFF;">价格</th>
									<th style="width:250px;background-color:#FFF;">状态/报价</th>
									<th style="width:120px;background-color:#FFF;">操作</th>
								</tr>
								<tr v-for="msg in agentlist" :key="msg.index">
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<a href="http://www.cang.com/auction/974814.html" target="_blank"><img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.name}}</a><br/> 编 号：{{msg.number}}类 别：<span class="colf0">{{msg.type}}</span><br /> 时间：
											<span class="red">{{msg.time}}</span><br /></p>

										<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
											<p>
												价格：<span class="red">{{msg.price}}</span>
											</p>
										</td>
										<td class="pai_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
											<p>
												报价：<span class="red">{{msg.sale}} </span><br />状态：<span class="red">{{msg.state}}</span><br />
											</p>
										</td>
										<td class="pai_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
											<p>
												<a href='AuctionProduct_M.aspx?prodid=974814' class='blue'>{{msg.operation1}}</a><br/>

												<a href='javascript:void(0);' id='anonymous_974814' class='blue btn_anonymous'>{{msg.operation2}}</a><br/>

												<a href='javascript:void(0)' class="blue btn_tg" rowdata='974814'>{{msg.operation3}}</a><br/>

											</p>
										</td>
								</tr>
							</tbody>
						</table>

						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" type="text" value="1" data="1">页
									<input class="p_input_go" type="button" value="GO" onclick="gopage(this,1)">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>
					</div>
				</el-tab-pane>
				<el-tab-pane label="正在代理" name="second">
					<div class="pai_cz_box">
						<input id="HidFlag" type="hidden" value="-1">
						<input id="zpage" type="hidden" value="0">
						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" type="text" value="1" data="1">页
									<input class="p_input_go" type="button" value="GO" onclick="gopage(this,1)">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>

						<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
							<tbody>
								<tr class="bg">
									<th style="width:140px;background-color:#FFF;">图片</th>
									<th style="background-color:#FFF;">拍品信息</th>
									<th style="width:140px;background-color:#FFF;">价格</th>
									<th style="width:250px;background-color:#FFF;">状态/报价</th>
									<th style="width:120px;background-color:#FFF;">操作</th>
								</tr>
								<tr v-for="msg in agentlist1" :key="msg.index">
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<a href="http://www.cang.com/auction/974814.html" target="_blank"><img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.name}}</a><br/> 编 号：{{msg.number}}类 别：<span class="colf0">{{msg.type}}</span><br /> 时间：
											<span class="red">{{msg.time}}</span><br /></p>

										<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
											<p>
												价格：<span class="red">{{msg.price}}</span>
											</p>
										</td>
										<td class="pai_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
											<p>
												报价：<span class="red">{{msg.sale}} </span><br />状态：<span class="red">{{msg.state}}</span><br />
											</p>
										</td>
										<td class="pai_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
											<p>
												<a href='AuctionProduct_M.aspx?prodid=974814' class='blue'>{{msg.operation1}}</a><br/>

												<a href='javascript:void(0);' id='anonymous_974814' class='blue btn_anonymous'>{{msg.operation2}}</a><br/>

												<a href='javascript:void(0)' class="blue btn_tg" rowdata='974814'>{{msg.operation3}}</a><br/>

											</p>
										</td>
								</tr>
							</tbody>
						</table>

						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" type="text" value="1" data="1">页
									<input class="p_input_go" type="button" value="GO" onclick="gopage(this,1)">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>
					</div>
				</el-tab-pane>
				<el-tab-pane label="过期代理" name="third">
					<div class="pai_cz_box">
						<input id="HidFlag" type="hidden" value="-1">
						<input id="zpage" type="hidden" value="0">
						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" type="text" value="1" data="1">页
									<input class="p_input_go" type="button" value="GO" onclick="gopage(this,1)">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>

						<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
							<tbody>
								<tr class="bg">
									<th style="width:140px;background-color:#FFF;">图片</th>
									<th style="background-color:#FFF;">拍品信息</th>
									<th style="width:140px;background-color:#FFF;">价格</th>
									<th style="width:250px;background-color:#FFF;">状态/报价</th>
									<th style="width:120px;background-color:#FFF;">操作</th>
								</tr>
								<tr v-for="msg in agentlist2" :key="msg.index">
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<a href="http://www.cang.com/auction/974814.html" target="_blank"><img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.name}}</a><br/> 编 号：{{msg.number}}类 别：<span class="colf0">{{msg.type}}</span><br /> 时间：
											<span class="red">{{msg.time}}</span><br /></p>

										<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
											<p>
												价格：<span class="red">{{msg.price}}</span>
											</p>
										</td>
										<td class="pai_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
											<p>
												报价：<span class="red">{{msg.sale}} </span><br />状态：<span class="red">{{msg.state}}</span><br />
											</p>
										</td>
										<td class="pai_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
											<p>
												<a href='AuctionProduct_M.aspx?prodid=974814' class='blue'>{{msg.operation1}}</a><br/>

												<a href='javascript:void(0);' id='anonymous_974814' class='blue btn_anonymous'>{{msg.operation2}}</a><br/>

												<a href='javascript:void(0)' class="blue btn_tg" rowdata='974814'>{{msg.operation3}}</a><br/>

											</p>
										</td>
								</tr>
							</tbody>
						</table>

						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" type="text" value="1" data="1">页
									<input class="p_input_go" type="button" value="GO" onclick="gopage(this,1)">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>
					</div>
				</el-tab-pane>
				<el-tab-pane label="未结拍" name="fourth">
					<div class="pai_cz_box">
						<input id="HidFlag" type="hidden" value="-1">
						<input id="zpage" type="hidden" value="0">
						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" type="text" value="1" data="1">页
									<input class="p_input_go" type="button" value="GO" onclick="gopage(this,1)">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>

						<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
							<tbody>
								<tr class="bg">
									<th style="width:140px;background-color:#FFF;">图片</th>
									<th style="background-color:#FFF;">拍品信息</th>
									<th style="width:140px;background-color:#FFF;">价格</th>
									<th style="width:250px;background-color:#FFF;">状态/报价</th>
									<th style="width:120px;background-color:#FFF;">操作</th>
								</tr>
								<tr v-for="msg in agentlist3" :key="msg.index">
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<a href="http://www.cang.com/auction/974814.html" target="_blank"><img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.name}}</a><br/> 编 号：{{msg.number}}类 别：<span class="colf0">{{msg.type}}</span><br /> 时间：
											<span class="red">{{msg.time}}</span><br /></p>

										<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
											<p>
												价格：<span class="red">{{msg.price}}</span>
											</p>
										</td>
										<td class="pai_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
											<p>
												报价：<span class="red">{{msg.sale}} </span><br />状态：<span class="red">{{msg.state}}</span><br />
											</p>
										</td>
										<td class="pai_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
											<p>
												<a href='AuctionProduct_M.aspx?prodid=974814' class='blue'>{{msg.operation1}}</a><br/>

												<a href='javascript:void(0);' id='anonymous_974814' class='blue btn_anonymous'>{{msg.operation2}}</a><br/>

												<a href='javascript:void(0)' class="blue btn_tg" rowdata='974814'>{{msg.operation3}}</a><br/>

											</p>
										</td>
								</tr>
							</tbody>
						</table>

						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" type="text" value="1" data="1">页
									<input class="p_input_go" type="button" value="GO" onclick="gopage(this,1)">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>
					</div>
				</el-tab-pane>
				<el-tab-pane label="已结拍" name="fifth">
					<div class="pai_cz_box">
						<input id="HidFlag" type="hidden" value="-1">
						<input id="zpage" type="hidden" value="0">
						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" type="text" value="1" data="1">页
									<input class="p_input_go" type="button" value="GO" onclick="gopage(this,1)">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>

						<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
							<tbody>
								<tr class="bg">
									<th style="width:140px;background-color:#FFF;">图片</th>
									<th style="background-color:#FFF;">拍品信息</th>
									<th style="width:140px;background-color:#FFF;">价格</th>
									<th style="width:250px;background-color:#FFF;">状态/报价</th>
									<th style="width:120px;background-color:#FFF;">操作</th>
								</tr>
								<tr v-for="msg in agentlist4" :key="msg.index">
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<a href="http://www.cang.com/auction/974814.html" target="_blank"><img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.name}}</a><br/> 编 号：{{msg.number}}类 别：<span class="colf0">{{msg.type}}</span><br /> 时间：
											<span class="red">{{msg.time}}</span><br /></p>

										<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
											<p>
												价格：<span class="red">{{msg.price}}</span>
											</p>
										</td>
										<td class="pai_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
											<p>
												报价：<span class="red">{{msg.sale}} </span><br />状态：<span class="red">{{msg.state}}</span><br />
											</p>
										</td>
										<td class="pai_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
											<p>
												<a href='AuctionProduct_M.aspx?prodid=974814' class='blue'>{{msg.operation1}}</a><br/>

												<a href='javascript:void(0);' id='anonymous_974814' class='blue btn_anonymous'>{{msg.operation2}}</a><br/>

												<a href='javascript:void(0)' class="blue btn_tg" rowdata='974814'>{{msg.operation3}}</a><br/>

											</p>
										</td>
								</tr>
							</tbody>
						</table>

						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" type="text" value="1" data="1">页
									<input class="p_input_go" type="button" value="GO" onclick="gopage(this,1)">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>
					</div>
				</el-tab-pane>
			</el-tabs>
		</div>

	</div>
</template>

<script>
	import '~/assets/css/paimai.css'
	import agentApi from '~/api/auctionproduct'
	export default {
		data() {
			return {
				activeName: 'first',
				agentlist: [],
				agentlist1: [],
				agentlist2: [],
				agentlist3: [],
				agentlist4: []
			};
		},
		methods: {
			handleClick(tab, event) {

			}
		},
		created: function() {
			var self = this;
			agentApi.agent().then(function(res) {
				self.agentlist = res.data.list
				//正在代理
				agentApi.Being().then(function(res) {
					self.agentlist1 = res.data.list
				})
				//过期代理
				agentApi.overdue().then(function(res) {
					self.agentlist2 = res.data.list
				})
				//未结拍
				agentApi.Unfilming().then(function(res) {
					self.agentlist3 = res.data.list
				})
				//已结拍
				agentApi.Patted().then(function(res) {
					self.agentlist4 = res.data.list
				}, function() {
					console.log('失败')
				})
			})
		}
	}
</script>

<style>

</style>