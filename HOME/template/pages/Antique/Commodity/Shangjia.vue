<!-- 上架商品begin -->
<template id="Shangjia">
	<el-tabs v-model="activeName" @tab-click="handleClick">
		<el-tab-pane label="全部商品" name="first">
			<table id="table" width="100%" cellpadding="0" cellspacing="1" class="shop_tbl" bgcolor="#e5e5e5">
				<tr class="bg">

					<th style="width:120px;background-color:#FFF;">图片</th>
					<th bgcolor="#FFFFFF">商品信息</th>
					<th style="width:90px;background-color:#FFF;">商城归属</th>
					<th style="width:100px;background-color:#FFF;">价格</th>
					<th style="width:160px;background-color:#FFF;">售况/更新/置顶</th>
					<th style="width:210px;background-color:#FFF;">操作</th>
				</tr>

				<tr v-for="msg in list" :key="msg.index">

					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<a href="http://www.cang.com/shop/2439963.html" target="_blank"><img :src="msg.pic" class="Img100" /></a>
					</td>
					<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						
							<div class="shop_cz_ifb" style="line-height:20px;height:auto;">
								<a href="http://www.cang.com/shop/2439963.html" target="_blank" class="col65 b">盘子</a>
							</div>
							编号：{{msg.number}}<br /> 类别：
							<a class="f_gr" href="http://www.cang.com/shop/2439963.html" target="_blank">[{{msg.type}}]</a>
							<br /> 上传时间:{{msg.time}}
						
					</td>
					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<a href="http://www.cang.com/shop/2439963.html" target="_blank">{{msg.name}}</a>
					</td>
					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<input type="text" id="txtPrice2439963" maxlength="7" onChange="if(this.value.replace(/[^\d]/g,'')!=''){this.value=parseInt(this.value.replace(/[^\d]/g,''),10);}else{this.value='0';}" onkeyup="if(this.value.replace(/[^\d]/g,'')!=''){this.value=parseInt(this.value.replace(/[^\d]/g,''),10);}else{this.value='';}" onblur="if(this.value.replace(/[^\d]/g,'')==''){this.value='0'}" class="txtPrice" value="100000" style="width:80px;" /><br />
						<input type="button" name="button" id="button" class="btn_blue" value="修改" onclick="goods_action(2439963,'user_price')" />
					</td>
					<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						<p>售况：<span class="red">{{msg.sale}} </span><br /> 更新:
							<span class="f_gr">{{msg.update}}</span><br /> 置顶:
							<span class="f_gr">{{msg.roof}}</span></p>
					</td>
					<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						<p>
							<a href="javascript:void(0)" onclick="prod_edit(2439963,3)" class="f_gr">更新商品时间</a>
							<a href="http://news.cang.com/infos/201401/294794.html" target="_blank" style="margin-left:15px;font-weight:bold;color:#0063AF;">?</a><br />
							<a href='javascript:void(0)' onclick='alert("已经为待售状态!")' class='btn_aNo1'>待售</a>
							|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_ding")'>已定</a>
							|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_sale")'>已售</a>
							|
							<a href="javascript:void(0)" class="btn_a1" onclick="ProdTG(2439963)">推广</a><br />
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_zhiding")'>
								置顶</a>|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_tuijian")'>
								推荐
							</a>|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_ProdGood")'>
								镇店之宝</a><br />
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_xiajia")'>
								下架</a>|
							<a href='ShopProd_M.aspx?id=2439963' class='btn_a1'>编辑</a>|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_del")'>删除</a>
						</p>
					</td>
				</tr>

			</table>

		</el-tab-pane>
		<el-tab-pane label="待售商品" name="second">
			<table id="table" width="100%" cellpadding="0" cellspacing="1" class="shop_tbl" bgcolor="#e5e5e5">
				<tr class="bg">

					<th style="width:120px;background-color:#FFF;">图片</th>
					<th bgcolor="#FFFFFF">商品信息</th>
					<th style="width:90px;background-color:#FFF;">商城归属</th>
					<th style="width:100px;background-color:#FFF;">价格</th>
					<th style="width:160px;background-color:#FFF;">售况/更新/置顶</th>
					<th style="width:210px;background-color:#FFF;">操作</th>
				</tr>

				<tr v-for="msg in list1" :key="msg.index">

					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<a href="http://www.cang.com/shop/2439963.html" target="_blank"><img :src="msg.pic" class="Img100" /></a>
					</td>
					<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						
							<div class="shop_cz_ifb" style="line-height:20px;height:auto;">
								<a href="http://www.cang.com/shop/2439963.html" target="_blank" class="col65 b">盘子</a>
							</div>
							编号：{{msg.number}}<br /> 类别：
							<a class="f_gr" href="http://www.cang.com/shop/2439963.html" target="_blank">[{{msg.type}}]</a>
							<br /> 上传时间:{{msg.time}}
						
					</td>
					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<a href="http://www.cang.com/shop/2439963.html" target="_blank">{{msg.name}}</a>
					</td>
					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<input type="text" id="txtPrice2439963" maxlength="7" onChange="if(this.value.replace(/[^\d]/g,'')!=''){this.value=parseInt(this.value.replace(/[^\d]/g,''),10);}else{this.value='0';}" onkeyup="if(this.value.replace(/[^\d]/g,'')!=''){this.value=parseInt(this.value.replace(/[^\d]/g,''),10);}else{this.value='';}" onblur="if(this.value.replace(/[^\d]/g,'')==''){this.value='0'}" class="txtPrice" value="100000" style="width:80px;" /><br />
						<input type="button" name="button" id="button" class="btn_blue" value="修改" onclick="goods_action(2439963,'user_price')" />
					</td>
					<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						<p>售况：<span class="red">{{msg.sale}} </span><br /> 更新:
							<span class="f_gr">{{msg.update}}</span><br /> 置顶:
							<span class="f_gr">{{msg.roof}}</span></p>
					</td>
					<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						<p>
							<a href="javascript:void(0)" onclick="prod_edit(2439963,3)" class="f_gr">更新商品时间</a>
							<a href="http://news.cang.com/infos/201401/294794.html" target="_blank" style="margin-left:15px;font-weight:bold;color:#0063AF;">?</a><br />
							<a href='javascript:void(0)' onclick='alert("已经为待售状态!")' class='btn_aNo1'>待售</a>
							|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_ding")'>已定</a>
							|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_sale")'>已售</a>
							|
							<a href="javascript:void(0)" class="btn_a1" onclick="ProdTG(2439963)">推广</a><br />
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_zhiding")'>
								置顶</a>|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_tuijian")'>
								推荐
							</a>|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_ProdGood")'>
								镇店之宝</a><br />
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_xiajia")'>
								下架</a>|
							<a href='ShopProd_M.aspx?id=2439963' class='btn_a1'>编辑</a>|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_del")'>删除</a>
						</p>
					</td>
				</tr>

			</table>
		</el-tab-pane>
		<el-tab-pane label="已定商品" name="third">
			<table id="table" width="100%" cellpadding="0" cellspacing="1" class="shop_tbl" bgcolor="#e5e5e5">
				<tr class="bg">

					<th style="width:120px;background-color:#FFF;">图片</th>
					<th bgcolor="#FFFFFF">商品信息</th>
					<th style="width:90px;background-color:#FFF;">商城归属</th>
					<th style="width:100px;background-color:#FFF;">价格</th>
					<th style="width:160px;background-color:#FFF;">售况/更新/置顶</th>
					<th style="width:210px;background-color:#FFF;">操作</th>
				</tr>

				<tr v-for="msg in list2" :key="msg.index">

					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<a href="http://www.cang.com/shop/2439963.html" target="_blank"><img :src="msg.pic" class="Img100" /></a>
					</td>
					<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						
							<div class="shop_cz_ifb" style="line-height:20px;height:auto;">
								<a href="http://www.cang.com/shop/2439963.html" target="_blank" class="col65 b">盘子</a>
							</div>
							编号：{{msg.number}}<br /> 类别：
							<a class="f_gr" href="http://www.cang.com/shop/2439963.html" target="_blank">[{{msg.type}}]</a>
							<br /> 上传时间:{{msg.time}}
						
					</td>
					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<a href="http://www.cang.com/shop/2439963.html" target="_blank">{{msg.name}}</a>
					</td>
					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<input type="text" id="txtPrice2439963" maxlength="7" onChange="if(this.value.replace(/[^\d]/g,'')!=''){this.value=parseInt(this.value.replace(/[^\d]/g,''),10);}else{this.value='0';}" onkeyup="if(this.value.replace(/[^\d]/g,'')!=''){this.value=parseInt(this.value.replace(/[^\d]/g,''),10);}else{this.value='';}" onblur="if(this.value.replace(/[^\d]/g,'')==''){this.value='0'}" class="txtPrice" value="100000" style="width:80px;" /><br />
						<input type="button" name="button" id="button" class="btn_blue" value="修改" onclick="goods_action(2439963,'user_price')" />
					</td>
					<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						<p>售况：<span class="red">{{msg.sale}} </span><br /> 更新:
							<span class="f_gr">{{msg.update}}</span><br /> 置顶:
							<span class="f_gr">{{msg.roof}}</span></p>
					</td>
					<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						<p>
							<a href="javascript:void(0)" onclick="prod_edit(2439963,3)" class="f_gr">更新商品时间</a>
							<a href="http://news.cang.com/infos/201401/294794.html" target="_blank" style="margin-left:15px;font-weight:bold;color:#0063AF;">?</a><br />
							<a href='javascript:void(0)' onclick='alert("已经为待售状态!")' class='btn_aNo1'>待售</a>
							|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_ding")'>已定</a>
							|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_sale")'>已售</a>
							|
							<a href="javascript:void(0)" class="btn_a1" onclick="ProdTG(2439963)">推广</a><br />
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_zhiding")'>
								置顶</a>|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_tuijian")'>
								推荐
							</a>|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_ProdGood")'>
								镇店之宝</a><br />
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_xiajia")'>
								下架</a>|
							<a href='ShopProd_M.aspx?id=2439963' class='btn_a1'>编辑</a>|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_del")'>删除</a>
						</p>
					</td>
				</tr>

			</table>
		</el-tab-pane>
		<el-tab-pane label="已售商品" name="fourth">
			<table id="table" width="100%" cellpadding="0" cellspacing="1" class="shop_tbl" bgcolor="#e5e5e5">
				<tr class="bg">

					<th style="width:120px;background-color:#FFF;">图片</th>
					<th bgcolor="#FFFFFF">商品信息</th>
					<th style="width:90px;background-color:#FFF;">商城归属</th>
					<th style="width:100px;background-color:#FFF;">价格</th>
					<th style="width:160px;background-color:#FFF;">售况/更新/置顶</th>
					<th style="width:210px;background-color:#FFF;">操作</th>
				</tr>

				<tr v-for="msg in list3" :key="msg.index">

					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<a href="http://www.cang.com/shop/2439963.html" target="_blank"><img :src="msg.pic" class="Img100" /></a>
					</td>
					<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						
							<div class="shop_cz_ifb" style="line-height:20px;height:auto;">
								<a href="http://www.cang.com/shop/2439963.html" target="_blank" class="col65 b">盘子</a>
							</div>
							编号：{{msg.number}}<br /> 类别：
							<a class="f_gr" href="http://www.cang.com/shop/2439963.html" target="_blank">[{{msg.type}}]</a>
							<br /> 上传时间:{{msg.time}}
						
					</td>
					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<a href="http://www.cang.com/shop/2439963.html" target="_blank">{{msg.name}}</a>
					</td>
					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<input type="text" id="txtPrice2439963" maxlength="7" onChange="if(this.value.replace(/[^\d]/g,'')!=''){this.value=parseInt(this.value.replace(/[^\d]/g,''),10);}else{this.value='0';}" onkeyup="if(this.value.replace(/[^\d]/g,'')!=''){this.value=parseInt(this.value.replace(/[^\d]/g,''),10);}else{this.value='';}" onblur="if(this.value.replace(/[^\d]/g,'')==''){this.value='0'}" class="txtPrice" value="100000" style="width:80px;" /><br />
						<input type="button" name="button" id="button" class="btn_blue" value="修改" onclick="goods_action(2439963,'user_price')" />
					</td>
					<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						<p>售况：<span class="red">{{msg.sale}} </span><br /> 更新:
							<span class="f_gr">{{msg.update}}</span><br /> 置顶:
							<span class="f_gr">{{msg.roof}}</span></p>
					</td>
					<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						<p>
							<a href="javascript:void(0)" onclick="prod_edit(2439963,3)" class="f_gr">更新商品时间</a>
							<a href="http://news.cang.com/infos/201401/294794.html" target="_blank" style="margin-left:15px;font-weight:bold;color:#0063AF;">?</a><br />
							<a href='javascript:void(0)' onclick='alert("已经为待售状态!")' class='btn_aNo1'>待售</a>
							|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_ding")'>已定</a>
							|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_sale")'>已售</a>
							|
							<a href="javascript:void(0)" class="btn_a1" onclick="ProdTG(2439963)">推广</a><br />
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_zhiding")'>
								置顶</a>|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_tuijian")'>
								推荐
							</a>|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_ProdGood")'>
								镇店之宝</a><br />
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_xiajia")'>
								下架</a>|
							<a href='ShopProd_M.aspx?id=2439963' class='btn_a1'>编辑</a>|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_del")'>删除</a>
						</p>
					</td>
				</tr>

			</table>
		</el-tab-pane>
		<el-tab-pane label="推荐商品" name="fifth">
			<table id="table" width="100%" cellpadding="0" cellspacing="1" class="shop_tbl" bgcolor="#e5e5e5">
				<tr class="bg">

					<th style="width:120px;background-color:#FFF;">图片</th>
					<th bgcolor="#FFFFFF">商品信息</th>
					<th style="width:90px;background-color:#FFF;">商城归属</th>
					<th style="width:100px;background-color:#FFF;">价格</th>
					<th style="width:160px;background-color:#FFF;">售况/更新/置顶</th>
					<th style="width:210px;background-color:#FFF;">操作</th>
				</tr>

				<tr v-for="msg in list4" :key="msg.index">

					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<a href="http://www.cang.com/shop/2439963.html" target="_blank"><img :src="msg.pic" class="Img100" /></a>
					</td>
					<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						
							<div class="shop_cz_ifb" style="line-height:20px;height:auto;">
								<a href="http://www.cang.com/shop/2439963.html" target="_blank" class="col65 b">盘子</a>
							</div>
							编号：{{msg.number}}<br /> 类别：
							<a class="f_gr" href="http://www.cang.com/shop/2439963.html" target="_blank">[{{msg.type}}]</a>
							<br /> 上传时间:{{msg.time}}
						
					</td>
					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<a href="http://www.cang.com/shop/2439963.html" target="_blank">{{msg.name}}</a>
					</td>
					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<input type="text" id="txtPrice2439963" maxlength="7" onChange="if(this.value.replace(/[^\d]/g,'')!=''){this.value=parseInt(this.value.replace(/[^\d]/g,''),10);}else{this.value='0';}" onkeyup="if(this.value.replace(/[^\d]/g,'')!=''){this.value=parseInt(this.value.replace(/[^\d]/g,''),10);}else{this.value='';}" onblur="if(this.value.replace(/[^\d]/g,'')==''){this.value='0'}" class="txtPrice" value="100000" style="width:80px;" /><br />
						<input type="button" name="button" id="button" class="btn_blue" value="修改" onclick="goods_action(2439963,'user_price')" />
					</td>
					<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						<p>售况：<span class="red">{{msg.sale}} </span><br /> 更新:
							<span class="f_gr">{{msg.update}}</span><br /> 置顶:
							<span class="f_gr">{{msg.roof}}</span></p>
					</td>
					<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						<p>
							<a href="javascript:void(0)" onclick="prod_edit(2439963,3)" class="f_gr">更新商品时间</a>
							<a href="http://news.cang.com/infos/201401/294794.html" target="_blank" style="margin-left:15px;font-weight:bold;color:#0063AF;">?</a><br />
							<a href='javascript:void(0)' onclick='alert("已经为待售状态!")' class='btn_aNo1'>待售</a>
							|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_ding")'>已定</a>
							|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_sale")'>已售</a>
							|
							<a href="javascript:void(0)" class="btn_a1" onclick="ProdTG(2439963)">推广</a><br />
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_zhiding")'>
								置顶</a>|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_tuijian")'>
								推荐
							</a>|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_ProdGood")'>
								镇店之宝</a><br />
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_xiajia")'>
								下架</a>|
							<a href='ShopProd_M.aspx?id=2439963' class='btn_a1'>编辑</a>|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_del")'>删除</a>
						</p>
					</td>
				</tr>

			</table>
		</el-tab-pane>
		<el-tab-pane label="置顶商品" name="sixth">
			<table id="table" width="100%" cellpadding="0" cellspacing="1" class="shop_tbl" bgcolor="#e5e5e5">
				<tr class="bg">

					<th style="width:120px;background-color:#FFF;">图片</th>
					<th bgcolor="#FFFFFF">商品信息</th>
					<th style="width:90px;background-color:#FFF;">商城归属</th>
					<th style="width:100px;background-color:#FFF;">价格</th>
					<th style="width:160px;background-color:#FFF;">售况/更新/置顶</th>
					<th style="width:210px;background-color:#FFF;">操作</th>
				</tr>

				<tr v-for="msg in list5" :key="msg.index">

					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<a href="http://www.cang.com/shop/2439963.html" target="_blank"><img :src="msg.pic" class="Img100" /></a>
					</td>
					<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						
							<div class="shop_cz_ifb" style="line-height:20px;height:auto;">
								<a href="http://www.cang.com/shop/2439963.html" target="_blank" class="col65 b">盘子</a>
							</div>
							编号：{{msg.number}}<br /> 类别：
							<a class="f_gr" href="http://www.cang.com/shop/2439963.html" target="_blank">[{{msg.type}}]</a>
							<br /> 上传时间:{{msg.time}}
						
					</td>
					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<a href="http://www.cang.com/shop/2439963.html" target="_blank">{{msg.name}}</a>
					</td>
					<td align="center" valign="middle" bgcolor="#FFFFFF">
						<input type="text" id="txtPrice2439963" maxlength="7" onChange="if(this.value.replace(/[^\d]/g,'')!=''){this.value=parseInt(this.value.replace(/[^\d]/g,''),10);}else{this.value='0';}" onkeyup="if(this.value.replace(/[^\d]/g,'')!=''){this.value=parseInt(this.value.replace(/[^\d]/g,''),10);}else{this.value='';}" onblur="if(this.value.replace(/[^\d]/g,'')==''){this.value='0'}" class="txtPrice" value="100000" style="width:80px;" /><br />
						<input type="button" name="button" id="button" class="btn_blue" value="修改" onclick="goods_action(2439963,'user_price')" />
					</td>
					<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						<p>售况：<span class="red">{{msg.sale}} </span><br /> 更新:
							<span class="f_gr">{{msg.update}}</span><br /> 置顶:
							<span class="f_gr">{{msg.roof}}</span></p>
					</td>
					<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
						<p>
							<a href="javascript:void(0)" onclick="prod_edit(2439963,3)" class="f_gr">更新商品时间</a>
							<a href="http://news.cang.com/infos/201401/294794.html" target="_blank" style="margin-left:15px;font-weight:bold;color:#0063AF;">?</a><br />
							<a href='javascript:void(0)' onclick='alert("已经为待售状态!")' class='btn_aNo1'>待售</a>
							|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_ding")'>已定</a>
							|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_sale")'>已售</a>
							|
							<a href="javascript:void(0)" class="btn_a1" onclick="ProdTG(2439963)">推广</a><br />
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_zhiding")'>
								置顶</a>|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_tuijian")'>
								推荐
							</a>|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_ProdGood")'>
								镇店之宝</a><br />
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_xiajia")'>
								下架</a>|
							<a href='ShopProd_M.aspx?id=2439963' class='btn_a1'>编辑</a>|
							<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_del")'>删除</a>
						</p>
					</td>
				</tr>

			</table>
		</el-tab-pane>
	</el-tabs>
</template>

<script>
	import '~/assets/css/shop.css'
	import shangApi from '~/api/commodity'
	export default {
		data() {
			return {
				activeName: 'first',
				list: [],
				list1: [],
				list2: [],
				list3: [],
				list4: [],
				list5: []
			}

		},
		methods: {
			handleClick(tab, event) {

			}
		},
		created: function() {
			var self = this; //全部商品
			shangApi.allList().then(function(res) {

				self.list = res.data.list
				//待售商品
				shangApi.forsale().then(function(res) {
					self.list1 = res.data.list1
				})
				//已定商品
				shangApi.fixed().then(function(res) {
					self.list2 = res.data.list2
				})
				//已售商品
				shangApi.sold().then(function(res) {
					self.list3 = res.data.list3

				})
				//推荐商品
				shangApi.Recommend().then(function(res) {
					self.list4 = res.data.list4

				})
				//置顶商品
				shangApi.roof().then(function(res) {
					self.list5 = res.data.list5

				})
			})
		}
	}
</script>

<style>

</style>