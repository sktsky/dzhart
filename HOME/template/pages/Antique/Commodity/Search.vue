<!-- 所有商品 -->
<template id="Search">
	<div id="shop_cz_box" class="shop_cz_box">
		<div class="shop_pt_box" style='display:none;'>
			<div class="shop_pt_pages">
				<div class="p_input_html">
					第<input class="p_input_page" type="text" value="1" data="1" />页
					<input class="p_input_go" type="button" value="GO" onclick="gopage('shopProd_Search.aspx?keys=',this,1)" />
				</div>
				<a class="nextpage nextpaged" href="javascript:void(0);">下一页</a>
				<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
				<div class="p_info_html">共<span>1</span>件 <span>1</span>/1</div>
			</div>
		</div>

		<table id="table" width="100%" cellpadding="0" cellspacing="1" class="shop_tbl" bgcolor="#e5e5e5">
			<tr class="bg">
				<th style="width:85px;background-color:#FFF;">图片</th>
				<th bgcolor="#FFFFFF">商品信息</th>
				<th style="width:120px;background-color:#FFF;">商城归属</th>
				<th style="width:100px;background-color:#FFF;">价格</th>
				<th style="width:140px;background-color:#FFF;">评论/置顶</th>
				<th style="width:80px;background-color:#FFF;">状态</th>
				<th style="width:160px;background-color:#FFF;">操作</th>
			</tr>

			<tr v-for="msg in list" :key="msg.index">
				<td align="center" valign="middle" bgcolor="#FFFFFF">
					<a href="http://www.cang.com/shop/2439963.html" target="_blank"><img :src="msg.pic" class="Img100" /></a>
				</td>
				<td class="shop_td_xg" align="left" valign="middle" bgcolor="#FFFFFF">

					<div class="jd_cz_ifb" style="line-height:20px;height:auto;">
						<a href="http://www.cang.com/shop/2439963.html" target="_blank" class="col65 b">{{msg.name}}</a>
					</div>
					编号：{{msg.number}}<br> 售况：
					<span class="red">{{msg.sale}}</span><br> 上传时间:{{msg.time}}

				</td>
				<td align="center" valign="middle" bgcolor="#FFFFFF">
					<a href="http://www.cang.com/shop/2439963.html" target="_blank">{{msg.ascription}}</a>
				</td>
				<td align="center" valign="middle" bgcolor="#FFFFFF">
					<p>
						<input type="text" id="txtPrice2439963" maxlength="7" onChange="if(this.value.replace(/[^\d]/g,'')!=''){this.value=parseInt(this.value.replace(/[^\d]/g,''),10);}else{this.value='0';}" onkeyup="if(this.value.replace(/[^\d]/g,'')!=''){this.value=parseInt(this.value.replace(/[^\d]/g,''),10);}else{this.value='';}" onblur="if(this.value.replace(/[^\d]/g,'')==''){this.value='0'}" class="txtPrice" :value="msg.price" /><br/>
						<input type="button" name="button" id="button" class="btn_blue" value="修改" onclick="goods_action(2439963,'user_price')" />
					</p>
				</td>
				<td align="left" valign="middle" bgcolor="#FFFFFF">
					<p>
						评论:<span class="f_gr">{{msg.comment}}</span><br /> 置顶:
						<span class="f_gr">{{msg.roof}}</span>
					</p>
				</td>
				<td align="center" valign="middle" bgcolor="#FFFFFF">
					<p>
						<span class='colf0'>{{msg.examined}}</span>/<span class='colf0'>{{msg.shelf}}</span>
					</p>
				</td>
				<td class="shop_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
					<p>
						<a href='javascript:void(0);' onclick='alert("已经为待售状态!")' class='btn_aNo1'>待售</a>|
						<a href='javascript:void(0);' class='btn_a1' onclick='goods_action(2439963,"user_ding")'>已定</a>|
						<a href='javascript:void(0);' class='btn_a1' onclick='goods_action(2439963,"user_sale")'>已售</a>|
						<a href="javascript:void(0);" onclick="ProdTG(2439963)">推广</a><br/>
						<a href='javascript:void(0);' class='btn_a1' onclick='goods_action(2439963,"user_zhiding")'>置顶</a>|
						<a href='javascript:void(0);' class='btn_a1' onclick='goods_action(2439963,"user_tuijian")'>推荐</a>|
						<a href='javascript:void(0);' class='btn_a1 red' onclick='goods_action(2439963,"user_ProdGood")'>镇店之宝</a><br/>

						<a href='javascript:void(0);' class='btn_a1' onclick='goods_action(2439963,"user_xiajia")'>下架</a>|
						<a href='ShopProd_M.aspx?id=2439963' class='btn_a1'>编辑</a>|
						<a href='javascript:void(0);' class='btn_a1' onclick='goods_action(2439963,"user_del")'>删除</a>
					</p>
				</td>
			</tr>

		</table>

		<div class="shop_pt_box" style='display:none;'>
			<div class="shop_pt_pages">
				<div class="p_input_html">
					第<input class="p_input_page" type="text" value="1" data="1" />页
					<input class="p_input_go" type="button" value="GO" onclick="gopage('shopProd_Search.aspx?keys=',this,1)" />
				</div>
				<a class="nextpage nextpaged" href="javascript:void(0);">下一页</a>
				<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
				<div class="p_info_html">共<span>1</span>件 <span>1</span>/1</div>
			</div>
		</div>
	</div>

</template>

<script>
	import '~/assets/css/shop.css'
	import { getData } from '~/plugins/axios.js'
	export default {
		data() {
			return {
				list: []
			}
		},
		created: function() {
			var self = this;
			getData('mock/5c206fc50fd1077df5e6e924/s/').then(function(res) {
				self.list = res.data.list
			})
		}
	}
</script>

<style>

</style>