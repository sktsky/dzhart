<!-- 创建博物馆 -->
<template id="M_zhuanti_List2">
	<div>
		<table class="table1" cellspacing="0" cellpadding="0" border="0">
			<tbody>
				<tr class="bg">
					<th colspan="2" class="title" align="left">
						申请创建博物馆 <span>该功能免费</span>
					</th>
				</tr>
				<tr>
					<td class="Column1">博物馆名称 ：</td>
					<td><input name="txtTitle" maxlength="20" id="txtTitle" class="my_cr_name_input" type="text"> <span class="Must">*</span></td>
				</tr>
				<tr>
					<td></td>
					<td>
						<div class="ts">
							1、不要用用户名或者包含用户名做为私人博物馆名称；<br> 2、不要含有特殊符号，诸如：*、{}、【】等；
							<br> 3、不要使用与古玩艺术品无关的商号等；
							<br> 4、建议使用：藏品分类名称+藏品二级分类名称+馆，比如：玉器摆件馆，瓷器百壶馆；
							<br> 5、藏品档次高、分类清晰、鉴赏价值高、数量多的私人博物馆将做重点宣传；
						</div>
					</td>
				</tr>
				<tr>
					<td class="Column1">博物馆图片：</td>
					<td>
						<input name="txtPic" maxlength="50" id="txtPic" style="width:315px;float:left" type="text">
						<iframe id="frmImg" scrolling="no" src="UpImg.htm" style="float:left;margin-top:-2px;" width="80" height="25" frameborder="0"></iframe>
						<span class="Must">宽：200像素 高：150像素</span>
					</td>
				</tr>
				<tr>
					<td class="Column1" valign="top">博物馆介绍：</td>
					<td valign="middle">
						<textarea name="txtIntro" rows="2" cols="20" id="txtIntro" style="height:100px;width:450px;"></textarea> <span class="Must">*</span>
					</td>
				</tr>
				<tr>
					<td class="Column1" valign="middle">贡献藏友 ：</td>
					<td><input name="txtContributors" maxlength="40" id="txtContributors" class="my_cr_name_input" style="width:213px;" type="text"></td>
				</tr>
				<tr>
					<td colspan="2" style=" padding-left:200px;">
						<input name="butAdd" value="我要申请" id="butAdd" class="btnSave" style="width:100px;" type="submit">
					</td>
				</tr>
			</tbody>
		</table>
		<br>
		<br>
	</div>
</template>

<script>
	export default {
		data() {
			return {
				name: '',
				describe: '',
				peple: '',
				fileList: []
			};
		},
		methods: {
			handleRemove(file, fileList) {
				console.log(file, fileList);
			},
			handlePreview(file) {
				console.log(file);
			},
			handleExceed(files, fileList) {
				this.$message.warning(`当前限制选择 1 个文件，本次选择了 ${files.length} 个文件，共选择了 ${files.length + fileList.length} 个文件`);
			},
			beforeRemove(file, fileList) {
				return this.$confirm(`确定移除 ${ file.name }？`);
			}
		}
	}
</script>

<style>
	.museum_mymuseum_n {
		width: 103px;
		height: 53px;
		float: left;
		border-bottom: 1px solid #d0d0d0;
		border-right: 1px solid #d0d0d0;
	}
	
	.bodywrap a {
		color: #666;
		text-decoration: none;
	}
	
	.museum_m_my_y {
		background-position: 0px 0px;
	}
	
	.museum_menu_ico {
		display: block;
		width: 17px;
		height: 17px;
		margin: 8px auto;
	}
	
	.museum_titli_n {
		display: block;
		width: 100%;
		margin: 5px auto;
		text-align: center;
	}	
	.all_museum {
		width: 942px;
		margin: 15px;
	}
	
	.all_museum .info_table {
		border-collapse: collapse;
		border: none;
		color: #646464;
	}
	
	.all_museum .info_table td {
		border: solid #e5e5e5 1px;
		height: 40px;
		vertical-align: middle;
		padding-left: 5px;
	}
	
	.museum_titli_n {
		display: block;
		width: 100%;
		margin: 5px auto;
		text-align: center;
	}
	
	.museum_menu_ico {
		display: block;
		width: 17px;
		height: 17px;
		margin: 8px auto;
	}
	
	.all_museum .info_table a {
		color: #3065cf;
	}
	.tcent {
		text-align: center;
	}
	
	.wi50 {
		width: 50px;
	}
	
	.wi435 {
		width: 435px;
	}
	
	.wi120 {
		width: 120px;
	}
	
	.wi180 {
		width: 180px;
	}	
	.Pnl {
		width: 96%;
		margin: 5px auto 0px auto;
		padding-top: 5px;
		zoom: 1;
		overflow: hidden;
	}
	
	.clearboth {
		clear: both;
		display: block;
		height: 0;
		font-size: 0;
		overflow: hidden;
	}
</style>