		<!-- 银行账号  -->
		<template id="PayAccount">
			<div>
				<div class="mright PayAccount">
	            <div class="menu">
	                <a href="http://pay.cang.com/myhome/Trade/PayAccount.aspx" class="menu_n menu_y">银行信息</a>
	                <div class="menu_fill1">
	                    <input value="添加银行账号" onclick="addinfo(this)" data="0" class="btninfobox fr" type="button">
	                </div><div class="clearboth"></div>
	            </div> 
	            <table class="bankInfoTable">
	                <tbody><tr id="banklisto">
	                    <th style="width:150px;">银行名称</th>
	                    <th>支行名称</th>
	                    <th style="width:120px;">开户姓名</th>
	                    <th style="width:220px;">帐号</th>
	                    <th style="width:140px;">操作</th>
	                </tr>
	            </tbody></table>
	        </div>
	        </div>
	</template>

<script>
	import '~/assets/css/Custom.css'
	import '~/assets/css/paimai.css'
	export default{
		
	}
</script>

<style>
</style>