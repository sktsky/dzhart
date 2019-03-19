<!-- 待审商品-->
<template id="Weishen">
	<div id="shop_cz_box" class="shop_cz_box">
		<div class="shop_pt_box" style='display:none;'>
			<div class="shop_pt_pages">
				<div class="p_input_html">
					第<input class="p_input_page" type="text" value="1" data="1" />页
					<input class="p_input_go" type="button" value="GO" onclick="gopage('shopProd_Weishen.aspx',this,0)" />
				</div>
				<a class="nextpage " href="javascript:void(0);">下一页</a>
				<a class="uppage uppaged" href="javascript:void(0);">上一页</a>
				<div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
			</div>
		</div>

		<table id="table" width="100%" cellpadding="0" cellspacing="1" class="shop_tbl" bgcolor="#e5e5e5">
			<tr class="bg">
				<th style="width:85px;background-color:#FFF;">图片</th>
				<th bgcolor="#FFFFFF">商品信息</th>
				<th style="width:120px;background-color:#FFF;">商城归属</th>
				<th style="width:100px;background-color:#FFF;">价格</th>
				<th style="width:120px;background-color:#FFF;">操作</th>
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
						价格：{{msg.price}}<br /> 评论:{{msg.comment}}
						<br />
					</p>
				</td>
				<td class="shop_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
					<p>
						<a href='javascript:void(0)' class='btn_a1' onclick='goods_action(2439963,"user_shangjia")'>上架</a><br/>
						<a href='javascript:void(0)' onclick='alert("已有评论不能编辑!")' class='btn_aNo1'>编辑</a> | <a href='javascript:void(0) ' onclick='alert( "已有评论不能删除!") ' class='btn_aNo1 '>删除</a>
                                  </p>
                              </td>
                          </tr>                  
                      </table>
                  
              <div class="shop_pt_box" style='display:none; '>
                  <div class="shop_pt_pages">
                      <div class="p_input_html">
                       	   第<input class="p_input_page" type="text" value="1" data="1" />页
                          <input class="p_input_go" type="button" value="GO" onclick="gopage('shopProd_Weishen.aspx ',this,0)" />
                      </div>
                      <a class="nextpage " href="javascript:void(0);">下一页</a>
                      <a class="uppage uppaged" href="javascript:void(0);">上一页</a>
                      <div class="p_info_html">共<span>0</span>件 <span>1</span>/0</div>
                  </div>
              </div>
          </div>
	
	</template>

<script>
	import '~/assets/css/shop.css'
	import shenApi from '~/api/commodity'
	export default{
		data(){
    		  return{
    			  list:[]
    		  }
    	  },
    	  created:function(){
    		  var self = this;
    		  shenApi.Pending().then(function(res){
    			  self.list = res.data.list
    		  })
    	  }
	}
</script>

<style>
</style>