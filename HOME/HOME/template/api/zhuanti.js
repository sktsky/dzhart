import request from '@/utils/request'

export default {
	//	我的博物馆
	myMuseum() {
		return request({
			url: `/mock/5c206fc50fd1077df5e6e924/s/adress`,
			method: 'get'
		})
	},
	//	所有博物馆
	allMuseum() {
		return request({
			url: `mock/5c02305110c9227e21fe7944/zhuanti/all`,
			method: 'get'
		})
	},
	//	活动专区
	activity() {
		return request({
			url: `mock/5c02305110c9227e21fe7944/zhuanti/activity`,
			method: 'get'
		})
	}
}