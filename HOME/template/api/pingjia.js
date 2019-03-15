import request from '@/utils/request'

export default {
//	收获地址
	Buyer() {
		return request({
			url: `mock/5bfcae904540a062a039a479/pingjia/pingjia`,
			method: 'get'
		})
	},
	Seller(){
		return request({
			url:`mock/5bfcae904540a062a039a479/pingjia/seller`,
			method:'get'
		})
	}
}