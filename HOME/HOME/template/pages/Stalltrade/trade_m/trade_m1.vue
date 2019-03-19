<!-- 所有地摊 -->
<template id="trade_m1">
	<div class="td_s_link">
		<el-tabs v-model="activeName" @tab-click="handleClick">
			<el-tab-pane label="待售藏品" name="first">

				<div class="jd_cz_box">

					<div class="jd_m_menu">
						<el-tabs v-model="activeName1" @tab-click="handleClick2">
							<el-tab-pane label="全部" name="first">
								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>

										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="瓷器" name="second">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist1" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="玉器" name="third">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist2" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="字画" name="fourth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist3" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="钱币" name="fifth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist4" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="木器" name="sixth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist5" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="铜器" name="seventh">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist6" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="珠宝" name="eighth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist7" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="钟表西洋器" name="ninth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist8" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="杂项" name="tenth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist9" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="工艺品" name="leventh">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist10" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="衍生品" name="twelfth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist11" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
						</el-tabs>

						<div class="jd_m_mbor"></div>
					</div>

					<div class="jd_tc_page">
					</div>
				</div>

			</el-tab-pane>
			<el-tab-pane label="已售地摊" name="second">

				<div class="jd_cz_box">

					<div class="jd_m_menu">
						<el-tabs v-model="activeName2" @tab-click="handleClick2">
							<el-tab-pane label="全部" name="first">
								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>

										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="瓷器" name="second">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist1" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="玉器" name="third">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist2" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="字画" name="fourth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist3" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="钱币" name="fifth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist4" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="木器" name="sixth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist5" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="铜器" name="seventh">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist6" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="珠宝" name="eighth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist7" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="钟表西洋器" name="ninth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist8" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="杂项" name="tenth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist9" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="工艺品" name="leventh">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist10" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="衍生品" name="twelfth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist11" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
						</el-tabs>

						<div class="jd_m_mbor"></div>
					</div>

					<div class="jd_tc_page">
					</div>
				</div>

			</el-tab-pane>
			<el-tab-pane label="未审地摊" name="third">

				<div class="jd_cz_box">

					<div class="jd_m_menu">
						<el-tabs v-model="activeName3" @tab-click="handleClick2">
							<el-tab-pane label="全部" name="first">
								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>

										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="瓷器" name="second">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist1" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="玉器" name="third">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist2" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="字画" name="fourth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist3" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="钱币" name="fifth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist4" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="木器" name="sixth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist5" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="铜器" name="seventh">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist6" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="珠宝" name="eighth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist7" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="钟表西洋器" name="ninth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist8" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="杂项" name="tenth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist9" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="工艺品" name="leventh">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist10" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="衍生品" name="twelfth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist11" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
						</el-tabs>

						<div class="jd_m_mbor"></div>
					</div>

					<div class="jd_tc_page">
					</div>
				</div>

			</el-tab-pane>
			<el-tab-pane label="上架地摊" name="fourth">

				<div class="jd_cz_box">

					<div class="jd_m_menu">
						<el-tabs v-model="activeName4" @tab-click="handleClick2">
							<el-tab-pane label="全部" name="first">
								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>

										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="瓷器" name="second">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist1" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="玉器" name="third">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist2" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="字画" name="fourth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist3" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="钱币" name="fifth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist4" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="木器" name="sixth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist5" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="铜器" name="seventh">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist6" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="珠宝" name="eighth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist7" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="钟表西洋器" name="ninth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist8" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="杂项" name="tenth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist9" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="工艺品" name="leventh">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist10" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="衍生品" name="twelfth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist11" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
						</el-tabs>

						<div class="jd_m_mbor"></div>
					</div>

					<div class="jd_tc_page">
					</div>
				</div>

			</el-tab-pane>
			<el-tab-pane label="下架地摊" name="fifth">

				<div class="jd_cz_box">

					<div class="jd_m_menu">
						<el-tabs v-model="activeName5" @tab-click="handleClick2">
							<el-tab-pane label="全部" name="first">
								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>

										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="瓷器" name="second">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist1" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="玉器" name="third">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist2" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="字画" name="fourth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist3" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="钱币" name="fifth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist4" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="木器" name="sixth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist5" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="铜器" name="seventh">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist6" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="珠宝" name="eighth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist7" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="钟表西洋器" name="ninth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist8" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="杂项" name="tenth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist9" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="工艺品" name="leventh">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist10" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
							<el-tab-pane label="衍生品" name="twelfth">

								<div class="jd_tc_page">
								</div>
								<div class="jd_cz_tbcon">

									<table class="jd_cz_tbl" cellspacing="1">
										<tbody>
											<tr>
												<th>宝贝图片</th>
												<th>商品信息</th>
												<th>发布信息</th>
												<th>状态</th>
												<th>操作</th>
											</tr>
											<tr class="td_cz_tr"  v-for="msg in salelist11" :key="msg.index">
												<td class="td_cz_tblimg">
													<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank">
														<img :src="msg.pic" class="Img100" :alt="msg.name" />
													</a>
												</td>
												<td class="td_cz_tblinfo">
													<div class="td_cz_ifb">
														<a href="http://www.cang.com/trade/show-19111046-2.html" target="_blank" class="b">{{msg.name}}</a>
													</div>
													<div class="td_cz_ifb">编号：{{msg.number}}</div>
													<div class="td_cz_ifb">类别：
														<a href="?cate=1,9," class="colf0">{{msg.typename}}</a>
													</div>
													<div class="td_cz_ifb">售价：{{msg.name}}</div>
													<div class="td_cz_ifb">邮费：{{msg.postage}}</div>
												</td>

												<td class="td_cz_tblcom">
													<div class="td_cz_ifb">发布：{{msg.time}}</div>
													<div class="td_cz_ifb">IP：{{msg.ip}}</div>
													<div class="td_cz_ifb">置顶：{{msg.roof}}</div>
												</td>
												<td>
													<div class="td_cz_ifb">
														<font class="red">{{msg.examine}}</font>
													</div>
													<div class="td_cz_ifb">
														<font class="orange">{{msg.sale}} </font>
													</div>
													<div class="td_cz_ifb">
														<font class="green">{{msg.upper}}</font>
													</div>
												</td>
												<td class="td_cz_tblcz add_tblcz" data-productid="19111046" data-indata="2018/10/11 10:19:00">
													<a href='Trade_M.aspx?id=19111046' class='btn_a'>{{msg.edit}}</a>
													<a href='javascript:void(0);' class='btn_jg' rowdata='19111046' price='383838' postagetype='1' postage='0'>{{msg.price}}</a>
													<a href='javascript:void(0);' id='ys_19111046' class='btn_ys'>{{msg.sold}}</a>
													<a href='javascript:void(0);' class='btn_why' rowdata='19111046' show='-1' status='0' surveyorid='3942'>{{msg.return}}</a>
												</td>
											</tr>
										</tbody>
									</table>

								</div>

							</el-tab-pane>
						</el-tabs>

						<div class="jd_m_mbor"></div>
					</div>

					<div class="jd_tc_page">
					</div>
				</div>

			</el-tab-pane>
		</el-tabs>

		<div class="box_edit_price" style="display: none;">
			<table width="100%" cellspacing="0" cellpadding="0" border="0">
				<tbody>
					<tr>
						<td align="left">
							<div>
								<span class="fl">价格：</span><input maxlength="7" class="txtPrice txtInput red field-text" onchange="if(this.value.replace(/[^\d]/g,'')!=''){this.value=parseInt(this.value.replace(/[^\d]/g,''),10);}else{this.value='0';}" onkeyup="if(this.value.replace(/[^\d]/g,'')!=''){this.value=parseInt(this.value.replace(/[^\d]/g,''),10);}else{this.value='';}" onblur="if(this.value.replace(/[^\d]/g,'')==''){this.value='0'}" style="width: 93px; height: 12px; padding: 4px 5px;" type="text"> 元/RMB
							</div>
						</td>
					</tr>
					<tr>
						<td align="left">
							<div class="expressFee">
								<input class="hyunfeitype" value="" type="hidden">
								<span class="fl">运费：</span>
								<div class="fl">
									<p class="youfeiclass">
										<font class="unchecked unchecked0 " onclick="$('.hyunfeitype').val('0');$('.youfeiclass .unchecked').removeClass('checked');$(this).addClass('checked');$('.postalfees').val('');$('.postalfees').attr('readonly','readonly');">包邮</font>
									</p>
									<p class="youfeiclass">
										<font class="unchecked unchecked2 " onclick="$('.hyunfeitype').val('2');$('.youfeiclass .unchecked').removeClass('checked');$(this).addClass('checked');$('.postalfees').removeAttr('readonly');">不包邮</font>
										<input class="postalfees" maxlength="7" name="postalfees" onchange="if(this.value.replace(/[^\d]/g,'')!=''){this.value=parseInt(this.value.replace(/[^\d]/g,''),10);}else{this.value='0';}" onkeyup="if(this.value.replace(/[^\d]/g,'')!=''){this.value=parseInt(this.value.replace(/[^\d]/g,''),10);}else{this.value='';}" onblur="if(this.value.replace(/[^\d]/g,'')==''){this.value='0'}" placeholder="不能小于0" type="text"> 元/RMB
									</p>
									<p class="youfeiclass">
										<font class="unchecked unchecked1 " onclick="$('.hyunfeitype').val('1');$('.youfeiclass .unchecked').removeClass('checked');$(this).addClass('checked');$('.postalfees').val('');$('.postalfees').attr('readonly','readonly');">到付</font>
									</p>
								</div>
							</div>
						</td>
					</tr>
					<tr>
						<td valign="middle" align="center">
							<input class="b_edit_price td_img btn_y80_25" style="height: 28px;" value="修 改" onclick="EditPricePostage()" type="button">
						</td>
					</tr>
				</tbody>
			</table>
		</div>

	</div>

</template>

<script>
	import '~/assets/css/trade.css'
	import '~/assets/css/jianding.css'
	import stallApi from '~/api/stalltrade'
	export default {
		data() {
			return {
				activeName: 'first',
				activeName1: 'first',
				activeName2: 'first',
				activeName3: 'first',
				activeName4: 'first',
				activeName5: 'first',
				salelist: [],
				salelist1: [],
				salelist2: [],
				salelist3: [],
				salelist4: [],
				salelist5: [],
				salelist6: [],
				salelist7: [],
				salelist8: [],
				salelist9: [],
				salelist10: [],
				salelist11: []

			}
		},
		methods: {
			handleClick(tab, event) {
				console.log(tab, event);
			},
			handleClick2(tab, event) {
				console.log(tab, event);
			}

		},
		created: function() {
			var self = this; //待售藏品-全部
			stallApi.allList().then(function(res) {

				self.salelist = res.data.salelist
				//待售藏品-瓷器
				stallApi.Porcelain().then(function(res) {

					self.salelist1 = res.data.salelist1

				})

				//待售藏品-玉器
				stallApi.Jade().then(function(res) {

					self.salelist2 = res.data.salelist2

				})
				//待售藏品-字画
				stallApi.painting().then(function(res) {

					self.salelist3 = res.data.salelist3

				})
				//待售藏品-钱币
				stallApi.Coin().then(function(res) {

					self.salelist4 = res.data.salelist4

				})
				//待售藏品-木器
				stallApi.Woodenware().then(function(res) {

					self.salelist5 = res.data.salelist5

				})
				//待售藏品-铜器
				stallApi.Bronze().then(function(res) {

					self.salelist6 = res.data.salelist6

				})
				//待售藏品-珠宝
				stallApi.Jewellery().then(function(res) {

					self.salelist7 = res.data.salelist7

				})
				//待售藏品-钟表西洋器
				stallApi.watches().then(function(res) {

					self.salelist8 = res.data.salelist8

				})
				//待售藏品-杂项
				stallApi.miscellaneous().then(function(res) {

					self.salelist9 = res.data.salelist9

				})
				//待售藏品-工艺品
				stallApi.Arts().then(function(res) {

					self.salelist10 = res.data.salelist10

				})
				//待售藏品-衍生品
				stallApi.Derivative().then(function(res) {

					self.salelist11 = res.data.salelist11

				})

			}, function() {
				console.log('请求失败')
			})

		},
		mounted(){
			$(function(){
				$(".td_cz_tr").mousemove(function(){
					$(this).addClass('td_cz_trsel').siblings('.td_cz_tr').removeClass('td_cz_trsel')
				})
/*				$(".td_cz_tr").mouseout(function(){
					$(this).removeClass('td_cz_trsel')
				})*/
				
			})
		}
	}
</script>

<style>
	/* 修改侧导航tab栏切换的左边距 */
	
	.el-tabs__nav-scroll .el-tabs__nav {
		left: 4%;
	}
</style>