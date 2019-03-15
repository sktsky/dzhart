<!-- 保证金明细begin -->
<template id="Baozhengjinmingxi">
	<div>
		<table class="Table Table2" width="950">
			<tbody>
				<tr class="tr_heads">
					<td>流水号</td>
					<td>时间</td>
					<td>收支类型</td>
					<td>保证金</td>
					<td>资金类型</td>
					<td>保证金余额</td>
				</tr>
				<tr v-for="msg in bondlist" :key="msg.index">
					<td align="center" valign="middle" bgcolor="#FFFFFF">
						{{msg.number}}
					</td>
					<td class="pai_td_con" align="center" valign="middle" bgcolor="#FFFFFF">
						{{msg.time}}
					</td>
					<td class="pai_td_xg" align="center" valign="middle" bgcolor="#FFFFFF">
						{{msg.budstyle}}
					</td>
					<td align="center" valign="middle" bgcolor="#FFFFFF" style="color:red;">
						{{msg.money}}
					</td>
					<td class="pai_td_con" align="center" valign="middle" bgcolor="#FFFFFF">
						{{msg.capstyle}}
					</td>
					<td class="pai_td_xg" align="center" valign="middle" bgcolor="#FFFFFF" style="color:red;">
						{{msg.balmoney}}
					</td>
				</tr>
			</tbody>
		</table>
		<div class="pai_tc_page">

		</div>

	</div>
</template>

<script>
	import baoApi from '~/api/baozhengjin'
	export default {
		data() {
			return {
				bondlist: []
			}
		},
		created: function() {
			var self = this;
			baoApi.Detailed().then(function(res) {
				self.bondlist = res.data.list
			})
		}
	}
</script>

<style>

</style>