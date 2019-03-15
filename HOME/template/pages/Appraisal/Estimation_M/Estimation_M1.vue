<!-- 我的帖子 -->
<template id="Estimation_M1">
	<div>
		<div class="jd_s_link">
			<el-tabs v-model="activeName" class="pl" @tab-click="handleClick">
				<el-tab-pane label="全部" name="first">

					<div class="jd_cz_box">
						<div class="jd_m_menu">

							<el-tabs v-model="activeName1" @tab-click="handleClick2">
								<el-tab-pane label="全部" name="first">
									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
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
											<tbody v-for="msg in mylist1" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="玉器" name="third">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist2" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="字画" name="fourth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist3" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="钱币" name="fifth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist4" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="木器" name="sixth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist5" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="铜器" name="seventh">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist6" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="珠宝" name="eighth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist7" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="钟表西洋器" name="ninth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist8" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="文献书籍" name="tenth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist9" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="杂项" name="eleventh">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist10" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
							</el-tabs>

							<div class="jd_m_mbor"></div>
						</div>
						<div class="jd_cz_tbcon">
							<table class="jd_cz_tbl" cellspacing="1">

							</table>
							<input name="hidUName" id="hidUName" value="yeyou33" type="hidden">
						</div>
						<div class="jd_tc_page">
						</div>
					</div>

				</el-tab-pane>
				<el-tab-pane label="未审估价" name="second">

					<div class="jd_cz_box">
						<div class="jd_m_menu">

							<el-tabs v-model="activeName2" @tab-click="handleClick2">
								<el-tab-pane label="全部" name="first">
									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="瓷器" name="second">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist1" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="玉器" name="third">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist2" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="字画" name="fourth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist3" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="钱币" name="fifth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist4" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="木器" name="sixth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist5" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="铜器" name="seventh">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist6" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="珠宝" name="eighth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist7" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="钟表西洋器" name="ninth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist8" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="文献书籍" name="tenth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist9" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="杂项" name="eleventh">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist10" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
							</el-tabs>

							<div class="jd_m_mbor"></div>
						</div>
						<div class="jd_cz_tbcon">
							<table class="jd_cz_tbl" cellspacing="1">

							</table>
							<input name="hidUName" id="hidUName" value="yeyou33" type="hidden">
						</div>
						<div class="jd_tc_page">
						</div>
					</div>

				</el-tab-pane>
				<el-tab-pane label="有偿鉴定" name="third">

					<div class="jd_cz_box">
						<div class="jd_m_menu">

							<el-tabs v-model="activeName3" @tab-click="handleClick2">
								<el-tab-pane label="全部" name="first">
									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="瓷器" name="second">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist1" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="玉器" name="third">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist2" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="字画" name="fourth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist3" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="钱币" name="fifth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist4" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="木器" name="sixth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist5" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="铜器" name="seventh">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist6" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="珠宝" name="eighth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist7" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="钟表西洋器" name="ninth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist8" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="文献书籍" name="tenth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist9" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="杂项" name="eleventh">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist10" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
							</el-tabs>

							<div class="jd_m_mbor"></div>
						</div>
						<div class="jd_cz_tbcon">
							<table class="jd_cz_tbl" cellspacing="1">

							</table>
							<input name="hidUName" id="hidUName" value="yeyou33" type="hidden">
						</div>
						<div class="jd_tc_page">
						</div>
					</div>

				</el-tab-pane>
				<el-tab-pane label="交易鉴定" name="fourth">

					<div class="jd_cz_box">
						<div class="jd_m_menu">

							<el-tabs v-model="activeName4" @tab-click="handleClick2">
								<el-tab-pane label="全部" name="first">
									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="瓷器" name="second">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist1" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="玉器" name="third">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist2" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="字画" name="fourth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist3" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="钱币" name="fifth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist4" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="木器" name="sixth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist5" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
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
											<tbody v-for="msg in mylist6" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
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
											<tbody v-for="msg in mylist7" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
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
											<tbody v-for="msg in mylist8" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>

									</div>

								</el-tab-pane>
								<el-tab-pane label="文献书籍" name="tenth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist9" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>

									</div>

								</el-tab-pane>
								<el-tab-pane label="杂项" name="eleventh">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist10" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>

									</div>

								</el-tab-pane>
							</el-tabs>

							<div class="jd_m_mbor"></div>
						</div>
						<div class="jd_cz_tbcon">
							<table class="jd_cz_tbl" cellspacing="1">

							</table>

						</div>
						<div class="jd_tc_page">
						</div>
					</div>
				</el-tab-pane>
				<el-tab-pane label="我的收藏" name="fifth">

					<div class="jd_cz_box">
						<div class="jd_m_menu">

							<el-tabs v-model="activeName5" @tab-click="handleClick2">
								<el-tab-pane label="全部" name="first">
									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>
										<input name="hidUName" type="hidden" id="hidUName" value="yeyou33" />
									</div>

								</el-tab-pane>
								<el-tab-pane label="瓷器" name="second">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist1" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
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
											<tbody v-for="msg in mylist2" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
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
											<tbody v-for="msg in mylist3" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
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
											<tbody v-for="msg in mylist4" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
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
											<tbody v-for="msg in mylist5" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
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
											<tbody v-for="msg in mylist6" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
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
											<tbody v-for="msg in mylist7" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
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
											<tbody v-for="msg in mylist8" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>

									</div>

								</el-tab-pane>
								<el-tab-pane label="文献书籍" name="tenth">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist9" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>

									</div>

								</el-tab-pane>
								<el-tab-pane label="杂项" name="eleventh">

									<div class="jd_tc_page">
									</div>
									<div class="jd_cz_tbcon">

										<table class="jd_cz_tbl" cellspacing="1">
											<tbody v-for="msg in mylist10" :key="msg.index">
												<tr id='tr3167035' rowdata="3167035" class="jd_cz_tr" onmousemove="$(this).addClass('jd_cz_trsel');" onmouseout="$(this).removeClass('jd_cz_trsel');">
													<td class="jd_cz_tblimg">
														<input type="hidden" name="RptList$ctl00$hidRowID" id="RptList_hidRowID_0" value="3167035" />
														<input type="hidden" name="hid3167035" id="hid3167035" value="1,10," />
														<a href="http://jd.cang.com/3167035.html" target="_blank"><img alt="瓷器" :src="msg.pic" /></a>
													</td>
													<td>
														<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
															<a href="http://jd.cang.com/3167035.html" target="_blank" class="fs13 blue b"><span class="colf0">{{msg.cname}}</span>{{msg.name}}</a>
														</div>
														<div class="jd_cz_ifb">{{msg.numb}}<span class="col91">{{msg.number}}</span></div>
														<div class="jd_cz_ifb">{{msg.click}}<span class="col91">{{msg.clickname}}</span></div>
														<div class="jd_cz_ifb">{{msg.upload}}<span class="col91">{{msg.time}}</span></div>
														<div class="jd_cz_ifb">{{msg.roof}}<span class="col91"></span></div>
													</td>
													<td style="width:180px;">
														<div class="jd_cz_ifb">
															<span class="colf0" rowdata="3167035">[<font class='green'>{{msg.study}}</font>]</span>
														</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.comment}}</div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.people}}<span class="col91"></span></div>
														<div class="jd_cz_ifb" style="visibility:hidden;">{{msg.ptime}}<span class="col91"></span></div>
													</td>
													<td class="jd_cz_tblcz">
														<div class="jd_cz_ifbut">
															<a href="javascript:void(0);" onclick='goods_action(3167035,"top")'>{{msg.roofnews}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' class='btn_jd' ctype='1,10,'>{{msg.Appraisal}}</a>
														</div>
														<div class='jd_cz_ifbut'>
															<a href='javascript:void(0);' onclick='goods_action(3167035,"Yaxiang")'>{{msg.set}}</a>
														</div>
													</td>
												</tr>
											</tbody>
										</table>

									</div>

								</el-tab-pane>
							</el-tabs>

							<div class="jd_m_mbor"></div>
						</div>
						<div class="jd_cz_tbcon">
							<table class="jd_cz_tbl" cellspacing="1">

							</table>

						</div>
						<div class="jd_tc_page">
						</div>
					</div>

				</el-tab-pane>
			</el-tabs>
		</div>

	</div>
</template>
<script>
	import '~/assets/css/jianding.css'
	import { getData } from '~/plugins/axios.js'
	export default {
		data() {
			return {
				activeName: 'first',
				activeName1: 'first',
				activeName2: 'first',
				activeName3: 'first',
				activeName4: 'first',
				activeName5: 'first',
				mylist: [],
				mylist1: [],
				mylist2: [],
				mylist3: [],
				mylist4: [],
				mylist5: [],
				mylist6: [],
				mylist7: [],
				mylist8: [],
				mylist9: [],
				mylist10: [],
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
			var self = this; //全部-全部
			getData('mock/5c0106de4ed9b43d7590d4eb/estimation/all', 'get').then(function(res) {

				self.mylist = res.data.mylist
				//全部-瓷器
				getData('mock/5c0106de4ed9b43d7590d4eb/estimation/mylist1', 'get').then(function(res) {

					self.mylist1 = res.data.mylist1

				}, function() {
					console.log('请求失败')
				})

				//全部-玉器
				getData('mock/5c0106de4ed9b43d7590d4eb/estimation/mylist2', 'get').then(function(res) {

					self.mylist2 = res.data.mylist2

				}, function() {
					console.log('请求失败')
				})
				//全部-字画
				getData('mock/5c0106de4ed9b43d7590d4eb/estimation/mylist3', 'get').then(function(res) {

					self.mylist3 = res.data.mylist3

				}, function() {
					console.log('请求失败')
				})
				//全部-钱币
				getData('mock/5c0106de4ed9b43d7590d4eb/estimation/mylist4', 'get').then(function(res) {

					self.mylist4 = res.data.mylist4

				}, function() {
					console.log('请求失败')
				})
				//全部-木器
				getData('mock/5c0106de4ed9b43d7590d4eb/estimation/mylist5', 'get').then(function(res) {

					self.mylist5 = res.data.mylist5

				}, function() {
					console.log('请求失败')
				})
				//全部-铜器
				getData('mock/5c0106de4ed9b43d7590d4eb/estimation/mylist6', 'get').then(function(res) {

					self.mylist6 = res.data.mylist6

				}, function() {
					console.log('请求失败')
				})
				//全部-珠宝
				getData('mock/5c0106de4ed9b43d7590d4eb/estimation/mylist7', 'get').then(function(res) {

					self.mylist7 = res.data.mylist7

				}, function() {
					console.log('请求失败')
				})
				//全部-钟表西洋器
				getData('mock/5c0106de4ed9b43d7590d4eb/estimation/mylist8', 'get').then(function(res) {

					self.mylist8 = res.data.mylist8

				}, function() {
					console.log('请求失败')
				})
				//全部-文献书籍
				getData('mock/5c0106de4ed9b43d7590d4eb/estimation/mylist9', 'get').then(function(res) {

					self.mylist9 = res.data.mylist9

				}, function() {
					console.log('请求失败')
				})
				//全部-杂项
				getData('mock/5c0106de4ed9b43d7590d4eb/estimation/mylist10', 'get').then(function(res) {

					self.mylist10 = res.data.mylist10

				}, function() {
					console.log('请求失败')
				})

			}, function() {
				console.log('请求失败')
			})

		}
	}
</script>

<style>

</style>