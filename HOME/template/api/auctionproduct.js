import request from '@/utils/request'

export default {
	//到期拍品、我的拍品begin
	//	全部拍品
	allLot() {
		return request({
			url: `mock/5c05e35de1eaff56e652cef1/myauction/`,
			method: 'get'
		})
	},
	//未审
	Untried() {
		return request({
			url: `mock/5c05e35de1eaff56e652cef1/myauction/a1`,
			method: 'get'
		})
	},
	//待售
	forsale() {
		return request({
			url: `mock/5c05e35de1eaff56e652cef1/myauction/a2`,
			method: 'get'
		})
	},
	//已售
	Sold() {
		return request({
			url: `mock/5c05e35de1eaff56e652cef1/myauction/a3`,
			method: 'get'
		})
	},
	//到期待售
	Expire() {
		return request({
			url: `mock/5c05e35de1eaff56e652cef1/myauction/a4`,
			method: 'get'
		})
	},
	//待生成订单
	generate() {
		return request({
			url: `mock/5c05e35de1eaff56e652cef1/myauction/a5`,
			method: 'get'
		})
	},
	//已生成订单
	Generated() {
		return request({
			url: `mock/5c05e35de1eaff56e652cef1/myauction/a6`,
			method: 'get'
		})
	},
	//到期拍品、我的拍品and
	//我的收藏
	Mycollection(){
		return request({
			url:`mock/5c05e35de1eaff56e652cef1/myauction/auction`,
			method:'get'
		})
	},
	//我的报价-全部报价
	offer(){
		return request({
			url:`mock/5c05e35de1eaff56e652cef1/myauction/l1`,
			method:'get'
		})
	},
	//我的报价-胜出
	beat(){
		return request({
			url:`mock/5c05e35de1eaff56e652cef1/myauction/l2`,
			method:'get'
		})
	},
	//我的报价-领先
	Lead(){
		return request({
			url:`mock/5c05e35de1eaff56e652cef1/myauction/l3`,
			method:'get'
		})
	},
	//我的报价-落后
	backward(){
		return request({
			url:`mock/5c05e35de1eaff56e652cef1/myauction/l4`,
			method:'get'
		})
	},
	//我的报价-结拍
	tiepat(){
		return request({
			url:`mock/5c05e35de1eaff56e652cef1/myauction/l5`,
			method:'get'
		})
	},
	//别人报价
	Others(){
		return request({
			url:`mock/5c05e35de1eaff56e652cef1/myauction/peo`,
			method:'get'
		})
	},
	//我的代理价-全部代理价
	agent(){
		return request({
			url:`mock/5c05e35de1eaff56e652cef1/myauction/ag`,
			method:'get'
		})
	},
	//我的代理价-正在代理
	Being(){
		return request({
			url:`mock/5c05e35de1eaff56e652cef1/myauction/ag1`,
			method:'get'
		})
	},
	//我的代理价-过期代理
	overdue(){
		return request({
			url:`mock/5c05e35de1eaff56e652cef1/myauction/ag2`,
			method:'get'
		})
	},
	//我的代理价-未结拍
	Unfilming(){
		return request({
			url:`mock/5c05e35de1eaff56e652cef1/myauction/ag3`,
			method:'get'
		})
	},
	//我的代理价-已结拍
	Patted(){
		return request({
			url:`mock/5c05e35de1eaff56e652cef1/myauction/ag4`,
			method:'get'
		})
	}
	
}