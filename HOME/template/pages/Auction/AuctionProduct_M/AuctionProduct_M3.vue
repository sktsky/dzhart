<!-- 我的报价 -->
<template id="AuctionProduct_M3">
	<div>
		<div class="pai_s_link">
			<el-tabs v-model="activeName" @tab-click="handleClick">
				<el-tab-pane label="全部报价" name="first">
					<div class="pai_cz_box">
						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,3)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">第<span>1</span>页</div>
							</div>
						</div>

						<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
							<tbody>
								<tr class="bg">
									<th style="width:140px;background-color:#FFF;">图片</th>
									<th style="background-color:#FFF;">报价内容/价格</th>
									<th style="width:160px;background-color:#FFF;">报价时间</th>
								</tr>
								<tr v-for="msg in mlist" :key="msg.index">

									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<a href="http://www.cang.com/auction/974814.html" target="_blank"><img :src="msg.pic" class="Img100" /></a>
									</td>
									<td class="pai_td_con" align="center" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.content}}</a><br/> 价格：
											<span class="colf0">{{msg.pice}}</span><br />
										</P>

									</td>
									<td class="pai_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
										{{msg.time}}
									</td>

								</tr>
							</tbody>
						</table>

						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,3)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">第<span>1</span>页</div>
							</div>
						</div>
					</div>
				</el-tab-pane>
				<el-tab-pane label="胜出" name="second">
					<div class="pai_cz_box">
						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,3)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">第<span>1</span>页</div>
							</div>
						</div>

						<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
							<tbody>
								<tr class="bg">
									<th style="width:140px;background-color:#FFF;">图片</th>
									<th style="background-color:#FFF;">拍品编号/名称/时间</th>
									<th style="width:120px;background-color:#FFF;">价格</th>
									<th style="width:160px;background-color:#FFF;">状态/报价/操作</th>
								</tr>
								<tr v-for="msg in mlist1" :key="msg.index">

									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<a href="http://www.cang.com/auction/974814.html" target="_blank"><img :src="msg.pic" class="Img100" /></a>
									</td>
									<td class="pai_td_con" align="center" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.number}}</a><br/>
											<span class="colf0">{{msg.name}}</span><br /><span class="colf0">{{msg.time}}</span><br />
										</p>
									</td>
									<td class="pai_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
										{{msg.pice}}
									</td>
									<td class="pai_td_con" align="center" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.state}}</a><br/>
											<span class="colf0">{{msg.bite}}</span><br /><span class="colf0">{{msg.operation}}</span><br />
										</p>
									</td>

								</tr>
							</tbody>
						</table>

						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,3)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">第<span>1</span>页</div>
							</div>
						</div>
					</div>
				</el-tab-pane>
				<el-tab-pane label="领先" name="third">
					<div class="pai_cz_box">
						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,3)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">第<span>1</span>页</div>
							</div>
						</div>

						<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
							<tbody>
								<tr class="bg">
									<th style="width:140px;background-color:#FFF;">图片</th>
									<th style="background-color:#FFF;">拍品编号/名称/时间</th>
									<th style="width:120px;background-color:#FFF;">价格</th>
									<th style="width:160px;background-color:#FFF;">状态/报价/操作</th>
								</tr>
								<tr v-for="msg in mlist2" :key="msg.index">

									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<a href="http://www.cang.com/auction/974814.html" target="_blank"><img :src="msg.pic" class="Img100" /></a>
									</td>
									<td class="pai_td_con" align="center" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.number}}</a><br/>
											<span class="colf0">{{msg.name}}</span><br /><span class="colf0">{{msg.time}}</span><br />
										</p>
									</td>
									<td class="pai_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
										{{msg.pice}}
									</td>
									<td class="pai_td_con" align="center" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.state}}</a><br/>
											<span class="colf0">{{msg.bite}}</span><br /><span class="colf0">{{msg.operation}}</span><br />
										</p>
									</td>

								</tr>
							</tbody>
						</table>

						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,3)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">第<span>1</span>页</div>
							</div>
						</div>
					</div>
				</el-tab-pane>
				<el-tab-pane label="落后" name="fourth">
					<div class="pai_cz_box">
						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,3)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">第<span>1</span>页</div>
							</div>
						</div>

						<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
							<tbody>
								<tr class="bg">
									<th style="width:140px;background-color:#FFF;">图片</th>
									<th style="background-color:#FFF;">拍品编号/名称/时间</th>
									<th style="width:120px;background-color:#FFF;">价格</th>
									<th style="width:160px;background-color:#FFF;">状态/报价/操作</th>
								</tr>
								<tr v-for="msg in mlist3" :key="msg.index">

									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<a href="http://www.cang.com/auction/974814.html" target="_blank"><img :src="msg.pic" class="Img100" /></a>
									</td>
									<td class="pai_td_con" align="center" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.number}}</a><br/>
											<span class="colf0">{{msg.name}}</span><br /><span class="colf0">{{msg.time}}</span><br />
										</p>
									</td>
									<td class="pai_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
										{{msg.pice}}
									</td>
									<td class="pai_td_con" align="center" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.state}}</a><br/>
											<span class="colf0">{{msg.bite}}</span><br /><span class="colf0">{{msg.operation}}</span><br />
										</p>
									</td>

								</tr>
							</tbody>
						</table>

						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,3)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">第<span>1</span>页</div>
							</div>
						</div>
					</div>
				</el-tab-pane>
				<el-tab-pane label="结拍" name="fifth">
					<div class="pai_cz_box">
						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,3)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">第<span>1</span>页</div>
							</div>
						</div>

						<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
							<tbody>
								<tr class="bg">
									<th style="width:140px;background-color:#FFF;">图片</th>
									<th style="background-color:#FFF;">拍品编号/名称/时间</th>
									<th style="width:120px;background-color:#FFF;">价格</th>
									<th style="width:160px;background-color:#FFF;">状态/报价/操作</th>
								</tr>
								<tr v-for="msg in mlist4" :key="msg.index">

									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<a href="http://www.cang.com/auction/974814.html" target="_blank"><img :src="msg.pic" class="Img100" /></a>
									</td>
									<td class="pai_td_con" align="center" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.number}}</a><br/>
											<span class="colf0">{{msg.name}}</span><br /><span class="colf0">{{msg.time}}</span><br />
										</p>
									</td>
									<td class="pai_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
										{{msg.pice}}
									</td>
									<td class="pai_td_con" align="center" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.state}}</a><br/>
											<span class="colf0">{{msg.bite}}</span><br /><span class="colf0">{{msg.operation}}</span><br />
										</P>
									</td>

								</tr>
							</tbody>
						</table>

						<div class="pai_pt_box" style="display:none;">
							<div class="pai_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,3)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">第<span>1</span>页</div>
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
	import LotApi from '~/api/auctionproduct'
	export default {
		data() {
			return {
				mlist: [],
				mlist1: [],
				mlist2: [],
				mlist3: [],
				mlist4: [],
				activeName: 'first'
			}
		},
		methods: {
			handleClick(tab, event) {

			}
		},
		created: function() {
			var self = this;
			LotApi.offer().then(function(res) {
				self.mlist = res.data.list
				//胜出
				LotApi.beat().then(function(res) {
					self.mlist1 = res.data.list

				})
				//领先
				LotApi.Lead().then(function(res) {
					self.mlist2 = res.data.list

				})
				//落后
				LotApi.backward().then(function(res) {
					self.mlist3 = res.data.list

				})
				//结拍
				LotApi.tiepat().then(function(res) {
					self.mlist4 = res.data.list

				})
			})
		}
	}
</script>

<style>

</style>