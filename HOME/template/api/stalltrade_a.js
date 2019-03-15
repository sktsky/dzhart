import request from '@/utils/request'
//  地摊交易-所有地摊-待售藏品-已售藏品-工艺品区

export default {
//已售藏品-全部
	allList() {
		return request({
			url: `mock/5c0373ed0694c411d85d83cb/tradelist/salelist`,
			method: 'get'
		})
	},
	//已售藏品-瓷器
	Porcelain(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/salelist1`,
			method:'get'
		})
	},
	//已售藏品-玉器
	Jade(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/salelist2`,
			method:'get'
		})
	},
	//已售藏品-字画
	painting(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/salelist3`,
			method:'get'
		})
	},
	//已售藏品-钱币
	Coin(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/salelist4`,
			method:'get'
		})
	},
	//已售藏品-木器
	Woodenware(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/salelist5`,
			method:'get'
		})
	},
	//已售藏品-铜器
	Bronze(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/salelist6`,
			method:'get'
		})
	},
	//已售藏品-珠宝
	Jewellery(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/salelist7`,
			method:'get'
		})
	},
	//已售藏品-钟表西洋器
	watches(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/salelist8`,
			method:'get'
		})
	},
	//已售藏品-杂项
	miscellaneous(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/salelist9`,
			method:'get'
		})
	},
	//已售藏品-工艺品
	Arts(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/salelist10`,
			method:'get'
		})
	},
	//已售藏品-衍生品
	Derivative(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/salelist11`,
			method:'get'
		})
	}
	
	
	
	
}