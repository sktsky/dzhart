import request from '@/utils/request'

export default {
//地摊收藏-全部
	allList() {
		return request({
			url: `mock/5c0373ed0694c411d85d83cb/tradelist/t1`,
			method: 'get'
		})
	},
	//地摊收藏-瓷器
	Porcelain(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/t2`,
			method:'get'
		})
	},
	//地摊收藏-玉器
	Jade(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/t3`,
			method:'get'
		})
	},
	//地摊收藏-字画
	painting(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/t4`,
			method:'get'
		})
	},
	//地摊收藏-钱币
	Coin(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/t5`,
			method:'get'
		})
	},
	//地摊收藏-木器
	Woodenware(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/t6`,
			method:'get'
		})
	},
	//地摊收藏-铜器
	Bronze(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/t7`,
			method:'get'
		})
	},
	//地摊收藏-珠宝
	Jewellery(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/t8`,
			method:'get'
		})
	},
	//地摊收藏-钟表西洋器
	watches(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/t9`,
			method:'get'
		})
	},
	//地摊收藏-杂项
	miscellaneous(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/t10`,
			method:'get'
		})
	},
	//地摊收藏-工艺品
	Arts(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/t11`,
			method:'get'
		})
	},
	//地摊收藏-衍生品
	Derivative(){
		return request({
			url:`mock/5c0373ed0694c411d85d83cb/tradelist/t12`,
			method:'get'
		})
	}
	
	
	
	
}