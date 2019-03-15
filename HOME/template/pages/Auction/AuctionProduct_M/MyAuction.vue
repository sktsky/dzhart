<!-- 我的拍品 -->
<template id="AuctionProduct_M1">
	<div>
		<div class="pai_s_link">
			<el-tabs v-model="activeName" @tab-click="handleClick">
				<el-tab-pane label="全部拍品(0)" name="first">

					<div class="pai_cz_box">
						<div class="pai_pt_box" style="display:none;">

							<div class="pai_pt_allCheck">
								<div class="pai_img allCheckbox" onclick="checkedOther('checkItem')"></div>
							</div>
							<div class="pai_pt_pb btnAddDate">增加拍卖时间</div>
							<div class="pai_pt_pages" style="display:none;">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,0)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>

						<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
							<tbody>
								<tr class="bg">
									<th style="width:50px;background-color:#FFF;">选择</th>
									<th style="width:140px;background-color:#FFF;">图片</th>
									<th style="background-color:#FFF;">拍品信息</th>
									<th style="width:160px;background-color:#FFF;">价格</th>
									<th style="width:160px;background-color:#FFF;">售况</th>
									<th style="width:140px;background-color:#FFF;">操作</th>
								</tr>
								<tr v-for="msg in actionlist" :key="msg.index">
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<input name="HidSGID" type="hidden" value="" data="974814" />
										<div class="pai_img Checkbox"></div>
									</td>
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<a href="http://www.cang.com/auction/974814.html" target="_blank"><img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.name}}</a><br/> 编 号：{{msg.number}}类 别：<span class="colf0">{{msg.type}}</span><br /> 结 拍：<span class="red">{{msg.pattime}}</span><br /></p>
										剩 余：<span class="red">{{msg.time}}</span><span class='pai_jp'><span class='gameover'>结拍</span></span>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											当前价：<span class="red">{{msg.current}}</span><br />领先人：{{msg.people}}<br />起拍价：{{msg.start}}<br />保留价：
											<font class='red'>{{msg.retain}}</font>
											<a class="b blue" href="http://news.cang.com/infos/201202/184926.html" target="_blank">？</a><br /> 一口价：2000
										</p>
									</td>
									<td class="pai_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											售况：<span class="red">{{msg.sale}} </span><br />状态：<span class="red">{{msg.state}}</span><br />点击率:<span id="RptList_lbhit_0">{{msg.click}}</span><br />
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
							<div class="pai_pt_allCheck">
								<div class="pai_img allCheckbox" onclick="checkedOther('checkItem')"></div>
							</div>
							<div class="pai_pt_pb btnAddDate">增加拍卖时间</div>
							<div class="pai_pt_pages" style="display:none;">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,0)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>
					</div>

				</el-tab-pane>
				<el-tab-pane label="未审" name="second">

					<div class="pai_cz_box">
						<div class="pai_pt_box" style="display:none;">

							<div class="pai_pt_allCheck">
								<div class="pai_img allCheckbox" onclick="checkedOther('checkItem')"></div>
							</div>
							<div class="pai_pt_pb btnAddDate">增加拍卖时间</div>
							<div class="pai_pt_pages" style="display:none;">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,0)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>

						<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
							<tbody>
								<tr class="bg">
									<th style="width:50px;background-color:#FFF;">选择</th>
									<th style="width:140px;background-color:#FFF;">图片</th>
									<th style="background-color:#FFF;">拍品信息</th>
									<th style="width:160px;background-color:#FFF;">价格</th>
									<th style="width:160px;background-color:#FFF;">售况</th>
									<th style="width:140px;background-color:#FFF;">操作</th>
								</tr>
								<tr v-for="msg in actionlist1" :key="msg.index">
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<input name="HidSGID" type="hidden" value="" data="974814" />
										<div class="pai_img Checkbox"></div>
									</td>
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<a href="http://www.cang.com/auction/974814.html" target="_blank"><img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.name}}</a><br/> 编 号：{{msg.number}}类 别：<span class="colf0">{{msg.type}}</span><br /> 结 拍：<span class="red">{{msg.pattime}}</span><br /></p>
										剩 余：<span class="red">{{msg.time}}</span><span class='pai_jp'><span class='gameover'>结拍</span></span>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											当前价：<span class="red">{{msg.current}}</span><br />领先人：{{msg.people}}<br />起拍价：{{msg.start}}<br />保留价：
											<font class='red'>{{msg.retain}}</font>
											<a class="b blue" href="http://news.cang.com/infos/201202/184926.html" target="_blank">？</a><br /> 一口价：2000
										</p>
									</td>
									<td class="pai_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											售况：<span class="red">{{msg.sale}} </span><br />状态：<span class="red">{{msg.state}}</span><br />点击率:<span id="RptList_lbhit_0">{{msg.click}}</span><br />
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
							<div class="pai_pt_allCheck">
								<div class="pai_img allCheckbox" onclick="checkedOther('checkItem')"></div>
							</div>
							<div class="pai_pt_pb btnAddDate">增加拍卖时间</div>
							<div class="pai_pt_pages" style="display:none;">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,0)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>
					</div>

				</el-tab-pane>
				<el-tab-pane label="待售" name="third">

					<div class="pai_cz_box">
						<div class="pai_pt_box" style="display:none;">

							<div class="pai_pt_allCheck">
								<div class="pai_img allCheckbox" onclick="checkedOther('checkItem')"></div>
							</div>
							<div class="pai_pt_pb btnAddDate">增加拍卖时间</div>
							<div class="pai_pt_pages" style="display:none;">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,0)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>

						<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
							<tbody>
								<tr class="bg">
									<th style="width:50px;background-color:#FFF;">选择</th>
									<th style="width:140px;background-color:#FFF;">图片</th>
									<th style="background-color:#FFF;">拍品信息</th>
									<th style="width:160px;background-color:#FFF;">价格</th>
									<th style="width:160px;background-color:#FFF;">售况</th>
									<th style="width:140px;background-color:#FFF;">操作</th>
								</tr>
								<tr v-for="msg in actionlist2" :key="msg.index">
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<input name="HidSGID" type="hidden" value="" data="974814" />
										<div class="pai_img Checkbox"></div>
									</td>
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<a href="http://www.cang.com/auction/974814.html" target="_blank"><img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.name}}</a><br/> 编 号：{{msg.number}}类 别：<span class="colf0">{{msg.type}}</span><br /> 结 拍：<span class="red">{{msg.pattime}}</span><br /></p>
										剩 余：<span class="red">{{msg.time}}</span><span class='pai_jp'><span class='gameover'>结拍</span></span>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											当前价：<span class="red">{{msg.current}}</span><br />领先人：{{msg.people}}<br />起拍价：{{msg.start}}<br />保留价：
											<font class='red'>{{msg.retain}}</font>
											<a class="b blue" href="http://news.cang.com/infos/201202/184926.html" target="_blank">？</a><br /> 一口价：2000
										</p>
									</td>
									<td class="pai_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											售况：<span class="red">{{msg.sale}} </span><br />状态：<span class="red">{{msg.state}}</span><br />点击率:<span id="RptList_lbhit_0">{{msg.click}}</span><br />
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
							<div class="pai_pt_allCheck">
								<div class="pai_img allCheckbox" onclick="checkedOther('checkItem')"></div>
							</div>
							<div class="pai_pt_pb btnAddDate">增加拍卖时间</div>
							<div class="pai_pt_pages" style="display:none;">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,0)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>
					</div>

				</el-tab-pane>
				<el-tab-pane label="已售" name="fourth">

					<div class="pai_cz_box">
						<div class="pai_pt_box" style="display:none;">

							<div class="pai_pt_allCheck">
								<div class="pai_img allCheckbox" onclick="checkedOther('checkItem')"></div>
							</div>
							<div class="pai_pt_pb btnAddDate">增加拍卖时间</div>
							<div class="pai_pt_pages" style="display:none;">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,0)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>

						<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
							<tbody>
								<tr class="bg">
									<th style="width:50px;background-color:#FFF;">选择</th>
									<th style="width:140px;background-color:#FFF;">图片</th>
									<th style="background-color:#FFF;">拍品信息</th>
									<th style="width:160px;background-color:#FFF;">价格</th>
									<th style="width:160px;background-color:#FFF;">售况</th>
									<th style="width:140px;background-color:#FFF;">操作</th>
								</tr>
								<tr v-for="msg in actionlist3" :key="msg.index">
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<input name="HidSGID" type="hidden" value="" data="974814" />
										<div class="pai_img Checkbox"></div>
									</td>
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<a href="http://www.cang.com/auction/974814.html" target="_blank"><img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.name}}</a><br/> 编 号：{{msg.number}}类 别：<span class="colf0">{{msg.type}}</span><br /> 结 拍：<span class="red">{{msg.pattime}}</span><br /></p>
										剩 余：<span class="red">{{msg.time}}</span><span class='pai_jp'><span class='gameover'>结拍</span></span>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											当前价：<span class="red">{{msg.current}}</span><br />领先人：{{msg.people}}<br />起拍价：{{msg.start}}<br />保留价：
											<font class='red'>{{msg.retain}}</font>
											<a class="b blue" href="http://news.cang.com/infos/201202/184926.html" target="_blank">？</a><br /> 一口价：2000
										</p>
									</td>
									<td class="pai_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											售况：<span class="red">{{msg.sale}} </span><br />状态：<span class="red">{{msg.state}}</span><br />点击率:<span id="RptList_lbhit_0">{{msg.click}}</span><br />
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
							<div class="pai_pt_allCheck">
								<div class="pai_img allCheckbox" onclick="checkedOther('checkItem')"></div>
							</div>
							<div class="pai_pt_pb btnAddDate">增加拍卖时间</div>
							<div class="pai_pt_pages" style="display:none;">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,0)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>
					</div>

				</el-tab-pane>
				<el-tab-pane label="到期待售" name="fifth">

					<div class="pai_cz_box">
						<div class="pai_pt_box" style="display:none;">

							<div class="pai_pt_allCheck">
								<div class="pai_img allCheckbox" onclick="checkedOther('checkItem')"></div>
							</div>
							<div class="pai_pt_pb btnAddDate">增加拍卖时间</div>
							<div class="pai_pt_pages" style="display:none;">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,0)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>

						<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
							<tbody>
								<tr class="bg">
									<th style="width:50px;background-color:#FFF;">选择</th>
									<th style="width:140px;background-color:#FFF;">图片</th>
									<th style="background-color:#FFF;">拍品信息</th>
									<th style="width:160px;background-color:#FFF;">价格</th>
									<th style="width:160px;background-color:#FFF;">售况</th>
									<th style="width:140px;background-color:#FFF;">操作</th>
								</tr>
								<tr v-for="msg in actionlist4" :key="msg.index">
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<input name="HidSGID" type="hidden" value="" data="974814" />
										<div class="pai_img Checkbox"></div>
									</td>
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<a href="http://www.cang.com/auction/974814.html" target="_blank"><img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.name}}</a><br/> 编 号：{{msg.number}}类 别：<span class="colf0">{{msg.type}}</span><br /> 结 拍：<span class="red">{{msg.pattime}}</span><br /></p>
										剩 余：<span class="red">{{msg.time}}</span><span class='pai_jp'><span class='gameover'>结拍</span></span>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											当前价：<span class="red">{{msg.current}}</span><br />领先人：{{msg.people}}<br />起拍价：{{msg.start}}<br />保留价：
											<font class='red'>{{msg.retain}}</font>
											<a class="b blue" href="http://news.cang.com/infos/201202/184926.html" target="_blank">？</a><br /> 一口价：2000
										</p>
									</td>
									<td class="pai_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											售况：<span class="red">{{msg.sale}} </span><br />状态：<span class="red">{{msg.state}}</span><br />点击率:<span id="RptList_lbhit_0">{{msg.click}}</span><br />
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
							<div class="pai_pt_allCheck">
								<div class="pai_img allCheckbox" onclick="checkedOther('checkItem')"></div>
							</div>
							<div class="pai_pt_pb btnAddDate">增加拍卖时间</div>
							<div class="pai_pt_pages" style="display:none;">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,0)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>
					</div>

				</el-tab-pane>
				<el-tab-pane label="待生成订单" name="sixth">

					<div class="pai_cz_box">
						<div class="pai_pt_box" style="display:none;">

							<div class="pai_pt_allCheck">
								<div class="pai_img allCheckbox" onclick="checkedOther('checkItem')"></div>
							</div>
							<div class="pai_pt_pb btnAddDate">增加拍卖时间</div>
							<div class="pai_pt_pages" style="display:none;">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,0)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>

						<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
							<tbody>
								<tr class="bg">
									<th style="width:50px;background-color:#FFF;">选择</th>
									<th style="width:140px;background-color:#FFF;">图片</th>
									<th style="background-color:#FFF;">拍品信息</th>
									<th style="width:160px;background-color:#FFF;">价格</th>
									<th style="width:160px;background-color:#FFF;">售况</th>
									<th style="width:140px;background-color:#FFF;">操作</th>
								</tr>
								<tr v-for="msg in actionlist5" :key="msg.index">
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<input name="HidSGID" type="hidden" value="" data="974814" />
										<div class="pai_img Checkbox"></div>
									</td>
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<a href="http://www.cang.com/auction/974814.html" target="_blank"><img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.name}}</a><br/> 编 号：{{msg.number}}类 别：<span class="colf0">{{msg.type}}</span><br /> 结 拍：<span class="red">{{msg.pattime}}</span><br /></p>
										剩 余：<span class="red">{{msg.time}}</span><span class='pai_jp'><span class='gameover'>结拍</span></span>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											当前价：<span class="red">{{msg.current}}</span><br />领先人：{{msg.people}}<br />起拍价：{{msg.start}}<br />保留价：
											<font class='red'>{{msg.retain}}</font>
											<a class="b blue" href="http://news.cang.com/infos/201202/184926.html" target="_blank">？</a><br /> 一口价：2000
										</p>
									</td>
									<td class="pai_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											售况：<span class="red">{{msg.sale}} </span><br />状态：<span class="red">{{msg.state}}</span><br />点击率:<span id="RptList_lbhit_0">{{msg.click}}</span><br />
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
							<div class="pai_pt_allCheck">
								<div class="pai_img allCheckbox" onclick="checkedOther('checkItem')"></div>
							</div>
							<div class="pai_pt_pb btnAddDate">增加拍卖时间</div>
							<div class="pai_pt_pages" style="display:none;">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,0)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>
					</div>

				</el-tab-pane>
				<el-tab-pane label="已生成订单" name="seventh">

					<div class="pai_cz_box">
						<div class="pai_pt_box" style="display:none;">

							<div class="pai_pt_allCheck">
								<div class="pai_img allCheckbox" onclick="checkedOther('checkItem')"></div>
							</div>
							<div class="pai_pt_pb btnAddDate">增加拍卖时间</div>
							<div class="pai_pt_pages" style="display:none;">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,0)" type="button">
								</div>
								<a class="nextpage " href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
							</div>
						</div>

						<table id="table" class="pai_tbl" width="100%" cellspacing="1" cellpadding="0" bgcolor="#e5e5e5">
							<tbody>
								<tr class="bg">
									<th style="width:50px;background-color:#FFF;">选择</th>
									<th style="width:140px;background-color:#FFF;">图片</th>
									<th style="background-color:#FFF;">拍品信息</th>
									<th style="width:160px;background-color:#FFF;">价格</th>
									<th style="width:160px;background-color:#FFF;">售况</th>
									<th style="width:140px;background-color:#FFF;">操作</th>
								</tr>
								<tr v-for="msg in actionlist6" :key="msg.index">
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<input name="HidSGID" type="hidden" value="" data="974814" />
										<div class="pai_img Checkbox"></div>
									</td>
									<td align="center" valign="middle" bgcolor="#FFFFFF">
										<a href="http://www.cang.com/auction/974814.html" target="_blank"><img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											<a href="http://www.cang.com/auction/974814.html" target="_blank" class="col65 b">{{msg.name}}</a><br/> 编 号：{{msg.number}}类 别：<span class="colf0">{{msg.type}}</span><br /> 结 拍：<span class="red">{{msg.pattime}}</span><br /></p>
										剩 余：<span class="red">{{msg.time}}</span><span class='pai_jp'><span class='gameover'>结拍</span></span>
									</td>
									<td class="pai_td_con" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											当前价：<span class="red">{{msg.current}}</span><br />领先人：{{msg.people}}<br />起拍价：{{msg.start}}<br />保留价：
											<font class='red'>{{msg.retain}}</font>
											<a class="b blue" href="http://news.cang.com/infos/201202/184926.html" target="_blank">？</a><br /> 一口价：2000
										</p>
									</td>
									<td class="pai_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
										<p>
											售况：<span class="red">{{msg.sale}} </span><br />状态：<span class="red">{{msg.state}}</span><br />点击率:<span id="RptList_lbhit_0">{{msg.click}}</span><br />
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
							<div class="pai_pt_allCheck">
								<div class="pai_img allCheckbox" onclick="checkedOther('checkItem')"></div>
							</div>
							<div class="pai_pt_pb btnAddDate">增加拍卖时间</div>
							<div class="pai_pt_pages" style="display:none;">
								<div class="p_input_html">
									第<input class="p_input_page" value="1" data="1" type="text">页
									<input class="p_input_go" value="GO" onclick="gopage(this,0)" type="button">
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
	import auctionApi from '~/api/auctionproduct'
	export default {
		data() {
			return {
				activeName: 'fifth',
				actionlist: [],
				actionlist1: [],
				actionlist2: [],
				actionlist3: [],
				actionlist4: [],
				actionlist5: [],
				actionlist6: []
			};
		},
		methods: {
			handleClick(tab, event) {
				console.log(tab, event);
			}
		},
		created: function() {
			var self = this;
			auctionApi.allLot().then(function(res) {
				self.actionlist = res.data.actionlist
				//未审
				auctionApi.Untried().then(function(res) {
					self.actionlist1 = res.data.actionlist1

				})
				//待售
				auctionApi.forsale().then(function(res) {
					self.actionlist2 = res.data.actionlist2

				})
				//已售
				auctionApi.Sold().then(function(res) {
					self.actionlist3 = res.data.actionlist3

				})
				//到期待售
				auctionApi.Expire().then(function(res) {
					self.actionlist4 = res.data.actionlist4

				})
				//待生成订单
				auctionApi.generate().then(function(res) {
					self.actionlist5 = res.data.actionlist5

				})
				//已生成订单
				auctionApi.Generated().then(function(res) {
					self.actionlist6 = res.data.actionlist6

				})
			}, function() {
				console.log('失败')
			})
		}
	}
</script>

<style>

</style>