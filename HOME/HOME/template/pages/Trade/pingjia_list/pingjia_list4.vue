<!-- 我的评价 -->
<template id="pingjia_list4">
	<el-tabs v-model="activeName" @tab-click="handleClick">
		<el-tab-pane label="动态评价" name="first"></el-tab-pane>
		<el-tab-pane label="历史评价" name="second">
			<table class="Table">
				<tbody>
					<tr class="tr_heads">
						<th width="40"></th>
						<th width="111">买家</th>
						<th width="562">评价内容</th>
						<th width="192">时间</th>
					</tr>

					<tr v-for="msg in historytlist" :key="msg.index">
						<td></td>
						<td>{{msg.buyer}}</td>
						<td>{{msg.evaluate}}</td>
						<td>{{msg.time}}</td>
					</tr>

				</tbody>
			</table>
		</el-tab-pane>
	</el-tabs>
</template>
<!-- 我的评价 end -->

<script>
	import { getData } from '~/plugins/axios.js'
	export default {
		data() {
			return {
				activeName: 'first',
				historytlist: []
			};
		},
		methods: {
			handleClick(tab, event) {}
		},
		created: function() {
			var self = this;
			//获取历史评价请求
			getData('mock/5bfcae904540a062a039a479/pingjia/historyt', 'get').then(function(res) {

				self.historytlist = res.data.historytlist

			}, function() {
				console.log('请求失败')
			})

		}
	}
</script>

<style>
	.Table {
		border-collapse: collapse;
		border: none;
		color: #646464;
		margin: 10px 0 0 10px;
	}
	
	.Table .tr_heads th {
		color: #000;
		background: #f2f2f2;
	}
	
	.Table td,
	.Table .tr_heads th {
		border: solid #e5e5e5 1px;
		padding: 5px;
		text-align: center;
	}
	
	.jd_m_mbor {
		background-color: #d0d0d0;
	}
	
	.jd_cz_tbl th {
		border: 1px solid #e5e5e5;
	}
</style>