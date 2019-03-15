<!-- 店铺发票2 begin -->
<template id="shop_list5">
	<div id="shop_cz_box" class="shop_cz_box">

		<table width="100%" class="tbl_tbp" border="0">
			<tbody>
				<tr>
					<td style="width: 70px;">
						发票内容：</td>
					<td valign="middle">
						<div class="shop_m_xzbox fl">
							<ul class="shop_inv_con shop_m_xzsel_ul" style="display: none;">
								<li class="" data="1">网络服务</li>
								<li class="" data="2">推广服务</li>
								<li class="" data="3">设计服务</li>
							</ul>
							<input name="ddlContentVal" type="text" id="ddlContentVal" value="网络服务" onfocus="$(this).blur()"><input type="hidden" name="HidddlContentVal" id="HidddlContentVal" value="1">
						</div>
						<span style="float:left; display:inline; margin-left:10px; height:30px; line-height:30px;">[良品铺子]</span>
					</td>
				</tr>
				<tr>
					<td>
						发票抬头：</td>
					<td valign="middle">
						<div class="shop_m_xzbox fl">
							<ul class="shop_inv_lu shop_m_xzsel_ul" style="display: none;">
								<li class="" data="1">公司</li>
								<li class="" data="2">个人</li>
							</ul>
							<input name="ddlNameType" type="text" id="ddlNameType" value="公司" onfocus="$(this).blur()"><input type="hidden" name="HidddlNameType" id="HidddlNameType" value="1">
						</div>
						<input name="txtName" type="text" maxlength="30" id="txtName" style="width:150px;height:30px;
border:1px solid #CCC;margin-left:15px;padding:0px 5px;">
						<font class="red">*</font>
					</td>
				</tr>
				<tr>
					<td>
						发票金额：</td>
					<td valign="middle">
						<font style=" font-size:14px; line-height:25px;color:#F08300;" class="Pri">￥500</font><input name="hidPayMonry" type="hidden" id="hidPayMonry" value="500">
					</td>
				</tr>
				<tr>
					<td valign="top">
						寄送地址：</td>
					<td valign="middle">
					</td>
				</tr>
				<tr>
					<td>
						联系人：</td>
					<td valign="middle">
						<input name="txtContact" type="text" maxlength="30" id="txtContact" style="width:100px;height:30px;border:1px solid #CCC;padding:0px 5px;">
						<font class="red">*</font>
					</td>
				</tr>
				<tr>
					<td>
						联系电话：</td>
					<td valign="middle">
						<input name="txtTel" type="text" maxlength="30" id="txtTel" style="width:200px;height:30px;border:1px solid #CCC;padding:0px 5px;">
						<font class="red">*</font>
					</td>
				</tr>
				<tr>
					<td>
						寄送地址：</td>
					<td valign="middle">
						<input name="txtAddr" type="text" maxlength="100" id="txtAddr" style="width:400px;height:30px;border:1px solid #CCC;padding:0px 5px;">
						<font class="red">*</font>
					</td>
				</tr>
				<tr>
					<td>
						&nbsp;</td>
					<td valign="middle">
						<input type="submit" name="btnAdd" value="发 布" onclick="return CheckForm();" id="btnAdd" class="shop_img btn_y80_25">
						<input id="btnreSet" type="reset" value="重 填" class="shop_img btn_b80_25 ml15">
						<font class="red">(*仅对中国大陆用户提供发票，一年只能开一次发票)</font>

					</td>
				</tr>
			</tbody>
		</table>

	</div>
</template>

<script>
</script>

<style>

</style>