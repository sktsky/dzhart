import request from '@/utils/request'

export default {
//	账户明细
	Account() {
		return request({
			url: `mock/5bfbab3a95f7220381b70926/detailed`,
			method: 'get'
		})
	},
//	提现记录
	Record(){
		return request({
			url:`mock/5bfbab3a95f7220381b70926/cash`,
			method:'get'
		})
	},
//	充值记录
	Recharge(){
		return request({
			url:`mock/5bfbab3a95f7220381b70926/recharge`,
			method:'get'
		})
	}
}