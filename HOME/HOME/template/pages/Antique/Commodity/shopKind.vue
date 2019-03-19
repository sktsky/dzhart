	<!-- 商品分类 -->
	
	<template id="shopKind">
		 <div id="shop_cz_box" class="shop_cz_box">
               <div style="width:100%;overflow:hidden;padding-bottom:10px;"><input id="btnAdd" type="button" value="添加分类" class="shop_img btn_y80_25"></div>
               <table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#e5e5e5">
                       <tbody>
                           <tr>
                               <th bgcolor="#FFF">
                                  	 分类名称</th>
                               <th bgcolor="#FFF" width="100">
                               	    添加子类</th>
                               <th bgcolor="#FFF" width="100">上移&nbsp;&nbsp;&nbsp;&nbsp;下移</th>
                               <th bgcolor="#FFF" width="120">
                                	   移动到该分类下方</th>
                               <th bgcolor="#FFF" width="60">
                                 	  删除</th>
                               
                           </tr>
                           <tr>
                           <td colspan="6" bgcolor="#FFF">
                           <table width="100%" border="0" cellpadding="0" cellspacing="0" id="showcate">
               
                           <tbody id="32924">
                           <tr class="cat_sup td_c_w" data-id="32924">
                               <td class="td-1">
                                   <span>
                                    	   瓷器
                                   </span>
                               </td>
                               <td class="td-lb" width="100" align="center">
                                   <span class="add_cat_sub" title="添加子类"></span></td>
                               <td class="td-3 td-lb" width="50" align="center">
                                   <span class="move-up-disable"></span>
                               </td>
                               <td width="50" class="td-4" align="center">
                                   <span class="move-down-disable"></span>
                               </td>
                               <td class="td-lb" width="120" align="center">
                                   
                                   <select class="cateSel" style="width:110px;">
                                       <option value="0">--请选择--</option>
                                       
                                               <option value="32924">瓷器</option>
                                               
                                   </select>
                               </td>
                               <td class="td-lb" width="30" align="center">
                                   <span class="edit_cat" id="edit:32924"></span>
                               </td>
                               <td width="31" align="center">
                                   <span class="del_cat" id="del:32924"></span>
                               </td>
                               
                           </tr>
                           
                           
                       </tbody>
                           
               </table></td></tr></tbody></table>
               
                 
           </div>	
	</template>

<script>
		import '~/assets/css/shop.css'
		export default{
			
		}
</script>

<style>
</style>