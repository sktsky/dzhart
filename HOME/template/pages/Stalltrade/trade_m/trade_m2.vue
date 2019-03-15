<!--地摊上传-->
<template id="trade_m2">
	<div class="step">
		<el-form ref="form" :model="form" label-width="80px">
			<el-form-item label="藏品分类">
				<el-select @change="handleChange" value-key="id" v-model="form.categoryId" placeholder="请选择藏品分类">
					<el-option v-for="item in parentId" :key="item.name" :label="item.name" :value="item.id">
					</el-option>
					<!-- 遍历id=0的所有 -->
				</el-select>
				<el-row>
					<el-col span="6" v-for="(item,index) in parentIdd" :key="index">
						<!-- 遍历id=1的所有 -->
						<span>{{item.name}}</span>
						<el-select @focus="show(item.id)" value-key="id" v-model="form.category[index]" placeholder="请选择藏品分类">
							<el-option v-for="item in parentList" :key="item.id" :label="item.name" :value="item.name">
							</el-option>
						</el-select>
					</el-col>

				</el-row>
			</el-form-item>
			<el-row>
				<el-col :span="12">
					<el-form-item label="藏品名称">
						<el-input v-model="form.title"></el-input>
					</el-form-item>
				</el-col>
			</el-row>
			<el-row>
				<el-col :span="12">
					<el-form-item label="商品价格">
						<el-input v-model="form.price"></el-input>
					</el-form-item>
				</el-col>
			</el-row>
			<el-form-item label="交易限制">
				<el-select v-model="form.jyxz">
					<el-option label="所有注册会员" value="member"></el-option>
					<el-option label="身份验证用户" value="useer"></el-option>
				</el-select>
			</el-form-item>
			<el-row>
				<el-col :span="15">
					<el-form-item label="运费情况">
						<el-radio-group v-model="form.freightrate">
							<el-radio label="包邮" border></el-radio>
							<el-radio label="不包邮" border></el-radio>
							<el-radio label="到付" border></el-radio>
						</el-radio-group>
						</el-form-item>
				</el-col>
				<el-col :span="8">					
					<el-form-item label="邮费">
						<el-input v-model="form.postage"></el-input>
					</el-form-item>
				</el-col>
			</el-row>
			<el-form-item label="退货地">
				<el-radio v-model="form.retreat" label="大陆" border>大陆</el-radio>
				<el-radio v-model="form.retreat" label="海外" border>海外</el-radio>
			</el-form-item>
			<el-form-item label="是否包退">
				<el-radio disabled v-model="form.isRefund" label="选中且禁用" border>承诺包退（如退货,退回的运费、保险费由买家解决）</el-radio>
			</el-form-item>
			<el-form-item label="藏品描述">
				<el-input type="textarea" rows="5" v-model="form.describe"></el-input>
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
				<el-button type="primary" @click="onSubmit">立即发布</el-button>
				<el-button>取消</el-button>
			</el-form-item>
		</el-form>
	</div>
</template>

<script>
	import '~/assets/css/trade.css'
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
				form: {
					sellerId: '1', //商家名称
					categoryId: '', //分类主键       		           
					category: [], //分类子叶    		          
					title: '', //藏品名称
					price: '', //价格 		           
					jyxz: '', //交易限制
					freightrate: '', //运费情况
					postage: '', //邮费
					retreat: '', //退货地
					isRefund: '', //是否包退
					describe: '', //藏品描述
					image: [] //上传图片
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
				axios.post('http://localhost:8082/dzhshop/add.do', obj)
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
			show(obj) {
				//获取parentIdd数组参数id后赋值
				var self = this;
				axios.get('http://localhost:8082/itemCat/findByParentId.do?', {
					params: {
						parentId: obj
					}
				}).then(function(res) {
					self.parentList = res.data

				});

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
.step {
    width: 600px;
    margin: 30px 0 0 80px;
}
</style>