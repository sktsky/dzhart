import request from '@/utils/request'

export default {
//	我收到的退款
	Received() {
		return request({
			url: `mock/5bfa74024728c752b654dac3/refund/refund`,
			method: 'get'
		})
	},
//	我申请的退款
	Apply(){
		return request({
			url:`mock/5bfa74024728c752b654dac3/refund/apply`,
			method:'get'
		})
	}
}