import request from '@/utils/request'

export default {
//	收获地址
	shoplist() {
		return request({
			url: `mock/5c04e14c2775cc3f82910d30/shop/`,
			method: 'get'
		})
	}
}