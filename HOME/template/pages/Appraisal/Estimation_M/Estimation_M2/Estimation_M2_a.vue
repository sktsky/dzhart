<!--发帖-鉴定估价-->
<template id="Estimation_M2_a">

	<div class="jd_cz_tbcon">
		<div class="jd_cz_bcon">

			<el-form ref="form" :model="form" label-width="120px">
				<el-form-item label="藏品分类：">
					<el-select @change="handleChange" value-key="id" v-model="form.categoryId" placeholder="请选择藏品分类">
						<el-option v-for="item in parentId" :key="item.id" :label="item.name" :value="item.id">
						</el-option>
						<!-- 遍历id=0的所有 -->
					</el-select>
					<el-select @change="Change" value-key="id" v-model="form.category" placeholder="请选择藏品分类">
						<el-option v-for="item in parentIdd" :key="item.id" :label="item.name" :value="item.id">
						</el-option>
					</el-select>
				</el-form-item>
				<el-form-item label="鉴定方式：">
					<el-radio-group v-model="form.radio1">
						<el-radio :label="3" border>有偿鉴定</el-radio>
						<el-radio :label="6" border>加急鉴定</el-radio>
						<el-radio :label="9" border>指定鉴定</el-radio>
					</el-radio-group>
				</el-form-item>
				<el-form-item label="选择鉴定师：">
					<el-radio-group v-model="form.radio2">
						<el-radio :label="1" border>全部</el-radio>
						<el-radio :label="2" border>排除</el-radio>
					</el-radio-group>
				</el-form-item>
				<el-form-item label="鉴定结果：">
					<el-radio-group v-model="form.radio3">
						<el-radio :label="1" border>隐藏</el-radio>
						<el-radio :label="2" border>不隐藏</el-radio><label>选择隐藏鉴定结果将多扣20藏币！</label>
					</el-radio-group>
				</el-form-item>
				<el-form-item label="手机短信提醒：">
					<el-radio-group @change="needChange" v-model="form.radio4">
						<el-radio :label="1" border>需要</el-radio>
						<el-radio :label="2" border>不需要</el-radio>
					</el-radio-group>
				</el-form-item>
				<el-form-item label="手机号码：" v-show="active==1">
					<el-input v-model="form.phone" style="width:60%"></el-input>
				</el-form-item>
				<el-form-item label="帖子标题：">
					<el-input v-model="form.title" style="width:60%"></el-input>
				</el-form-item>
				<el-form-item label="添加标签：">
					<el-input v-model="form.name" style="width:60%"></el-input>
				</el-form-item>
				<el-form-item label="推荐标签：">
					<el-checkbox-group v-model="form.list" :max="5" size="small" style="padding-top:8px">
						<el-checkbox v-for="(msg,index) in hidelist" :key="index" :label="msg">{{msg.name}}</el-checkbox>
					</el-checkbox-group>
				</el-form-item>
				<el-form-item label="藏品描述：">
					<el-input type="textarea" v-model="form.desc" style="width:75%"></el-input>
				</el-form-item>
				<el-form-item>
					<el-upload ref="upload" action="http://localhost:8082/upload.do" name="picFile" list-type="picture-card" :file-list="fileList" :on-preview="handlePictureCardPreview" :on-success="handleSuccess" :on-remove="handleRemove">
						<i class="el-icon-plus"></i>
					</el-upload>
					<el-dialog :visible.sync="dialogVisible">
						<img width="100%" :src="dialogImageUrl" alt="">
					</el-dialog>
				</el-form-item>
				<el-form-item>
					<el-button type="primary" @click="onSubmit">发布</el-button>
					<el-button>重填</el-button>
				</el-form-item>
			</el-form>

		</div>

		<div class="fl up_announcement">
			<b>提示：</b><br> 1、上传前您必须同意：本网认为东西不对或图片不清楚有权删除和编辑；
			<br>
			<div style="position: relative; padding-top: 8px;">
				2、用微信收订单消息和管理订单
				<font color="#ff4a0a">(new)</font>：<br>
			</div>
			3、图片上传按钮显示红色叉叉，可能FLASH插件版本太低，需要安装FLASH插件
			<a href="http://get.adobe.com/cn/flashplayer/" target="_blank">
				<font color="#00CC00">下载安装</font>
			</a>（安装完成后需刷新当前页面）；<br> 4、如果点击上传图片后没有反映，请使用IE或者360浏览器；
			<br> 5、为了保证您能更快更顺畅的上传图片，我们建议您把图片控制在100K以内，图片超过1M很容易超时出错；
			<br> 6、如果无法上传，请联系QQ：
			<a target="_blank" href="tencent://message/?uin=3503899378&amp;Site=%E5%8D%8E%E5%A4%8F%E6%94%B6%E8%97%8F%E7%BD%91&amp;Menu=yes"><img src="images/wp_3.gif" alt="点击这里给我发消息" style="vertical-align:middle;border:0px;"></a>、
			<a target="_blank" href="tencent://message/?uin=1548588393&amp;Site=%E5%8D%8E%E5%A4%8F%E6%94%B6%E8%97%8F%E7%BD%91&amp;Menu=yes"><img src="images/wp_3.gif" alt="点击这里给我发消息" style="vertical-align:middle;border:0px;"></a>，联系电话：0571-87357345（工作日：9:00-17:30）。
		</div>
	</div>

</template>

<script>
	import axios from 'axios'
	export default {
		data() {
			return {
				labelPosition: 'top',
				parentIdd: [],
				parentId: [],
				parentList: [],
				options: [],
				dialogImageUrl: '',
				dialogVisible: false,
				fileList: [],
				hidelist: [],
				active: '',
				form: {
					categoryId: '',
					category: '',
					radio1: '',
					radio2: '',
					radio3: '',
					radio4: '',
					phone: '',
					title: '',
					name: '',
					list: [],
					desc: '',
					image: []
				}
			}
		},
		methods: {
			//图片上传成功后赋值
			handleSuccess(response, file, fileList) {
				//console.log(file)
				var self = this;
				self.fileList.push(file.response.url)
				self.form.image = self.fileList
				//console.log(self.form.file);
				//console.log(file.response.url);
			},
			handleRemove(file, fileList) {
				console.log(file, fileList);
			},
			handlePictureCardPreview(file) {
				this.dialogImageUrl = file.url;
				this.dialogVisible = true;
			},
			onSubmit() {
				//提交上传
				var obj = this.form;
				axios.post('https://www.easy-mock.com/mock/5bef818022aea84bf63bfe30/user/user/upload', obj)
//				http://localhost:8082/dzhshop/add.do
					.then(function(response) {

						console.log(response);
					})
					.catch(function(error) {
						console.log(error);
					});
				console.log('submit!');
			},
			handleChange(row) {
				var self = this;
				axios.get('http://localhost:8082/itemCat/findByParentId.do?', {
					params: {
						parentId: row
					}
				}).then(function(res) {
					self.parentIdd = res.data
				});
			},
			Change(row) {
				console.log(row)
				var self = this;
				axios.get('http://localhost:8082/itemCat/findByParentId.do?', {
					params: {
						parentId: row
					}
				}).then(function(res) {
					console.log(res)
					self.hidelist = res.data
					console.log(self.hidelist)
				});
			},
			needChange(row) {

				this.active = row;
			}
		},
		created: function(row) {
			//获取一级表单数据
			var self = this;
			axios.get('http://localhost:8082/itemCat/findByParentId.do?', {
				params: {
					parentId: 0
				}
			}).then(function(res) {
				self.parentId = res.data
			});

		}
	}
</script>

<style>

</style>