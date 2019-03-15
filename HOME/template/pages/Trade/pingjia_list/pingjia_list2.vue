<!-- 我的卖家信誉 -->
<template id="pingjia_list2">
	<div>
		<div class="my_credit">卖家信誉
			<i class="iconfont icon-v0 icon-credit"></i>
			<span><span id="LabSPrestige">1</span></span>
		</div>
		<table class="Table">
			<tbody>
				<tr class="tr_heads">
					<th width="404">描述</th>
					<th width="152">信誉值增减</th>
					<th width="160">卖家信誉值</th>
					<th width="190">时间</th>
				</tr>

				<tr v-for="msg in sellerlist" :key="msg.index">
					<td>{{msg.describe}}</td>
					<td class="t_orange">{{msg.Increase}}</td>
					<td>{{msg.buyer}}</td>
					<td>{{msg.time}}</td>
				</tr>

			</tbody>
		</table>
	</div>
</template>

<script>
	import pingjiaApi from '~/api/pingjia'
	export default {
		data() {
			return {
				sellerlist: []
			};
		},
		created: function() {
			var self = this;
			//获取我的卖家信誉请求
			pingjiaApi.Seller().then(function(res) {

				self.sellerlist = res.data.sellerlist

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
		text-align: center;
	}
	
	.jd_m_mbor {
		background-color: #d0d0d0;
	}
	
	.jd_cz_tbl th {
		border: 1px solid #e5e5e5;
	}
	
	.my_credit {
		height: 25px;
		font: 16px "SimHei", "Microsoft YaHei", "SimSun", "Arial", "sans-serif";
		font-weight: normal;
		line-height: normal;
		font-weight: bold;
		line-height: 25px;
		color: #000;
		margin: 10px 0 0 10px;
	}
</style>