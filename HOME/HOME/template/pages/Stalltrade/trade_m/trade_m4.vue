<!-- 我的收藏 -->
<template id="trade_m4">
	<div>
	<div>
		<div class="td_cz_box">
			<div class="td_m_menu">
				<el-tabs v-model="activeName" @tab-click="handleClick">
					<el-tab-pane label="全部" name="first">

						<div class="td_tc_page">
						</div>
						<div class="td_cz_tbcon">

							<table class="td_cz_tbl" cellspacing="1">
								<tbody>
									<tr class="bg">
										<th>图片</th>
										<th>交易编号/名称/时间</th>
										<th>售况/价格</th>
										<th>操作</th>
									</tr>
									<tr class="td_cz_tr" onmousemove="$(this).addClass('td_cz_trsel');" onmouseout="$(this).removeClass('td_cz_trsel');" v-for="msg in tradelist" :key="msg.index">
										<td class="td_cz_tblimg">
											<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">
												<img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
										</td>
										<td class="td_cz_tblinfo">
											<div class="td_cz_ifb">
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank" class="b">{{msg.name}}</a>
											</div>
											<div class="td_cz_ifb">编号：
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">{{msg.number}}</a>
											</div>
											<div class="td_cz_ifb">藏友：
												<a href="http://www.cang.com/personal/index.asp?yourName=%de%b1%c7%e7%b9%c5%d4%c2%d0%f9" target="_blank">{{msg.polple}}</a>
											</div>
										</td>
										<td class="td_cz_tblcom">
											<div class="td_cz_ifb">当前售况：
												<font class="red">{{msg.sale}}</font>
											</div>
											<div class="td_cz_ifb">商品价格：
												<font class="red">{{msg.money}}</font>
											</div>
											<div class="td_cz_ifb">收藏时间：{{msg.time}}</div>
										</td>
										<td cclass="td_cz_tblcz add_tblcz">
											<div class='td_cz_ifbut'>
												<a href='javascript:void(0);' id='delcollect_2018883' class='btn_delcollect'>{{msg.operation}}</a>
											</div>
										</td>
									</tr>

								</tbody>
							</table>

						</div>

					</el-tab-pane>
					<el-tab-pane label="瓷器" name="second">

						<div class="td_tc_page">
						</div>
						<div class="td_cz_tbcon">

							<table class="td_cz_tbl" cellspacing="1">
								<tbody>
									<tr class="bg">
										<th>图片</th>
										<th>交易编号/名称/时间</th>
										<th>售况/价格</th>
										<th>操作</th>
									</tr>
									<tr class="td_cz_tr" onmousemove="$(this).addClass('td_cz_trsel');" onmouseout="$(this).removeClass('td_cz_trsel');" v-for="msg in tradelist1" :key="msg.index">
										<td class="td_cz_tblimg">
											<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">
												<img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
										</td>
										<td class="td_cz_tblinfo">
											<div class="td_cz_ifb">
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank" class="b">{{msg.name}}</a>
											</div>
											<div class="td_cz_ifb">编号：
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">{{msg.number}}</a>
											</div>
											<div class="td_cz_ifb">藏友：
												<a href="http://www.cang.com/personal/index.asp?yourName=%de%b1%c7%e7%b9%c5%d4%c2%d0%f9" target="_blank">{{msg.polple}}</a>
											</div>
										</td>
										<td class="td_cz_tblcom">
											<div class="td_cz_ifb">当前售况：
												<font class="red">{{msg.sale}}</font>
											</div>
											<div class="td_cz_ifb">商品价格：
												<font class="red">{{msg.money}}</font>
											</div>
											<div class="td_cz_ifb">收藏时间：{{msg.time}}</div>
										</td>
										<td cclass="td_cz_tblcz add_tblcz">
											<div class='td_cz_ifbut'>
												<a href='javascript:void(0);' id='delcollect_2018883' class='btn_delcollect'>{{msg.operation}}</a>
											</div>
										</td>
									</tr>

								</tbody>
							</table>

						</div>

					</el-tab-pane>
					<el-tab-pane label="玉器" name="third">

						<div class="td_tc_page">
						</div>
						<div class="td_cz_tbcon">

							<table class="td_cz_tbl" cellspacing="1">
								<tbody>
									<tr class="bg">
										<th>图片</th>
										<th>交易编号/名称/时间</th>
										<th>售况/价格</th>
										<th>操作</th>
									</tr>
									<tr class="td_cz_tr" onmousemove="$(this).addClass('td_cz_trsel');" onmouseout="$(this).removeClass('td_cz_trsel');" v-for="msg in tradelist2" :key="msg.index">
										<td class="td_cz_tblimg">
											<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">
												<img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
										</td>
										<td class="td_cz_tblinfo">
											<div class="td_cz_ifb">
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank" class="b">{{msg.name}}</a>
											</div>
											<div class="td_cz_ifb">编号：
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">{{msg.number}}</a>
											</div>
											<div class="td_cz_ifb">藏友：
												<a href="http://www.cang.com/personal/index.asp?yourName=%de%b1%c7%e7%b9%c5%d4%c2%d0%f9" target="_blank">{{msg.polple}}</a>
											</div>
										</td>
										<td class="td_cz_tblcom">
											<div class="td_cz_ifb">当前售况：
												<font class="red">{{msg.sale}}</font>
											</div>
											<div class="td_cz_ifb">商品价格：
												<font class="red">{{msg.money}}</font>
											</div>
											<div class="td_cz_ifb">收藏时间：{{msg.time}}</div>
										</td>
										<td cclass="td_cz_tblcz add_tblcz">
											<div class='td_cz_ifbut'>
												<a href='javascript:void(0);' id='delcollect_2018883' class='btn_delcollect'>{{msg.operation}}</a>
											</div>
										</td>
									</tr>

								</tbody>
							</table>

						</div>

					</el-tab-pane>
					<el-tab-pane label="字画" name="fourth">

						<div class="td_tc_page">
						</div>
						<div class="td_cz_tbcon">

							<table class="td_cz_tbl" cellspacing="1">
								<tbody>
									<tr class="bg">
										<th>图片</th>
										<th>交易编号/名称/时间</th>
										<th>售况/价格</th>
										<th>操作</th>
									</tr>
									<tr class="td_cz_tr" onmousemove="$(this).addClass('td_cz_trsel');" onmouseout="$(this).removeClass('td_cz_trsel');" v-for="msg in tradelist3" :key="msg.index">
										<td class="td_cz_tblimg">
											<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">
												<img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
										</td>
										<td class="td_cz_tblinfo">
											<div class="td_cz_ifb">
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank" class="b">{{msg.name}}</a>
											</div>
											<div class="td_cz_ifb">编号：
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">{{msg.number}}</a>
											</div>
											<div class="td_cz_ifb">藏友：
												<a href="http://www.cang.com/personal/index.asp?yourName=%de%b1%c7%e7%b9%c5%d4%c2%d0%f9" target="_blank">{{msg.polple}}</a>
											</div>
										</td>
										<td class="td_cz_tblcom">
											<div class="td_cz_ifb">当前售况：
												<font class="red">{{msg.sale}}</font>
											</div>
											<div class="td_cz_ifb">商品价格：
												<font class="red">{{msg.money}}</font>
											</div>
											<div class="td_cz_ifb">收藏时间：{{msg.time}}</div>
										</td>
										<td cclass="td_cz_tblcz add_tblcz">
											<div class='td_cz_ifbut'>
												<a href='javascript:void(0);' id='delcollect_2018883' class='btn_delcollect'>{{msg.operation}}</a>
											</div>
										</td>
									</tr>

								</tbody>
							</table>

						</div>

					</el-tab-pane>
					<el-tab-pane label="钱币" name="fifth">

						<div class="td_tc_page">
						</div>
						<div class="td_cz_tbcon">

							<table class="td_cz_tbl" cellspacing="1">
								<tbody>
									<tr class="bg">
										<th>图片</th>
										<th>交易编号/名称/时间</th>
										<th>售况/价格</th>
										<th>操作</th>
									</tr>
									<tr class="td_cz_tr" onmousemove="$(this).addClass('td_cz_trsel');" onmouseout="$(this).removeClass('td_cz_trsel');" v-for="msg in tradelist4" :key="msg.index">
										<td class="td_cz_tblimg">
											<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">
												<img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
										</td>
										<td class="td_cz_tblinfo">
											<div class="td_cz_ifb">
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank" class="b">{{msg.name}}</a>
											</div>
											<div class="td_cz_ifb">编号：
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">{{msg.number}}</a>
											</div>
											<div class="td_cz_ifb">藏友：
												<a href="http://www.cang.com/personal/index.asp?yourName=%de%b1%c7%e7%b9%c5%d4%c2%d0%f9" target="_blank">{{msg.polple}}</a>
											</div>
										</td>
										<td class="td_cz_tblcom">
											<div class="td_cz_ifb">当前售况：
												<font class="red">{{msg.sale}}</font>
											</div>
											<div class="td_cz_ifb">商品价格：
												<font class="red">{{msg.money}}</font>
											</div>
											<div class="td_cz_ifb">收藏时间：{{msg.time}}</div>
										</td>
										<td cclass="td_cz_tblcz add_tblcz">
											<div class='td_cz_ifbut'>
												<a href='javascript:void(0);' id='delcollect_2018883' class='btn_delcollect'>{{msg.operation}}</a>
											</div>
										</td>
									</tr>

								</tbody>
							</table>

						</div>

					</el-tab-pane>
					<el-tab-pane label="木器" name="sixth">

						<div class="td_tc_page">
						</div>
						<div class="td_cz_tbcon">

							<table class="td_cz_tbl" cellspacing="1">
								<tbody>
									<tr class="bg">
										<th>图片</th>
										<th>交易编号/名称/时间</th>
										<th>售况/价格</th>
										<th>操作</th>
									</tr>
									<tr class="td_cz_tr" onmousemove="$(this).addClass('td_cz_trsel');" onmouseout="$(this).removeClass('td_cz_trsel');" v-for="msg in tradelist5" :key="msg.index">
										<td class="td_cz_tblimg">
											<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">
												<img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
										</td>
										<td class="td_cz_tblinfo">
											<div class="td_cz_ifb">
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank" class="b">{{msg.name}}</a>
											</div>
											<div class="td_cz_ifb">编号：
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">{{msg.number}}</a>
											</div>
											<div class="td_cz_ifb">藏友：
												<a href="http://www.cang.com/personal/index.asp?yourName=%de%b1%c7%e7%b9%c5%d4%c2%d0%f9" target="_blank">{{msg.polple}}</a>
											</div>
										</td>
										<td class="td_cz_tblcom">
											<div class="td_cz_ifb">当前售况：
												<font class="red">{{msg.sale}}</font>
											</div>
											<div class="td_cz_ifb">商品价格：
												<font class="red">{{msg.money}}</font>
											</div>
											<div class="td_cz_ifb">收藏时间：{{msg.time}}</div>
										</td>
										<td cclass="td_cz_tblcz add_tblcz">
											<div class='td_cz_ifbut'>
												<a href='javascript:void(0);' id='delcollect_2018883' class='btn_delcollect'>{{msg.operation}}</a>
											</div>
										</td>
									</tr>

								</tbody>
							</table>

						</div>

					</el-tab-pane>
					<el-tab-pane label="铜器" name="seventh">

						<div class="td_tc_page">
						</div>
						<div class="td_cz_tbcon">

							<table class="td_cz_tbl" cellspacing="1">
								<tbody>
									<tr class="bg">
										<th>图片</th>
										<th>交易编号/名称/时间</th>
										<th>售况/价格</th>
										<th>操作</th>
									</tr>
									<tr class="td_cz_tr" onmousemove="$(this).addClass('td_cz_trsel');" onmouseout="$(this).removeClass('td_cz_trsel');" v-for="msg in tradelist6" :key="msg.index">
										<td class="td_cz_tblimg">
											<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">
												<img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
										</td>
										<td class="td_cz_tblinfo">
											<div class="td_cz_ifb">
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank" class="b">{{msg.name}}</a>
											</div>
											<div class="td_cz_ifb">编号：
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">{{msg.number}}</a>
											</div>
											<div class="td_cz_ifb">藏友：
												<a href="http://www.cang.com/personal/index.asp?yourName=%de%b1%c7%e7%b9%c5%d4%c2%d0%f9" target="_blank">{{msg.polple}}</a>
											</div>
										</td>
										<td class="td_cz_tblcom">
											<div class="td_cz_ifb">当前售况：
												<font class="red">{{msg.sale}}</font>
											</div>
											<div class="td_cz_ifb">商品价格：
												<font class="red">{{msg.money}}</font>
											</div>
											<div class="td_cz_ifb">收藏时间：{{msg.time}}</div>
										</td>
										<td cclass="td_cz_tblcz add_tblcz">
											<div class='td_cz_ifbut'>
												<a href='javascript:void(0);' id='delcollect_2018883' class='btn_delcollect'>{{msg.operation}}</a>
											</div>
										</td>
									</tr>

								</tbody>
							</table>

						</div>

					</el-tab-pane>
					<el-tab-pane label="珠宝" name="eigth">

						<div class="td_tc_page">
						</div>
						<div class="td_cz_tbcon">

							<table class="td_cz_tbl" cellspacing="1">
								<tbody>
									<tr class="bg">
										<th>图片</th>
										<th>交易编号/名称/时间</th>
										<th>售况/价格</th>
										<th>操作</th>
									</tr>
									<tr class="td_cz_tr" onmousemove="$(this).addClass('td_cz_trsel');" onmouseout="$(this).removeClass('td_cz_trsel');" v-for="msg in tradelist7" :key="msg.index">
										<td class="td_cz_tblimg">
											<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">
												<img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
										</td>
										<td class="td_cz_tblinfo">
											<div class="td_cz_ifb">
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank" class="b">{{msg.name}}</a>
											</div>
											<div class="td_cz_ifb">编号：
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">{{msg.number}}</a>
											</div>
											<div class="td_cz_ifb">藏友：
												<a href="http://www.cang.com/personal/index.asp?yourName=%de%b1%c7%e7%b9%c5%d4%c2%d0%f9" target="_blank">{{msg.polple}}</a>
											</div>
										</td>
										<td class="td_cz_tblcom">
											<div class="td_cz_ifb">当前售况：
												<font class="red">{{msg.sale}}</font>
											</div>
											<div class="td_cz_ifb">商品价格：
												<font class="red">{{msg.money}}</font>
											</div>
											<div class="td_cz_ifb">收藏时间：{{msg.time}}</div>
										</td>
										<td cclass="td_cz_tblcz add_tblcz">
											<div class='td_cz_ifbut'>
												<a href='javascript:void(0);' id='delcollect_2018883' class='btn_delcollect'>{{msg.operation}}</a>
											</div>
										</td>
									</tr>

								</tbody>
							</table>

						</div>

					</el-tab-pane>
					<el-tab-pane label="钟表西洋器" name="ninth">

						<div class="td_tc_page">
						</div>
						<div class="td_cz_tbcon">

							<table class="td_cz_tbl" cellspacing="1">
								<tbody>
									<tr class="bg">
										<th>图片</th>
										<th>交易编号/名称/时间</th>
										<th>售况/价格</th>
										<th>操作</th>
									</tr>
									<tr class="td_cz_tr" onmousemove="$(this).addClass('td_cz_trsel');" onmouseout="$(this).removeClass('td_cz_trsel');" v-for="msg in tradelist8" :key="msg.index">
										<td class="td_cz_tblimg">
											<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">
												<img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
										</td>
										<td class="td_cz_tblinfo">
											<div class="td_cz_ifb">
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank" class="b">{{msg.name}}</a>
											</div>
											<div class="td_cz_ifb">编号：
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">{{msg.number}}</a>
											</div>
											<div class="td_cz_ifb">藏友：
												<a href="http://www.cang.com/personal/index.asp?yourName=%de%b1%c7%e7%b9%c5%d4%c2%d0%f9" target="_blank">{{msg.polple}}</a>
											</div>
										</td>
										<td class="td_cz_tblcom">
											<div class="td_cz_ifb">当前售况：
												<font class="red">{{msg.sale}}</font>
											</div>
											<div class="td_cz_ifb">商品价格：
												<font class="red">{{msg.money}}</font>
											</div>
											<div class="td_cz_ifb">收藏时间：{{msg.time}}</div>
										</td>
										<td cclass="td_cz_tblcz add_tblcz">
											<div class='td_cz_ifbut'>
												<a href='javascript:void(0);' id='delcollect_2018883' class='btn_delcollect'>{{msg.operation}}</a>
											</div>
										</td>
									</tr>

								</tbody>
							</table>

						</div>

					</el-tab-pane>
					<el-tab-pane label="杂项" name="tenth">

						<div class="td_tc_page">
						</div>
						<div class="td_cz_tbcon">

							<table class="td_cz_tbl" cellspacing="1">
								<tbody>
									<tr class="bg">
										<th>图片</th>
										<th>交易编号/名称/时间</th>
										<th>售况/价格</th>
										<th>操作</th>
									</tr>
									<tr class="td_cz_tr" onmousemove="$(this).addClass('td_cz_trsel');" onmouseout="$(this).removeClass('td_cz_trsel');" v-for="msg in tradelist9" :key="msg.index">
										<td class="td_cz_tblimg">
											<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">
												<img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
										</td>
										<td class="td_cz_tblinfo">
											<div class="td_cz_ifb">
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank" class="b">{{msg.name}}</a>
											</div>
											<div class="td_cz_ifb">编号：
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">{{msg.number}}</a>
											</div>
											<div class="td_cz_ifb">藏友：
												<a href="http://www.cang.com/personal/index.asp?yourName=%de%b1%c7%e7%b9%c5%d4%c2%d0%f9" target="_blank">{{msg.polple}}</a>
											</div>
										</td>
										<td class="td_cz_tblcom">
											<div class="td_cz_ifb">当前售况：
												<font class="red">{{msg.sale}}</font>
											</div>
											<div class="td_cz_ifb">商品价格：
												<font class="red">{{msg.money}}</font>
											</div>
											<div class="td_cz_ifb">收藏时间：{{msg.time}}</div>
										</td>
										<td cclass="td_cz_tblcz add_tblcz">
											<div class='td_cz_ifbut'>
												<a href='javascript:void(0);' id='delcollect_2018883' class='btn_delcollect'>{{msg.operation}}</a>
											</div>
										</td>
									</tr>

								</tbody>
							</table>

						</div>

					</el-tab-pane>
					<el-tab-pane label="工艺品" name="eleventh">

						<div class="td_tc_page">
						</div>
						<div class="td_cz_tbcon">

							<table class="td_cz_tbl" cellspacing="1">
								<tbody>
									<tr class="bg">
										<th>图片</th>
										<th>交易编号/名称/时间</th>
										<th>售况/价格</th>
										<th>操作</th>
									</tr>
									<tr class="td_cz_tr" onmousemove="$(this).addClass('td_cz_trsel');" onmouseout="$(this).removeClass('td_cz_trsel');" v-for="msg in tradelist10" :key="msg.index">
										<td class="td_cz_tblimg">
											<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">
												<img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
										</td>
										<td class="td_cz_tblinfo">
											<div class="td_cz_ifb">
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank" class="b">{{msg.name}}</a>
											</div>
											<div class="td_cz_ifb">编号：
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">{{msg.number}}</a>
											</div>
											<div class="td_cz_ifb">藏友：
												<a href="http://www.cang.com/personal/index.asp?yourName=%de%b1%c7%e7%b9%c5%d4%c2%d0%f9" target="_blank">{{msg.polple}}</a>
											</div>
										</td>
										<td class="td_cz_tblcom">
											<div class="td_cz_ifb">当前售况：
												<font class="red">{{msg.sale}}</font>
											</div>
											<div class="td_cz_ifb">商品价格：
												<font class="red">{{msg.money}}</font>
											</div>
											<div class="td_cz_ifb">收藏时间：{{msg.time}}</div>
										</td>
										<td cclass="td_cz_tblcz add_tblcz">
											<div class='td_cz_ifbut'>
												<a href='javascript:void(0);' id='delcollect_2018883' class='btn_delcollect'>{{msg.operation}}</a>
											</div>
										</td>
									</tr>

								</tbody>
							</table>

						</div>

					</el-tab-pane>
					<el-tab-pane label="衍生品" name="twelfth">

						<div class="td_tc_page">
						</div>
						<div class="td_cz_tbcon">

							<table class="td_cz_tbl" cellspacing="1">
								<tbody>
									<tr class="bg">
										<th>图片</th>
										<th>交易编号/名称/时间</th>
										<th>售况/价格</th>
										<th>操作</th>
									</tr>
									<tr class="td_cz_tr" onmousemove="$(this).addClass('td_cz_trsel');" onmouseout="$(this).removeClass('td_cz_trsel');" v-for="msg in tradelist11" :key="msg.index">
										<td class="td_cz_tblimg">
											<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">
												<img :src="msg.pic" class="Img100" :alt="msg.name" /></a>
										</td>
										<td class="td_cz_tblinfo">
											<div class="td_cz_ifb">
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank" class="b">{{msg.name}}</a>
											</div>
											<div class="td_cz_ifb">编号：
												<a href="http://www.cang.com/trade/show-19450189-2.html" target="_blank">{{msg.number}}</a>
											</div>
											<div class="td_cz_ifb">藏友：
												<a href="http://www.cang.com/personal/index.asp?yourName=%de%b1%c7%e7%b9%c5%d4%c2%d0%f9" target="_blank">{{msg.polple}}</a>
											</div>
										</td>
										<td class="td_cz_tblcom">
											<div class="td_cz_ifb">当前售况：
												<font class="red">{{msg.sale}}</font>
											</div>
											<div class="td_cz_ifb">商品价格：
												<font class="red">{{msg.money}}</font>
											</div>
											<div class="td_cz_ifb">收藏时间：{{msg.time}}</div>
										</td>
										<td cclass="td_cz_tblcz add_tblcz">
											<div class='td_cz_ifbut'>
												<a href='javascript:void(0);' id='delcollect_2018883' class='btn_delcollect'>{{msg.operation}}</a>
											</div>
										</td>
									</tr>

								</tbody>
							</table>

						</div>

					</el-tab-pane>
				</el-tabs>
				<div class="td_m_mbor"></div>
			</div>

			<div class="td_tc_page">
			</div>
		</div>
	</div>
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
	import CollectionApi from '~/api/stallcollection'
	export default {
		data() {
			return {
				activeName: 'first',
				tradelist: [],
				tradelist1: [],
				tradelist2: [],
				tradelist3: [],
				tradelist4: [],
				tradelist5: [],
				tradelist6: [],
				tradelist7: [],
				tradelist8: [],
				tradelist9: [],
				tradelist10: [],
				tradelist11: []
			};
		},
		methods: {
			handleClick(tab, event) {
				console.log(tab, event);
			}
		},
		created: function() {
			var self = this;
			CollectionApi.allList().then(function(res) {
				self.tradelist = res.data.tradelist
				//瓷器
				CollectionApi.Porcelain().then(function(res) {
					self.tradelist1 = res.data.tradelist
				})
				//玉器
				CollectionApi.Jade().then(function(res) {
					self.tradelist2 = res.data.tradelist
				})
				//字画
				CollectionApi.painting().then(function(res) {
					self.tradelist3 = res.data.tradelist
				})
				//钱币
				CollectionApi.Coin().then(function(res) {
					self.tradelist4 = res.data.tradelist
				})
				//木器
				CollectionApi.Woodenware().then(function(res) {
					self.tradelist5 = res.data.tradelist
				})
				//铜器
				CollectionApi.Bronze().then(function(res) {
					self.tradelist6 = res.data.tradelist
				})
				//珠宝
				CollectionApi.Jewellery().then(function(res) {
					self.tradelist7 = res.data.tradelist
				})
				//钟表西洋器
				CollectionApi.watches().then(function(res) {
					self.tradelist8 = res.data.tradelist
				})
				//杂项
				CollectionApi.miscellaneous().then(function(res) {
					self.tradelist9 = res.data.tradelist
				})
				//工艺品
				CollectionApi.Arts().then(function(res) {
					self.tradelist10 = res.data.tradelist
				})
				//衍生品
				CollectionApi.Derivative().then(function(res) {
					self.tradelist11 = res.data.tradelist
				})
			}, function() {
				console.log('请求失败')
			})
		}
	}
</script>

<style>

</style>