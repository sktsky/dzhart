<!-- 商品上传 -->
<template id="ShopProd_M">
	<div class="step">
		<el-form ref="form" :model="form" label-width="80px">
			<el-form-item label="拍品分类">
				<el-select @change="handleChange" v-model="form.categoryId" placeholder="请选择藏品分类">
					<el-option v-for="item in parentId" :key="item.value" :label="item.name" :value="item.id">
					</el-option>
					<!-- 遍历id=0的所有 -->
				</el-select>
				<el-row>
					<el-col span="6" v-for="(item,index) in parentIdd" :key="index">
						<!-- 遍历id=1的所有 -->
						<span>{{item.name}}</span>
						<el-select @focus="show(item.id)" v-model="form.category[index]" placeholder="请选择藏品分类">
							<el-option v-for="item in parentList" :key="item.value" :label="item.name" :value="item.name">
							</el-option>
						</el-select>
					</el-col>

				</el-row>
			</el-form-item>
			<!-- 					  <el-form-item label="我的分类">
                        <el-radio-group v-model="form.resource">
                          <el-radio label="字画" border></el-radio>
                          <el-radio label="瓷器" border></el-radio>
                        </el-radio-group>
                      </el-form-item> -->
			<el-row>
				<el-col :span="12">
					<el-form-item label="商品名称">
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
				<el-radio v-model="form.jyxz" label="1" border>屏蔽藏友评论回复功能，慎用此功能</el-radio>
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
				<el-radio v-model="form.retreat" label="1" border>大陆</el-radio>
				<el-radio v-model="form.retreat" label="2" border>海外</el-radio>
			</el-form-item>
			<el-form-item label="藏品描述">
				<el-input type="textarea" v-model="form.describe"></el-input>
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
					category: [], //子叶类目     		          
					title: '', //藏品名称
					price: '', //价格 		           
					jyxz: '', //交易限制
					freightrate: '', //运费情况
					postage: '', //邮费
					retreat: '', //退货地
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
				//获取二级表单数据
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

</style>