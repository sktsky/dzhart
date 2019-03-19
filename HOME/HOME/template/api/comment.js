import request from '@/utils/request'

export default {
//	收获地址
	Comment() {
		return request({
			url: `mock/5c0373ed0694c411d85d83cb/tradelist/trade3`,
			method: 'get'
		})
	}
}