<!-- 拍品上传 -->
<template id="AuctionProduct_M6">
	<div class="step">
		<el-form ref="form" :model="form" label-width="80px">
			<el-form-item label="拍品分类">
				<el-select @change="handleChange" v-model="form.categoryId" placeholder="请选择藏品分类">
					<el-option v-for="item in parentId" :key="item.value" :label="item.name" :value="item.id">
					</el-option>
					<!-- 遍历id=0的所有 -->
				</el-select>
				<el-row>
					<el-col span="6" v-for="(item,index) in parentIdd" :key="item.index">
						<!-- 遍历id=1的所有 -->
						<span>{{item.name}}</span>
						<el-select @focus="show(item.id)" v-model="form.category[index]" placeholder="请选择藏品分类">
							<el-option v-for="item in parentList" :key="item.value" :label="item.name" :value="item.name">
							</el-option>
						</el-select>
					</el-col>

				</el-row>
			</el-form-item>
			<el-col :span="12">
				<el-form-item label="拍品名称">
					<el-input v-model="form.title"></el-input>
				</el-form-item>
			</el-col>
			<div class="clear"></div>
			<el-form-item label="截止时间">
				<el-col :span="11">
					<el-date-picker type="date" placeholder="选择日期" v-model="form.Deadline" style="width: 100%;"></el-date-picker>
				</el-col>
				<el-col class="line" :span="2">-</el-col>
				<el-col :span="11">
					<el-time-picker type="fixed-time" placeholder="选择时间" v-model="form.datetime" style="width: 100%;"></el-time-picker>
				</el-col>
			</el-form-item>
			<el-col :span="12">
				<el-form-item label="起拍价格">
					<el-input v-model="form.startingprice"></el-input>
				</el-form-item>
			</el-col>
			<el-col :span="12">
				<el-form-item label="一口价">
					<el-input v-model="form.price"></el-input>
				</el-form-item>
			</el-col>
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
			<el-col :span="12">
				<el-form-item label="拍品尺寸">
					<el-input v-model="form.size"></el-input>
				</el-form-item>
			</el-col>
			<div class="clear"></div>
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
					categoryId: '', //藏品主键       		           
					category: [], //子叶类目    		          
					title: '', //藏品名称
					freightrate: '', //运费情况	
					describe: '', //藏品描述
					startingprice: '', //起拍价格
					price: '', //一口价 		           
					postage: '', //邮费
					Deadline: '', //截止时间 年-月-日  时：分：秒
					image: [], //上传图片
					size: '' //拍品尺寸        		        	   
				}
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

		},
		methods: {
			//图片上传成功后赋值
			handleSuccess(response, file, fileList) {
				var self = this;
				console.log(file);
				self.fileList.push(file.response.url)
				console.log(file.response.url);
				console.log(file.raw)
				self.form.image = self.fileList
			},
			handleRemove(file, fileList) {
				console.log(file, fileList);
			},
			handlePictureCardPreview(file) {
				this.dialogImageUrl = file.url;
				this.dialogVisible = true;
			},
			onSubmit() {
				//上传表单提交
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
				//获取二级表单数据
				axios.get('http://localhost:8082/itemCat/findByParentId.do?', {
					params: {
						parentId: row
					}
				}).then(function(res) {
					self.parentIdd = res.data
				});
			},
			show(obj) {
				//二级表单获取焦点时遍历
				var self = this;
				axios.get('http://localhost:8082/itemCat/findByParentId.do?', {
					params: {
						parentId: obj
					}
				}).then(function(res) {
					self.parentList = res.data

				});

			}
		}
		}
</script>

<style>

</style>