<!-- 下架商品begin -->
<template id="Xiajia">
	<div>
		<div class="shop_s_link">

			<el-tabs v-model="activeName" @tab-click="handleClick">
				<el-tab-pane label="审核下架" name="first">
					<div id="shop_cz_box" class="shop_cz_box">
						<div class="shop_pt_box" style='display:none;'>

							<div class="shop_pt_pages">
								<div class="p_input_html">
									第<input class="p_input_page" type="text" value="1" data="1" />页
									<input class="p_input_go" type="button" value="GO" onclick="gopage('shopProd_Xiajia.aspx?status=4',this,1)" />
								</div>
								<a class="nextpage nextpaged" href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>1</span>件 <span>1</span>/1</div>
							</div>
						</div>

						<table id="table" width="100%" cellpadding="0" cellspacing="1" class="shop_tbl" bgcolor="#e5e5e5">
							<tr class="bg">

								<th style="width:120px;background-color:#FFF;">图片</th>
								<th bgcolor="#FFFFFF">商品信息</th>
								<th style="width:120px;background-color:#FFF;">商城归属</th>
								<th style="width:160px;background-color:#FFF;">售况/价格</th>
								<th style="width:100px;background-color:#FFF;">操作</th>
							</tr>

							<tr v-for="msg in list" :key="msg.index">

								<td align="center" valign="middle" bgcolor="#FFFFFF">
									<a href="http://www.cang.com/shop/2439963.html" target="_blank"><img :src="msg.pic" class="Img100" /></a>
								</td>
								<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
									
										<div class="shop_cz_ifb" style="line-height:20px;height:auto;">
											<a href="http://www.cang.com/shop/2439963.html" target="_blank" class="col65 b">{{msg.name}}</a>
										</div>
										编号：{{msg.number}}<br /> 上传时间:{{msg.time}}
										<br /> 置顶时间:{{msg.rooftime}}
									
								</td>
								<td align="center" valign="middle" bgcolor="#FFFFFF">
									<a href="http://www.cang.com/shop/2439963.html" target="_blank">{{msg.ascription}}</a>
								</td>
								<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
									<p>
										下架原因：<span class="red">{{msg.reason}}</span><br/> 售况：
										<span class="red">{{msg.sale}}</span><br /> 价格：{{msg.price}}
										<br /> 评论:{{msg.comment}}
										<br />
									</p>
								</td>
								<td class="shop_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
									<p>
										<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_shangjia")'>上架</a><br/>
										<a href='javascript:void(0)' onclick='alert("已有评论不能编辑!")' class='btn_aNo1'>编辑</a> |
										<a href='javascript:void(0) ' onclick='alert( "已有评论不能删除!") ' class='btn_aNo1 '>删除</a>
		                                    </p>
		                                </td>
		                            </tr>
		                        
		                            </table>
		                        
		                    <div class="shop_pt_box" style='display:none; '>
		                        
		                        <div class="shop_pt_pages" style='display:none; '>
		                            <div class="p_input_html">
		                                	第<input class="p_input_page" type="text" value="1" data="1" />页
		                                <input class="p_input_go" type="button" value="GO" onclick="gopage('shopProd_Xiajia.aspx?status=4 ',this,1)" />
		                            </div>
		                            <a class="nextpage nextpaged" href="javascript:void(0);">下一页</a>
		                            <a class="uppage uppaged" href="javascript:void(0);">上一页</a>
		                            <div class="p_info_html">共<span>1</span>件 <span>1</span>/1</div>
		                        </div>
		                    </div>
		                </div>				    
				    </el-tab-pane>
				    <el-tab-pane label="自行下架" name="second">
		                <div id="shop_cz_box" class="shop_cz_box">
		                    <div class="shop_pt_box" style='display:none; '>
		                        
		                        <div class="shop_pt_pages">
		                            <div class="p_input_html">
		                                	第<input class="p_input_page" type="text" value="1" data="1" />页
		                                <input class="p_input_go" type="button" value="GO" onclick="gopage('shopProd_Xiajia.aspx?status=4 ',this,1)" />
		                            </div>
		                            <a class="nextpage nextpaged" href="javascript:void(0);">下一页</a>
		                            <a class="uppage uppaged" href="javascript:void(0);">上一页</a>
		                            <div class="p_info_html">共<span>1</span>件 <span>1</span>/1</div>
		                        </div>
		                    </div>
		                    
		                            <table id="table" width="100%" cellpadding="0" cellspacing="1" class="shop_tbl" bgcolor="#e5e5e5">
		                                <tr class="bg">
		                                    
		                                    <th style="width:120px;background-color:#FFF;">图片</th>
		                                    <th bgcolor="#FFFFFF">商品信息</th>
		                                    <th style="width:120px;background-color:#FFF;">商城归属</th>
		                                    <th style="width:160px;background-color:#FFF;">售况/价格</th>
		                                    <th style="width:100px;background-color:#FFF;">操作</th>
		                                </tr>
		                        
		                            <tr v-for="msg in list2" :key="msg.index">
		                                
		                                <td align="center" valign="middle" bgcolor="#FFFFFF">
		                                    <a href="http://www.cang.com/shop/2439963.html" target="_blank"><img :src="msg.pic"  class="Img100" /></a>
		                                </td>
		                                <td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
		                                    
		                                    <div class="shop_cz_ifb" style="line-height:20px;height:auto;"><a href="http://www.cang.com/shop/2439963.html" target="_blank" class="col65 b">{{msg.name}}</a></div>
									                                    编号：{{msg.number}}<br />
									                                    上传时间:{{msg.time}}<br />
									                                    置顶时间:{{msg.rooftime}}
		                                </td>
		                                <td align="center" valign="middle" bgcolor="#FFFFFF">
		                                    <a href="http://www.cang.com/shop/2439963.html" target="_blank">{{msg.ascription}}</a>
		                                </td>
		                                <td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">
		                                    <p>
									                                    下架原因：<span class="red">{{msg.reason}}</span><br/>
									                                    售况：<span class="red">{{msg.sale}} </span><br />
									                                    价格：{{msg.price}}<br />
									                                    评论:{{msg.comment}}<br />
		                                    </p>
		                                </td>
		                                <td class="shop_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
		                                    <p>
		                                    <a href='javascript:void(0) ' class='btn_a1 ' onclick='goods_action(2439963, "user_shangjia") '>上架</a><br/>
		                                    <a href='javascript:void(0) ' onclick='alert( "已有评论不能编辑!") ' class='btn_aNo1 '>编辑</a> | <a href='javascript:void(0)' onclick='alert("已有评论不能删除!")' class='btn_aNo1'>删除</a>
									</p>
								</td>
							</tr>

						</table>

						<div class="shop_pt_box" style='display:none;'>

							<div class="shop_pt_pages" style='display:none;'>
								<div class="p_input_html">
									第<input class="p_input_page" type="text" value="1" data="1" />页
									<input class="p_input_go" type="button" value="GO" onclick="gopage('shopProd_Xiajia.aspx?status=4',this,1)" />
								</div>
								<a class="nextpage nextpaged" href="javascript:void(0);">下一页</a>
								<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
								<div class="p_info_html">共<span>1</span>件 <span>1</span>/1</div>
							</div>
						</div>
					</div>
				</el-tab-pane>
			</el-tabs>

		</div>

	</div>

</template>

<script>
	import '~/assets/css/shop.css'
	import { getData } from '~/plugins/axios.js'
	export default {
		data() {
			return {
				activeName: 'first',
				list: [],
				list2: []
			};
		},
		created: function() {
			var self = this;
			//自行下架
			getData('mock/5c206fc50fd1077df5e6e924/s/shelf').then(function(res) {
				self.list = res.data.list
				//审核下架
				getData('mock/5c206fc50fd1077df5e6e924/s/shelf2').then(function(res) {
					self.list2 = res.data.list
				})
			}, function() {
				console.log('失败')
			})
		}
	}
</script>

<style>

</style>