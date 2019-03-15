<!-- 交易系统  -->
<!--我的买单-->
<template>
	<div class="mright bought_list">

		<div class="menu">
			<a href="#" class="menu_n menu_y"><span>我的买单</span></a>
			<div style="position:relative;width: 400px; height: 30px; margin-top: 19px; float: right;">
				<select name="ddlType" id="ddlType" class="soddlstyle" style="float: left; margin-right: 3px;">
					<option selected="selected" value="0">最近订单</option>
					<option value="1">历史订单</option>

				</select>
				<select name="ddlSoType" id="ddlSoType" class="soddlstyle">
					<option value="1" selected="selected">商品号</option>
					<option value="4">商品名</option>
					<option value="2">订单号</option>
					<option value="3">卖家名</option>

				</select><input name="txtKey" maxlength="30" id="txtKey" class="sotxt" style="width:120px;" type="text"><input name="btnSo" value="搜索" onclick="return CheckProdID();" id="btnSo" class="soBtn" type="submit">
			</div>
			<div class="menu_fill1" style="height: 3px;"></div>
			<div class="clear"></div>
		</div>
		<div class="menuTwo">
			<template>
				<el-tabs v-model="activeName2" type="card" @tab-click="handleClick">
					<el-tab-pane label="全部买单" name="first">
						<div class="page">
							<div class="boughtPay">

								<input class="mergeorders payBtn" value="合并付款（0）" type="button">

							</div>
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
							<tbody v-for="msg in message" :key="msg.id">
								<tr>
									<td colspan="7" style="background-color: #f7f7f7;">
										<span>
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
											<a href="#" target="_blank">
												{{msg.name}}
											</a>
											<div class="GoodsFrom">{{msg.type}}<span class="FromFlag">{{msg.channel}}</span></div>
										</div>
									</td>
									<td class="SaleUser LinkABlue">
										<a href="#" target="_blank">
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
											<a href="#" target="_blank">{{msg.details}}</a>
										</div>
										<div style="display:none;">
											<a href="#" onclick="return confirm('您是否真的确认投诉，本网建议双方先协商。')">投诉</a>
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
												<a href="#" target="_blank">分享</a>
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
							<tbody v-for="msg in conductlist" :key="msg.id">
								<tr>
									<td colspan="7" style="background-color: #f7f7f7;">
										<span>
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
											<a href="#" target="_blank">
												{{msg.name}}
											</a>
											<div class="GoodsFrom">{{msg.type}}<span class="FromFlag">{{msg.channel}}</span></div>
										</div>
									</td>
									<td class="SaleUser LinkABlue">
										<a href="#" target="_blank">
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
											<a href="#" target="_blank">{{msg.details}}</a>
										</div>
										<div style="display:none;">
											<a href="#" onclick="return confirm('您是否真的确认投诉，本网建议双方先协商。')">投诉</a>
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
												<a href="#" target="_blank">分享</a>
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
							<tbody v-for="msg in confirmlist" :key="msg.id">
								<tr>
									<td colspan="7" style="background-color: #f7f7f7;">
										<span>
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
											<a href="#" target="_blank">
												{{msg.name}}
											</a>
											<div class="GoodsFrom">{{msg.type}}<span class="FromFlag">{{msg.channel}}</span></div>
										</div>
									</td>
									<td class="SaleUser LinkABlue">
										<a href="#" target="_blank">
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
											<a href="#" target="_blank">{{msg.details}}</a>
										</div>
										<div style="display:none;">
											<a href="#" onclick="return confirm('您是否真的确认投诉，本网建议双方先协商。')">投诉</a>
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
												<a href="#" target="_blank">分享</a>
											</div>
										</div>
									</td>
								</tr>
							</tbody>
						</table>

						<div class="page">
						</div>
					</el-tab-pane>
					<el-tab-pane label="等待付款(0)" name="fourth">
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
							<tbody v-for="msg in paymentlist" :key="msg.id">
								<tr>
									<td colspan="7" style="background-color: #f7f7f7;">
										<span>
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
											<a href="#" target="_blank">
												{{msg.name}}
											</a>
											<div class="GoodsFrom">{{msg.type}}<span class="FromFlag">{{msg.channel}}</span></div>
										</div>
									</td>
									<td class="SaleUser LinkABlue">
										<a href="#" target="_blank">
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
											<a href="#" target="_blank">{{msg.details}}</a>
										</div>
										<div style="display:none;">
											<a href="#" onclick="return confirm('您是否真的确认投诉，本网建议双方先协商。')">投诉</a>
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
												<a href="#" target="_blank">分享</a>
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
							<tbody v-for="msg in goods" :key="msg.id">
								<tr>
									<td colspan="7" style="background-color: #f7f7f7;">
										<span>
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
											<a href="#" target="_blank">
												{{msg.name}}
											</a>
											<div class="GoodsFrom">{{msg.type}}<span class="FromFlag">{{msg.channel}}</span></div>
										</div>
									</td>
									<td class="SaleUser LinkABlue">
										<a href="#" target="_blank">
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
											<a href="#" target="_blank">{{msg.details}}</a>
										</div>
										<div style="display:none;">
											<a href="#" onclick="return confirm('您是否真的确认投诉，本网建议双方先协商。')">投诉</a>
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
												<a href="#" target="_blank">分享</a>
											</div>
										</div>
									</td>
								</tr>
							</tbody>
						</table>

						<div class="page">
						</div>
					</el-tab-pane>
					<el-tab-pane label="等待验货确认(0)" name="sixth">
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
							<tbody v-for="msg in Inspectionlist" :key="msg.id">
								<tr>
									<td colspan="7" style="background-color: #f7f7f7;">
										<span>
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
											<a href="#" target="_blank">
												{{msg.name}}
											</a>
											<div class="GoodsFrom">{{msg.type}}<span class="FromFlag">{{msg.channel}}</span></div>
										</div>
									</td>
									<td class="SaleUser LinkABlue">
										<a href="#" target="_blank">
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
											<a href="#" target="_blank">{{msg.details}}</a>
										</div>
										<div style="display:none;">
											<a href="#" onclick="return confirm('您是否真的确认投诉，本网建议双方先协商。')">投诉</a>
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
												<a href="#" target="_blank">分享</a>
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
							<tbody v-for="msg in transactionlist" :key="msg.id">
								<tr>
									<td colspan="7" style="background-color: #f7f7f7;">
										<span>
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
											<a href="#" target="_blank">
												{{msg.name}}
											</a>
											<div class="GoodsFrom">{{msg.type}}<span class="FromFlag">{{msg.channel}}</span></div>
										</div>
									</td>
									<td class="SaleUser LinkABlue">
										<a href="#" target="_blank">
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
											<a href="#" target="_blank">{{msg.details}}</a>
										</div>
										<div style="display:none;">
											<a href="#" onclick="return confirm('您是否真的确认投诉，本网建议双方先协商。')">投诉</a>
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
												<a href="#" target="_blank">分享</a>
											</div>
										</div>
									</td>
								</tr>
							</tbody>
						</table>

						<div class="page">
						</div>
					</el-tab-pane>
					<el-tab-pane label="退款中(0)" name="eighth">
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
							<tbody v-for="msg in refundlist" :key="msg.id">
								<tr>
									<td colspan="7" style="background-color: #f7f7f7;">
										<span>
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
											<a href="#" target="_blank">
												{{msg.name}}
											</a>
											<div class="GoodsFrom">{{msg.type}}<span class="FromFlag">{{msg.channel}}</span></div>
										</div>
									</td>
									<td class="SaleUser LinkABlue">
										<a href="#" target="_blank">
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
											<a href="#" target="_blank">{{msg.details}}</a>
										</div>
										<div style="display:none;">
											<a href="#" onclick="return confirm('您是否真的确认投诉，本网建议双方先协商。')">投诉</a>
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
												<a href="#" target="_blank">分享</a>
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
							<tbody v-for="msg in evaluatelist" :key="msg.id">
								<tr>
									<td colspan="7" style="background-color: #f7f7f7;">
										<span>
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
											<a href="#" target="_blank">
												{{msg.name}}
											</a>
											<div class="GoodsFrom">{{msg.type}}<span class="FromFlag">{{msg.channel}}</span></div>
										</div>
									</td>
									<td class="SaleUser LinkABlue">
										<a href="#" target="_blank">
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
											<a href="#" target="_blank">{{msg.details}}</a>
										</div>
										<div style="display:none;">
											<a href="#" onclick="return confirm('您是否真的确认投诉，本网建议双方先协商。')">投诉</a>
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
												<a href="#" target="_blank">分享</a>
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
	import { getData } from '~/plugins/axios.js'
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
			handleClick(tab, event) {}
		},
		created: function() {
			//			我的买单-全部买单
			getData('mock/5bee927124e7ee36667dbb0f/trade/#boughtlist', 'get').then(res => {

				this.message = res.data.boughtlist
			}), err => {
				console.log(err)
			}
			//			我的买单-进行中
			getData('mock/5bee927124e7ee36667dbb0f/trade/conduct#conductlist', 'get').then(res => {

				this.conductlist = res.data.conductlist
			}), err => {
				console.log(err)
			}
			//			我的买单-等待确认价格
			getData('mock/5bee927124e7ee36667dbb0f/trade/confirm', 'get').then(res => {

				this.confirmlist = res.data.confirmlist
			}), err => {
				console.log(err)
			}	
			//			我的买单-等待付款
			getData('mock/5bee927124e7ee36667dbb0f/trade/payment', 'get').then(res => {

				this.paymentlist = res.data.paymentlist
			}), err => {
				console.log(err)
			}	
			//			我的买单-等待发货
			getData('mock/5bf796ef90fa7f6162070f84/trade_sale/goods', 'get').then(res => {

				this.goods = res.data.goodslist
			}), err => {
				console.log(err)
			}	
			//			我的买单-等待验货
			getData('mock/5bee927124e7ee36667dbb0f/trade/Inspection', 'get').then(res => {

				this.Inspectionlist = res.data.Inspectionlist
			}), err => {
				console.log(err)
			}
			//			我的买单-交易成功
			getData('mock/5bee927124e7ee36667dbb0f/trade/transaction', 'get').then(res => {

				this.transactionlist = res.data.transactionlist
			}), err => {
				console.log(err)
			}
			//			我的买单-退款
			getData('mock/5bee927124e7ee36667dbb0f/trade/refund', 'get').then(res => {

				this.refundlist = res.data.refundlist
			}), err => {
				console.log(err)
			}	
			//			我的买单-需要评价
			getData('mock/5bee927124e7ee36667dbb0f/trade/evaluate', 'get').then(res => {

				this.evaluatelist = res.data.evaluatelist
			}), err => {
				console.log(err)
			}				
		}
	}
</script>

<style>
	/*  我的买单-订单  */
	
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