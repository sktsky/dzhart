<!-- 我的卖单-->
<template id="sold_list">
	<div class="mright">
		<div class="menu">
			<a href="http://pay.cang.com/myhome/Trade/sold_list.aspx" class="menu_n menu_y"><span>我的卖单</span></a>
			<div style="position:relative;width:400px; height: 30px; margin-top: 19px; float: right;">
				<select name="ddlType" id="ddlType" class="soddlstyle" style="float:left;margin-right:3px;">
					<option selected="selected" value="0">最近订单</option>
					<option value="1">历史订单</option>

				</select>
				<select name="ddlSoType" id="ddlSoType" class="soddlstyle">
					<option value="1" selected="selected">商品号</option>
					<option value="4">商品名</option>
					<option value="2">订单号</option>
					<option value="3">买家名</option>

				</select><input name="txtKey" maxlength="30" id="txtKey" class="sotxt" style="width:120px;" type="text"><input name="btnSo" value="搜索" onclick="return CheckProdID();" id="btnSo" class="soBtn" type="submit">
			</div>
			<div class="menu_fill1" style="height: 3px;"></div>
			<div class="clear"></div>
		</div>
		<div class="menuTwo">
			<template>
				<el-tabs v-model="activeName2" type="card" @tab-click="handleClick">
					<el-tab-pane label="全部卖单" name="first">
						<div class="page">
						</div>
						<table class="SaleInfoTable">
							<tbody>
								<tr style="text-align: center;">
									<td style="width: 340px;">商品信息</td>
									<td style="width: 100px;">买家</td>
									<td style="width: 30px;">数量</td>
									<td style="width: 100px;">实付金额</td>
									<td style="width: 100px;">交易状态</td>
									<td style="width: 50px;">售后</td>
									<td style="width: 110px;">操作</td>
								</tr>

							</tbody>
							<tbody v-for="msg in message" :key="msg.index">
								<tr>
									<td colspan="7" style="background-color: #f7f7f7;">
										<span>
                                 <input type="hidden" name="repList$ctl01$HidOrderID" id="repList_HidOrderID_0" value="1542449807138417">
                                 <input type="hidden" name="repList$ctl01$HidStatus" id="repList_HidStatus_0" value="1|1900/1/1 0:00:00|1900/1/1 0:00:00|1900/1/1 0:00:00|0|2018/11/17 18:16:47|2|0|2|0|50.00">
                                 <input style="vertical-align: middle;  disabled='disabled'" type="checkbox">
                             </span> {{msg.dnum}}
										<span class="red">{{msg.onum}}</span><span class="orderdate">{{msg.otime}}{{msg.time}}</span><span class="remark">{{msg.remarks}}</span>
										<span class="historybox"><span class="getHistoryPrice remark" style="color:#3065cf;"><input type="hidden" name="bjOderID" value=""><input type="hidden" name="bjUserID" value="">{{msg.offer}}</span>
										<div class="box-history">
											<div class="bar"><span>{{msg.close}}</span></div>
											<ul>
												<li class="col-user">{{msg.coluse}}</li>
												<li class="col-time">{{msg.timer}}</li>
												<li class="col-price">{{msg.colprice}}</li>
											</ul>
											<ul class="bjother">
												<li class="col-user">{{msg.coluser}}</li>
												<li class="col-time">{{msg.coltime}}</li>
												<li class="col-price">{{msg.colprice}}</li>
											</ul>
										</div>
										</span>
									</td>
								</tr>
								<tr align="center">
									<td align="left">
										<img class="repImg" :src="msg.pic">
										<div class="prodname LinkABlue">
											{{msg.cnum}}<br>
											<a href="http://www.cang.com/shop/2425092.html" target="_blank">
												{{msg.name}}
											</a>
											<div class="GoodsFrom">{{msg.type}}<span class="FromFlag">{{msg.channel}}</span></div>
										</div>
									</td>
									<td class="SaleUser LinkABlue">
										<a href="http://www.cang.com/personal/273500.html" target="_blank">
											{{msg.seller}}</a><br>

									</td>
									<td style="width: 30px; font-weight: 700;">{{msg.gnum}}</td>
									<td style="width: 100px;">
										<span style="font-weight: 700; font-size: 14px;">{{msg.money}}</span><br> {{msg.freight}}
									</td>
									<td class="tradeState" style="width: 100px;">
										<!-- 交易状态 -->
										<div>{{msg.confirm}}</div>
										<div>
											<a href="http://pay.cang.com/myhome/trade/tradeDetail.aspx?orderid=1542355230107806" target="_blank">{{msg.details}}</a>
										</div>
										<div style="display:none;">
											<a href="http://pay.cang.com/myhome/trade/punish.aspx?orderid=1542355230107806&amp;type=0" onclick="return confirm('您是否真的确认投诉，本网建议双方先协商。')">投诉</a>
										</div>
									</td>
									<td style="width: 50px;">
										{{msg.bar}}
									</td>
									<td class="LinkABlue" style="width: 110px;">
										<div>
											<input type="submit" name="repList$ctl01$btnClose" :value="msg.order" onclick="return confirm('您确认关闭此订单，不买了，建议联系一下卖家？');" id="repList_btnClose_0" class="sold-list-btn-2">
										</div>

										<div style="position: relative; width: 100%;">
											<div style="display:none;">
												<a href="http://pay.cang.com/myhome/trade/Apishare.aspx?id=2425092&amp;type=3" target="_blank">分享</a>
											</div>
										</div>
									</td>
								</tr>
							</tbody>
						</table>

						<div class="page">
						</div>
					</el-tab-pane>
					<el-tab-pane label="进行中(0)" name="second">
						<div class="page">
						</div>
						<table class="SaleInfoTable">
							<tbody>
								<tr style="text-align: center;">
									<td style="width: 340px;">商品信息</td>
									<td style="width: 100px;">卖家</td>
									<td style="width: 30px;">数量</td>
									<td style="width: 100px;">实付金额</td>
									<td style="width: 100px;">交易状态</td>
									<td style="width: 50px;">售后</td>
									<td style="width: 110px;">操作</td>
								</tr>
							</tbody>
							<tbody v-for="msg in conductlist" :key="msg.index">
								<tr>
									<td colspan="7" style="background-color: #f7f7f7;">
										<span>
		                                    <input type="hidden" name="repList$ctl01$HidOrderID" id="repList_HidOrderID_0" value="1542449807138417">
		                                    <input type="hidden" name="repList$ctl01$HidStatus" id="repList_HidStatus_0" value="1|1900/1/1 0:00:00|1900/1/1 0:00:00|1900/1/1 0:00:00|0|2018/11/17 18:16:47|2|0|2|0|50.00">
		                                    <input style="vertical-align: middle;  disabled='disabled'" type="checkbox">
		                                </span> {{msg.dnum}}
										<span class="red">{{msg.onum}}</span><span class="orderdate">{{msg.otime}}{{msg.time}}</span><span class="remark">{{msg.remarks}}</span>
										<span class="historybox"><span class="getHistoryPrice remark" style="color:#3065cf;"><input type="hidden" name="bjOderID" value=""><input type="hidden" name="bjUserID" value="">{{msg.offer}}</span>
										<div class="box-history">
											<div class="bar"><span>{{msg.close}}</span></div>
											<ul>
												<li class="col-user">{{msg.coluse}}</li>
												<li class="col-time">{{msg.timer}}</li>
												<li class="col-price">{{msg.colprice}}</li>
											</ul>
											<ul class="bjother">
												<li class="col-user">{{msg.coluser}}</li>
												<li class="col-time">{{msg.coltime}}</li>
												<li class="col-price">{{msg.colprice}}</li>
											</ul>
										</div>
										</span>
									</td>
								</tr>
								<tr align="center">
									<td align="left">
										<img class="repImg" :src="msg.pic">
										<div class="prodname LinkABlue">
											{{msg.cnum}}<br>
											<a href="http://www.cang.com/shop/2425092.html" target="_blank">
												{{msg.name}}
											</a>
											<div class="GoodsFrom">{{msg.type}}<span class="FromFlag">{{msg.channel}}</span></div>
										</div>
									</td>
									<td class="SaleUser LinkABlue">
										<a href="http://www.cang.com/personal/273500.html" target="_blank">
											{{msg.seller}}</a><br>

									</td>
									<td style="width: 30px; font-weight: 700;">{{msg.gnum}}</td>
									<td style="width: 100px;">
										<span style="font-weight: 700; font-size: 14px;">{{msg.money}}</span><br> {{msg.freight}}
									</td>
									<td class="tradeState" style="width: 100px;">
										<!-- 交易状态 -->
										<div>{{msg.confirm}}</div>
										<div>
											<a href="http://pay.cang.com/myhome/trade/tradeDetail.aspx?orderid=1542355230107806" target="_blank">{{msg.details}}</a>
										</div>
										<div style="display:none;">
											<a href="http://pay.cang.com/myhome/trade/punish.aspx?orderid=1542355230107806&amp;type=0" onclick="return confirm('您是否真的确认投诉，本网建议双方先协商。')">投诉</a>
										</div>
									</td>
									<td style="width: 50px;">
										{{msg.bar}}
									</td>
									<td class="LinkABlue" style="width: 110px;">
										<div>
											<input type="submit" name="repList$ctl01$btnClose" :value="msg.order" onclick="return confirm('您确认关闭此订单，不买了，建议联系一下卖家？');" id="repList_btnClose_0" class="sold-list-btn-2">
										</div>

										<div style="position: relative; width: 100%;">
											<div style="display:none;">
												<a href="http://pay.cang.com/myhome/trade/Apishare.aspx?id=2425092&amp;type=3" target="_blank">分享</a>
											</div>
										</div>
									</td>
								</tr>
							</tbody>
						</table>

						<div class="page">
						</div>
					</el-tab-pane>
					<el-tab-pane label="等待确认价格(0)" name="third">
						<div class="page">
						</div>
						<table class="SaleInfoTable">
							<tbody>
								<tr style="text-align: center;">
									<td style="width: 340px;">商品信息</td>
									<td style="width: 100px;">卖家</td>
									<td style="width: 30px;">数量</td>
									<td style="width: 100px;">实付金额</td>
									<td style="width: 100px;">交易状态</td>
									<td style="width: 50px;">售后</td>
									<td style="width: 110px;">操作</td>
								</tr>
							</tbody>
							<tbody v-for="msg in confirmlist" :key="msg.index">
								<tr>
									<td colspan="7" style="background-color: #f7f7f7;">
										<span>
		                                    <input type="hidden" name="repList$ctl01$HidOrderID" id="repList_HidOrderID_0" value="1542449807138417">
		                                    <input type="hidden" name="repList$ctl01$HidStatus" id="repList_HidStatus_0" value="1|1900/1/1 0:00:00|1900/1/1 0:00:00|1900/1/1 0:00:00|0|2018/11/17 18:16:47|2|0|2|0|50.00">
		                                    <input style="vertical-align: middle;  disabled='disabled'" type="checkbox">
		                                </span> {{msg.dnum}}
										<span class="red">{{msg.onum}}</span><span class="orderdate">{{msg.otime}}{{msg.time}}</span><span class="remark">{{msg.remarks}}</span>
										<span class="historybox"><span class="getHistoryPrice remark" style="color:#3065cf;"><input type="hidden" name="bjOderID" value=""><input type="hidden" name="bjUserID" value="">{{msg.offer}}</span>
										<div class="box-history">
											<div class="bar"><span>{{msg.close}}</span></div>
											<ul>
												<li class="col-user">{{msg.coluse}}</li>
												<li class="col-time">{{msg.timer}}</li>
												<li class="col-price">{{msg.colprice}}</li>
											</ul>
											<ul class="bjother">
												<li class="col-user">{{msg.coluser}}</li>
												<li class="col-time">{{msg.coltime}}</li>
												<li class="col-price">{{msg.colprice}}</li>
											</ul>
										</div>
										</span>
									</td>
								</tr>
								<tr align="center">
									<td align="left">
										<img class="repImg" :src="msg.pic">
										<div class="prodname LinkABlue">
											{{msg.cnum}}<br>
											<a href="http://www.cang.com/shop/2425092.html" target="_blank">
												{{msg.name}}
											</a>
											<div class="GoodsFrom">{{msg.type}}<span class="FromFlag">{{msg.channel}}</span></div>
										</div>
									</td>
									<td class="SaleUser LinkABlue">
										<a href="http://www.cang.com/personal/273500.html" target="_blank">
											{{msg.seller}}</a><br>

									</td>
									<td style="width: 30px; font-weight: 700;">{{msg.gnum}}</td>
									<td style="width: 100px;">
										<span style="font-weight: 700; font-size: 14px;">{{msg.money}}</span><br> {{msg.freight}}
									</td>
									<td class="tradeState" style="width: 100px;">
										<!-- 交易状态 -->
										<div>{{msg.confirm}}</div>
										<div>
											<a href="http://pay.cang.com/myhome/trade/tradeDetail.aspx?orderid=1542355230107806" target="_blank">{{msg.details}}</a>
										</div>
										<div style="display:none;">
											<a href="http://pay.cang.com/myhome/trade/punish.aspx?orderid=1542355230107806&amp;type=0" onclick="return confirm('您是否真的确认投诉，本网建议双方先协商。')">投诉</a>
										</div>
									</td>
									<td style="width: 50px;">
										{{msg.bar}}
									</td>
									<td class="LinkABlue" style="width: 110px;">
										<div>
											<input type="submit" name="repList$ctl01$btnClose" :value="msg.order" onclick="return confirm('您确认关闭此订单，不买了，建议联系一下卖家？');" id="repList_btnClose_0" class="sold-list-btn-2">
										</div>

										<div style="position: relative; width: 100%;">
											<div style="display:none;">
												<a href="http://pay.cang.com/myhome/trade/Apishare.aspx?id=2425092&amp;type=3" target="_blank">分享</a>
											</div>
										</div>
									</td>
								</tr>
							</tbody>
						</table>

						<div class="page">
						</div>
					</el-tab-pane>
					<el-tab-pane label="等待买家付款(0)" name="fourth">
						<div class="page">
						</div>
						<table class="SaleInfoTable">
							<tbody>
								<tr style="text-align: center;">
									<td style="width: 340px;">商品信息</td>
									<td style="width: 100px;">卖家</td>
									<td style="width: 30px;">数量</td>
									<td style="width: 100px;">实付金额</td>
									<td style="width: 100px;">交易状态</td>
									<td style="width: 50px;">售后</td>
									<td style="width: 110px;">操作</td>
								</tr>
							</tbody>
							<tbody v-for="msg in paymentlist" :key="msg.index">
								<tr>
									<td colspan="7" style="background-color: #f7f7f7;">
										<span>
		                                    <input type="hidden" name="repList$ctl01$HidOrderID" id="repList_HidOrderID_0" value="1542449807138417">
		                                    <input type="hidden" name="repList$ctl01$HidStatus" id="repList_HidStatus_0" value="1|1900/1/1 0:00:00|1900/1/1 0:00:00|1900/1/1 0:00:00|0|2018/11/17 18:16:47|2|0|2|0|50.00">
		                                    <input style="vertical-align: middle;  disabled='disabled'" type="checkbox">
		                                </span> {{msg.dnum}}
										<span class="red">{{msg.onum}}</span><span class="orderdate">{{msg.otime}}{{msg.time}}</span><span class="remark">{{msg.remarks}}</span>
										<span class="historybox"><span class="getHistoryPrice remark" style="color:#3065cf;"><input type="hidden" name="bjOderID" value=""><input type="hidden" name="bjUserID" value="">{{msg.offer}}</span>
										<div class="box-history">
											<div class="bar"><span>{{msg.close}}</span></div>
											<ul>
												<li class="col-user">{{msg.coluse}}</li>
												<li class="col-time">{{msg.timer}}</li>
												<li class="col-price">{{msg.colprice}}</li>
											</ul>
											<ul class="bjother">
												<li class="col-user">{{msg.coluser}}</li>
												<li class="col-time">{{msg.coltime}}</li>
												<li class="col-price">{{msg.colprice}}</li>
											</ul>
										</div>
										</span>
									</td>
								</tr>
								<tr align="center">
									<td align="left">
										<img class="repImg" :src="msg.pic">
										<div class="prodname LinkABlue">
											{{msg.cnum}}<br>
											<a href="http://www.cang.com/shop/2425092.html" target="_blank">
												{{msg.name}}
											</a>
											<div class="GoodsFrom">{{msg.type}}<span class="FromFlag">{{msg.channel}}</span></div>
										</div>
									</td>
									<td class="SaleUser LinkABlue">
										<a href="http://www.cang.com/personal/273500.html" target="_blank">
											{{msg.seller}}</a><br>

									</td>
									<td style="width: 30px; font-weight: 700;">{{msg.gnum}}</td>
									<td style="width: 100px;">
										<span style="font-weight: 700; font-size: 14px;">{{msg.money}}</span><br> {{msg.freight}}
									</td>
									<td class="tradeState" style="width: 100px;">
										<!-- 交易状态 -->
										<div>{{msg.confirm}}</div>
										<div>
											<a href="http://pay.cang.com/myhome/trade/tradeDetail.aspx?orderid=1542355230107806" target="_blank">{{msg.details}}</a>
										</div>
										<div style="display:none;">
											<a href="http://pay.cang.com/myhome/trade/punish.aspx?orderid=1542355230107806&amp;type=0" onclick="return confirm('您是否真的确认投诉，本网建议双方先协商。')">投诉</a>
										</div>
									</td>
									<td style="width: 50px;">
										{{msg.bar}}
									</td>
									<td class="LinkABlue" style="width: 110px;">
										<div>
											<input type="submit" name="repList$ctl01$btnClose" :value="msg.order" onclick="return confirm('您确认关闭此订单，不买了，建议联系一下卖家？');" id="repList_btnClose_0" class="sold-list-btn-2">
										</div>

										<div style="position: relative; width: 100%;">
											<div style="display:none;">
												<a href="http://pay.cang.com/myhome/trade/Apishare.aspx?id=2425092&amp;type=3" target="_blank">分享</a>
											</div>
										</div>
									</td>
								</tr>
							</tbody>
						</table>

						<div class="page">
						</div>
					</el-tab-pane>
					<el-tab-pane label="等待发货(0)" name="fifth">
						<div class="page">
						</div>
						<table class="SaleInfoTable">
							<tbody>
								<tr style="text-align: center;">
									<td style="width: 340px;">商品信息</td>
									<td style="width: 100px;">卖家</td>
									<td style="width: 30px;">数量</td>
									<td style="width: 100px;">实付金额</td>
									<td style="width: 100px;">交易状态</td>
									<td style="width: 50px;">售后</td>
									<td style="width: 110px;">操作</td>
								</tr>
							</tbody>
							<tbody v-for="msg in goods" :key="msg.index">
								<tr>
									<td colspan="7" style="background-color: #f7f7f7;">
										<span>
		                                    <input type="hidden" name="repList$ctl01$HidOrderID" id="repList_HidOrderID_0" value="1542449807138417">
		                                    <input type="hidden" name="repList$ctl01$HidStatus" id="repList_HidStatus_0" value="1|1900/1/1 0:00:00|1900/1/1 0:00:00|1900/1/1 0:00:00|0|2018/11/17 18:16:47|2|0|2|0|50.00">
		                                    <input style="vertical-align: middle;  disabled='disabled'" type="checkbox">
		                                </span> {{msg.dnum}}
										<span class="red">{{msg.onum}}</span><span class="orderdate">{{msg.otime}}{{msg.time}}</span><span class="remark">{{msg.remarks}}</span>
										<span class="historybox"><span class="getHistoryPrice remark" style="color:#3065cf;"><input type="hidden" name="bjOderID" value=""><input type="hidden" name="bjUserID" value="">{{msg.offer}}</span>
										<div class="box-history">
											<div class="bar"><span>{{msg.close}}</span></div>
											<ul>
												<li class="col-user">{{msg.coluse}}</li>
												<li class="col-time">{{msg.timer}}</li>
												<li class="col-price">{{msg.colprice}}</li>
											</ul>
											<ul class="bjother">
												<li class="col-user">{{msg.coluser}}</li>
												<li class="col-time">{{msg.coltime}}</li>
												<li class="col-price">{{msg.colprice}}</li>
											</ul>
										</div>
										</span>
									</td>
								</tr>
								<tr align="center">
									<td align="left">
										<img class="repImg" :src="msg.pic">
										<div class="prodname LinkABlue">
											{{msg.cnum}}<br>
											<a href="http://www.cang.com/shop/2425092.html" target="_blank">
												{{msg.name}}
											</a>
											<div class="GoodsFrom">{{msg.type}}<span class="FromFlag">{{msg.channel}}</span></div>
										</div>
									</td>
									<td class="SaleUser LinkABlue">
										<a href="http://www.cang.com/personal/273500.html" target="_blank">
											{{msg.seller}}</a><br>

									</td>
									<td style="width: 30px; font-weight: 700;">{{msg.gnum}}</td>
									<td style="width: 100px;">
										<span style="font-weight: 700; font-size: 14px;">{{msg.money}}</span><br> {{msg.freight}}
									</td>
									<td class="tradeState" style="width: 100px;">
										<!-- 交易状态 -->
										<div>{{msg.confirm}}</div>
										<div>
											<a href="http://pay.cang.com/myhome/trade/tradeDetail.aspx?orderid=1542355230107806" target="_blank">{{msg.details}}</a>
										</div>
										<div style="display:none;">
											<a href="http://pay.cang.com/myhome/trade/punish.aspx?orderid=1542355230107806&amp;type=0" onclick="return confirm('您是否真的确认投诉，本网建议双方先协商。')">投诉</a>
										</div>
									</td>
									<td style="width: 50px;">
										{{msg.bar}}
									</td>
									<td class="LinkABlue" style="width: 110px;">
										<div>
											<input type="submit" name="repList$ctl01$btnClose" :value="msg.order" onclick="return confirm('您确认关闭此订单，不买了，建议联系一下卖家？');" id="repList_btnClose_0" class="sold-list-btn-2">
										</div>

										<div style="position: relative; width: 100%;">
											<div style="display:none;">
												<a href="http://pay.cang.com/myhome/trade/Apishare.aspx?id=2425092&amp;type=3" target="_blank">分享</a>
											</div>
										</div>
									</td>
								</tr>
							</tbody>
						</table>

						<div class="page">
						</div>
					</el-tab-pane>
					<el-tab-pane label="已发货(0)" name="sixth">
						<div class="page">
						</div>
						<table class="SaleInfoTable">
							<tbody>
								<tr style="text-align: center;">
									<td style="width: 340px;">商品信息</td>
									<td style="width: 100px;">卖家</td>
									<td style="width: 30px;">数量</td>
									<td style="width: 100px;">实付金额</td>
									<td style="width: 100px;">交易状态</td>
									<td style="width: 50px;">售后</td>
									<td style="width: 110px;">操作</td>
								</tr>
							</tbody>
							<tbody v-for="msg in Inspectionlist" :key="msg.index">
								<tr>
									<td colspan="7" style="background-color: #f7f7f7;">
										<span>
		                                    <input type="hidden" name="repList$ctl01$HidOrderID" id="repList_HidOrderID_0" value="1542449807138417">
		                                    <input type="hidden" name="repList$ctl01$HidStatus" id="repList_HidStatus_0" value="1|1900/1/1 0:00:00|1900/1/1 0:00:00|1900/1/1 0:00:00|0|2018/11/17 18:16:47|2|0|2|0|50.00">
		                                    <input style="vertical-align: middle;  disabled='disabled'" type="checkbox">
		                                </span> {{msg.dnum}}
										<span class="red">{{msg.onum}}</span><span class="orderdate">{{msg.otime}}{{msg.time}}</span><span class="remark">{{msg.remarks}}</span>
										<span class="historybox"><span class="getHistoryPrice remark" style="color:#3065cf;"><input type="hidden" name="bjOderID" value=""><input type="hidden" name="bjUserID" value="">{{msg.offer}}</span>
										<div class="box-history">
											<div class="bar"><span>{{msg.close}}</span></div>
											<ul>
												<li class="col-user">{{msg.coluse}}</li>
												<li class="col-time">{{msg.timer}}</li>
												<li class="col-price">{{msg.colprice}}</li>
											</ul>
											<ul class="bjother">
												<li class="col-user">{{msg.coluser}}</li>
												<li class="col-time">{{msg.coltime}}</li>
												<li class="col-price">{{msg.colprice}}</li>
											</ul>
										</div>
										</span>
									</td>
								</tr>
								<tr align="center">
									<td align="left">
										<img class="repImg" :src="msg.pic">
										<div class="prodname LinkABlue">
											{{msg.cnum}}<br>
											<a href="http://www.cang.com/shop/2425092.html" target="_blank">
												{{msg.name}}
											</a>
											<div class="GoodsFrom">{{msg.type}}<span class="FromFlag">{{msg.channel}}</span></div>
										</div>
									</td>
									<td class="SaleUser LinkABlue">
										<a href="http://www.cang.com/personal/273500.html" target="_blank">
											{{msg.seller}}</a><br>

									</td>
									<td style="width: 30px; font-weight: 700;">{{msg.gnum}}</td>
									<td style="width: 100px;">
										<span style="font-weight: 700; font-size: 14px;">{{msg.money}}</span><br> {{msg.freight}}
									</td>
									<td class="tradeState" style="width: 100px;">
										<!-- 交易状态 -->
										<div>{{msg.confirm}}</div>
										<div>
											<a href="http://pay.cang.com/myhome/trade/tradeDetail.aspx?orderid=1542355230107806" target="_blank">{{msg.details}}</a>
										</div>
										<div style="display:none;">
											<a href="http://pay.cang.com/myhome/trade/punish.aspx?orderid=1542355230107806&amp;type=0" onclick="return confirm('您是否真的确认投诉，本网建议双方先协商。')">投诉</a>
										</div>
									</td>
									<td style="width: 50px;">
										{{msg.bar}}
									</td>
									<td class="LinkABlue" style="width: 110px;">
										<div>
											<input type="submit" name="repList$ctl01$btnClose" :value="msg.order" onclick="return confirm('您确认关闭此订单，不买了，建议联系一下卖家？');" id="repList_btnClose_0" class="sold-list-btn-2">
										</div>

										<div style="position: relative; width: 100%;">
											<div style="display:none;">
												<a href="http://pay.cang.com/myhome/trade/Apishare.aspx?id=2425092&amp;type=3" target="_blank">分享</a>
											</div>
										</div>
									</td>
								</tr>
							</tbody>
						</table>

						<div class="page">
						</div>
					</el-tab-pane>
					<el-tab-pane label="交易成功" name="seventh">
						<div class="page">
						</div>
						<table class="SaleInfoTable">
							<tbody>
								<tr style="text-align: center;">
									<td style="width: 340px;">商品信息</td>
									<td style="width: 100px;">卖家</td>
									<td style="width: 30px;">数量</td>
									<td style="width: 100px;">实付金额</td>
									<td style="width: 100px;">交易状态</td>
									<td style="width: 50px;">售后</td>
									<td style="width: 110px;">操作</td>
								</tr>
							</tbody>
							<tbody v-for="msg in transactionlist" :key="msg.index">
								<tr>
									<td colspan="7" style="background-color: #f7f7f7;">
										<span>
		                                    <input type="hidden" name="repList$ctl01$HidOrderID" id="repList_HidOrderID_0" value="1542449807138417">
		                                    <input type="hidden" name="repList$ctl01$HidStatus" id="repList_HidStatus_0" value="1|1900/1/1 0:00:00|1900/1/1 0:00:00|1900/1/1 0:00:00|0|2018/11/17 18:16:47|2|0|2|0|50.00">
		                                    <input style="vertical-align: middle;  disabled='disabled'" type="checkbox">
		                                </span> {{msg.dnum}}
										<span class="red">{{msg.onum}}</span><span class="orderdate">{{msg.otime}}{{msg.time}}</span><span class="remark">{{msg.remarks}}</span>
										<span class="historybox"><span class="getHistoryPrice remark" style="color:#3065cf;"><input type="hidden" name="bjOderID" value=""><input type="hidden" name="bjUserID" value="">{{msg.offer}}</span>
										<div class="box-history">
											<div class="bar"><span>{{msg.close}}</span></div>
											<ul>
												<li class="col-user">{{msg.coluse}}</li>
												<li class="col-time">{{msg.timer}}</li>
												<li class="col-price">{{msg.colprice}}</li>
											</ul>
											<ul class="bjother">
												<li class="col-user">{{msg.coluser}}</li>
												<li class="col-time">{{msg.coltime}}</li>
												<li class="col-price">{{msg.colprice}}</li>
											</ul>
										</div>
										</span>
									</td>
								</tr>
								<tr align="center">
									<td align="left">
										<img class="repImg" :src="msg.pic">
										<div class="prodname LinkABlue">
											{{msg.cnum}}<br>
											<a href="http://www.cang.com/shop/2425092.html" target="_blank">
												{{msg.name}}
											</a>
											<div class="GoodsFrom">{{msg.type}}<span class="FromFlag">{{msg.channel}}</span></div>
										</div>
									</td>
									<td class="SaleUser LinkABlue">
										<a href="http://www.cang.com/personal/273500.html" target="_blank">
											{{msg.seller}}</a><br>

									</td>
									<td style="width: 30px; font-weight: 700;">{{msg.gnum}}</td>
									<td style="width: 100px;">
										<span style="font-weight: 700; font-size: 14px;">{{msg.money}}</span><br> {{msg.freight}}
									</td>
									<td class="tradeState" style="width: 100px;">
										<!-- 交易状态 -->
										<div>{{msg.confirm}}</div>
										<div>
											<a href="http://pay.cang.com/myhome/trade/tradeDetail.aspx?orderid=1542355230107806" target="_blank">{{msg.details}}</a>
										</div>
										<div style="display:none;">
											<a href="http://pay.cang.com/myhome/trade/punish.aspx?orderid=1542355230107806&amp;type=0" onclick="return confirm('您是否真的确认投诉，本网建议双方先协商。')">投诉</a>
										</div>
									</td>
									<td style="width: 50px;">
										{{msg.bar}}
									</td>
									<td class="LinkABlue" style="width: 110px;">
										<div>
											<input type="submit" name="repList$ctl01$btnClose" :value="msg.order" onclick="return confirm('您确认关闭此订单，不买了，建议联系一下卖家？');" id="repList_btnClose_0" class="sold-list-btn-2">
										</div>

										<div style="position: relative; width: 100%;">
											<div style="display:none;">
												<a href="http://pay.cang.com/myhome/trade/Apishare.aspx?id=2425092&amp;type=3" target="_blank">分享</a>
											</div>
										</div>
									</td>
								</tr>
							</tbody>
						</table>

						<div class="page">
						</div>
					</el-tab-pane>
					<el-tab-pane label="退款中(0)" name="eigth">
						<div class="page">
						</div>
						<table class="SaleInfoTable">
							<tbody>
								<tr style="text-align: center;">
									<td style="width: 340px;">商品信息</td>
									<td style="width: 100px;">卖家</td>
									<td style="width: 30px;">数量</td>
									<td style="width: 100px;">实付金额</td>
									<td style="width: 100px;">交易状态</td>
									<td style="width: 50px;">售后</td>
									<td style="width: 110px;">操作</td>
								</tr>
							</tbody>
							<tbody v-for="msg in refundlist" :key="msg.index">
								<tr>
									<td colspan="7" style="background-color: #f7f7f7;">
										<span>
		                                    <input type="hidden" name="repList$ctl01$HidOrderID" id="repList_HidOrderID_0" value="1542449807138417">
		                                    <input type="hidden" name="repList$ctl01$HidStatus" id="repList_HidStatus_0" value="1|1900/1/1 0:00:00|1900/1/1 0:00:00|1900/1/1 0:00:00|0|2018/11/17 18:16:47|2|0|2|0|50.00">
		                                    <input style="vertical-align: middle;  disabled='disabled'" type="checkbox">
		                                </span> {{msg.dnum}}
										<span class="red">{{msg.onum}}</span><span class="orderdate">{{msg.otime}}{{msg.time}}</span><span class="remark">{{msg.remarks}}</span>
										<span class="historybox"><span class="getHistoryPrice remark" style="color:#3065cf;"><input type="hidden" name="bjOderID" value=""><input type="hidden" name="bjUserID" value="">{{msg.offer}}</span>
										<div class="box-history">
											<div class="bar"><span>{{msg.close}}</span></div>
											<ul>
												<li class="col-user">{{msg.coluse}}</li>
												<li class="col-time">{{msg.timer}}</li>
												<li class="col-price">{{msg.colprice}}</li>
											</ul>
											<ul class="bjother">
												<li class="col-user">{{msg.coluser}}</li>
												<li class="col-time">{{msg.coltime}}</li>
												<li class="col-price">{{msg.colprice}}</li>
											</ul>
										</div>
										</span>
									</td>
								</tr>
								<tr align="center">
									<td align="left">
										<img class="repImg" :src="msg.pic">
										<div class="prodname LinkABlue">
											{{msg.cnum}}<br>
											<a href="http://www.cang.com/shop/2425092.html" target="_blank">
												{{msg.name}}
											</a>
											<div class="GoodsFrom">{{msg.type}}<span class="FromFlag">{{msg.channel}}</span></div>
										</div>
									</td>
									<td class="SaleUser LinkABlue">
										<a href="http://www.cang.com/personal/273500.html" target="_blank">
											{{msg.seller}}</a><br>

									</td>
									<td style="width: 30px; font-weight: 700;">{{msg.gnum}}</td>
									<td style="width: 100px;">
										<span style="font-weight: 700; font-size: 14px;">{{msg.money}}</span><br> {{msg.freight}}
									</td>
									<td class="tradeState" style="width: 100px;">
										<!-- 交易状态 -->
										<div>{{msg.confirm}}</div>
										<div>
											<a href="http://pay.cang.com/myhome/trade/tradeDetail.aspx?orderid=1542355230107806" target="_blank">{{msg.details}}</a>
										</div>
										<div style="display:none;">
											<a href="http://pay.cang.com/myhome/trade/punish.aspx?orderid=1542355230107806&amp;type=0" onclick="return confirm('您是否真的确认投诉，本网建议双方先协商。')">投诉</a>
										</div>
									</td>
									<td style="width: 50px;">
										{{msg.bar}}
									</td>
									<td class="LinkABlue" style="width: 110px;">
										<div>
											<input type="submit" name="repList$ctl01$btnClose" :value="msg.order" onclick="return confirm('您确认关闭此订单，不买了，建议联系一下卖家？');" id="repList_btnClose_0" class="sold-list-btn-2">
										</div>

										<div style="position: relative; width: 100%;">
											<div style="display:none;">
												<a href="http://pay.cang.com/myhome/trade/Apishare.aspx?id=2425092&amp;type=3" target="_blank">分享</a>
											</div>
										</div>
									</td>
								</tr>
							</tbody>
						</table>

						<div class="page">
						</div>
					</el-tab-pane>
					<el-tab-pane label="需要评价(0)" name="ninth">
						<div class="page">
						</div>
						<table class="SaleInfoTable">
							<tbody>
								<tr style="text-align: center;">
									<td style="width: 340px;">商品信息</td>
									<td style="width: 100px;">卖家</td>
									<td style="width: 30px;">数量</td>
									<td style="width: 100px;">实付金额</td>
									<td style="width: 100px;">交易状态</td>
									<td style="width: 50px;">售后</td>
									<td style="width: 110px;">操作</td>
								</tr>
							</tbody>
							<tbody v-for="msg in evaluatelist" :key="msg.index">
								<tr>
									<td colspan="7" style="background-color: #f7f7f7;">
										<span>
		                                    <input type="hidden" name="repList$ctl01$HidOrderID" id="repList_HidOrderID_0" value="1542449807138417">
		                                    <input type="hidden" name="repList$ctl01$HidStatus" id="repList_HidStatus_0" value="1|1900/1/1 0:00:00|1900/1/1 0:00:00|1900/1/1 0:00:00|0|2018/11/17 18:16:47|2|0|2|0|50.00">
		                                    <input style="vertical-align: middle;  disabled='disabled'" type="checkbox">
		                                </span> {{msg.dnum}}
										<span class="red">{{msg.onum}}</span><span class="orderdate">{{msg.otime}}{{msg.time}}</span><span class="remark">{{msg.remarks}}</span>
										<span class="historybox"><span class="getHistoryPrice remark" style="color:#3065cf;"><input type="hidden" name="bjOderID" value=""><input type="hidden" name="bjUserID" value="">{{msg.offer}}</span>
										<div class="box-history">
											<div class="bar"><span>{{msg.close}}</span></div>
											<ul>
												<li class="col-user">{{msg.coluse}}</li>
												<li class="col-time">{{msg.timer}}</li>
												<li class="col-price">{{msg.colprice}}</li>
											</ul>
											<ul class="bjother">
												<li class="col-user">{{msg.coluser}}</li>
												<li class="col-time">{{msg.coltime}}</li>
												<li class="col-price">{{msg.colprice}}</li>
											</ul>
										</div>
										</span>
									</td>
								</tr>
								<tr align="center">
									<td align="left">
										<img class="repImg" :src="msg.pic">
										<div class="prodname LinkABlue">
											{{msg.cnum}}<br>
											<a href="http://www.cang.com/shop/2425092.html" target="_blank">
												{{msg.name}}
											</a>
											<div class="GoodsFrom">{{msg.type}}<span class="FromFlag">{{msg.channel}}</span></div>
										</div>
									</td>
									<td class="SaleUser LinkABlue">
										<a href="http://www.cang.com/personal/273500.html" target="_blank">
											{{msg.seller}}</a><br>

									</td>
									<td style="width: 30px; font-weight: 700;">{{msg.gnum}}</td>
									<td style="width: 100px;">
										<span style="font-weight: 700; font-size: 14px;">{{msg.money}}</span><br> {{msg.freight}}
									</td>
									<td class="tradeState" style="width: 100px;">
										<!-- 交易状态 -->
										<div>{{msg.confirm}}</div>
										<div>
											<a href="http://pay.cang.com/myhome/trade/tradeDetail.aspx?orderid=1542355230107806" target="_blank">{{msg.details}}</a>
										</div>
										<div style="display:none;">
											<a href="http://pay.cang.com/myhome/trade/punish.aspx?orderid=1542355230107806&amp;type=0" onclick="return confirm('您是否真的确认投诉，本网建议双方先协商。')">投诉</a>
										</div>
									</td>
									<td style="width: 50px;">
										{{msg.bar}}
									</td>
									<td class="LinkABlue" style="width: 110px;">
										<div>
											<input type="submit" name="repList$ctl01$btnClose" :value="msg.order" onclick="return confirm('您确认关闭此订单，不买了，建议联系一下卖家？');" id="repList_btnClose_0" class="sold-list-btn-2">
										</div>

										<div style="position: relative; width: 100%;">
											<div style="display:none;">
												<a href="http://pay.cang.com/myhome/trade/Apishare.aspx?id=2425092&amp;type=3" target="_blank">分享</a>
											</div>
										</div>
									</td>
								</tr>
							</tbody>
						</table>

						<div class="page">
						</div>
					</el-tab-pane>
				</el-tabs>
			</template>
		</div>
	</div>
</template>

<script>
	import '~/assets/css/Custom.css'
	import soldApi from '~/api/soldlist'
	export default {
		data() {
			return {
				message: [],
				conductlist: [],
				confirmlist: [],
				paymentlist: [],
				goods: [],
				Inspectionlist: [],
				transactionlist: [],
				refundlist: [],
				evaluatelist: [],
				activeName2: 'first'
			}
		},
		methods: {
			handleClick(tab, event) {
				console.log(tab, event);

			}
		},
		created: function() {
			//			我的卖单-全部卖单
			soldApi.AllList().then(res => {

				this.message = res.data.boughtlist
			})
			//			我的卖单-进行中
			soldApi.Conduct().then(res => {

				this.conductlist = res.data.conductlist
			})
			//			我的卖单-等待确认价格
			soldApi.WConfirm().then(res => {

				this.confirmlist = res.data.confirmlist
			})
			//			我的卖单-等待付款
			soldApi.WPayment().then(res => {

				this.paymentlist = res.data.paymentlist
			})
			//			我的卖单-等待发货
			soldApi.Wgoods().then(res => {

				this.goods = res.data.goodslist
			})
			//			我的卖单-等待验货
			soldApi.WInspection().then(res => {

				this.Inspectionlist = res.data.Inspectionlist
			})
			//			我的卖单-交易成功
			soldApi.Successtrade().then(res => {

				this.transactionlist = res.data.transactionlist
			})
			//			我的卖单-退款
			soldApi.refund().then(res => {

				this.refundlist = res.data.refundlist
			})
			//			我的卖单-需要评价
			soldApi.evaluate().then(res => {

				this.evaluatelist = res.data.evaluatelist
			})
			
		}
	}
</script>

<style>
	.getHistoryPrice {
		cursor: pointer;
		margin-left: 10px;
		margin-right: 10px;
	}
	
	.remark {
		float: right;
	}
	
	.box-history {
		width: 310px;
		border: 1px solid #b4b4b4;
		background: #ffffff;
		position: absolute;
		top: 5px;
		right: 90px;
		z-index: 9999;
		display: none;
	}
	
	.box-history ul {
		zoom: 1;
		overflow: hidden;
	}
	
	.box-history ul.bjother {
		color: #0066FF;
	}
	
	.box-history .bar {
		background: #666666;
		height: 25px;
		line-height: 25px;
	}
	
	.box-history .bar span {
		float: right;
		color: white;
		margin-right: 5px;
	}
	
	.col-user {
		width: 60px;
		float: left;
		padding: 5px;
	}
	
	.col-time {
		width: 140px;
		float: left;
		padding: 5px;
	}
	
	.col-price {
		width: 78px;
		float: left;
		padding: 5px;
	}
	
	.bar span {
		cursor: pointer;
	}
	
	.SaleInfoTable .historybox {
		position: relative;
		float: right;
	}
	/*  我的买单-订单end  */
	/* 修改侧导航tab栏切换的背景颜色 */
	
	.is-scrollable .el-tabs__nav-scroll {
		background: #f7f7f7;
	}
	/* 删除侧导航tab栏切换头部出现的下边框*/
	
	.el-tabs--card>.el-tabs__header {
		border-bottom: none;
	}
	/* 修改侧导航tab栏切换下的内边距 */
	
	.el-tabs__header .is-scrollable {
		padding: 6px 9px;
	}
	/* 修改侧导航tab栏点击切换下的字体颜色 */
	
	.el-tabs__nav .is-active {
		color: #e4393c;
	}
	/* 修改侧导航tab栏点击切换时每个下边框的颜色 */
	
	.el-tabs--card>.el-tabs__header .el-tabs__item.is-active {
		border-bottom-color: #e4393c;
	}
	/* 修改侧导航tab栏hover时字体的颜色 */
	
	.el-tabs__nav .el-tabs__item:hover {
		color: #e4393c;
	}
	/* 修改侧导航头部外边距 */
	
	.el-tabs__header {
		margin: 0px;
	}
	/* 添加侧导航头部下边框 */
	
	.el-tabs--card>.el-tabs__header .el-tabs__nav {
		border-bottom: 1px solid #e4e7ed;
	}
	/* 修改侧导航内边距 */
	
	.el-tabs__item {
		padding: 0 11.4px;
	}
	/* 修改侧导航头部点击时背景色 */
	
	.el-tabs__active-bar {
		background-color: #e4393c;
	}
	/* 修改侧导航tab栏切换的左边距 */
	
	.pl .el-tabs__nav {
		left: 4%;
	}
	/* 修改侧导航tab栏切换的左边距 */
	/*  修改element ui 所有tab切换样式 end */
	/*合并付款*/
	
	.page {
		height: 27px;
	}
	
	.boughtPay {
		position: absolute;
		top: 0;
		left: 0;
		z-index: 2;
		color: #666;
		clear: both;
	}
	
	.boughtPay .payBtn {
		float: none;
		display: inline-block;
		width: 98px;
		text-align: center;
	}
	
	.payBtn {
		display: block;
		float: left;
		margin: 10px 10px 0;
		padding: 8px 0;
		background-color: #f2f2f2;
		border-radius: 3px;
		color: #666;
		font: 12px "SimSun", "SimHei", "Arial", "sans-serif";
		border: 1px solid #ccc;
	}
	/*合并付款end*/
</style>