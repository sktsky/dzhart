import request from '@/utils/request'

export default {
//	收获地址
	getlist() {
		return request({
			url: `/mock/5c206fc50fd1077df5e6e924/s/adress`,
			method: 'get'
		})
	}
}