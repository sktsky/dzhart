import request from '@/utils/request'
//  鉴定估价-有偿鉴定-我的帖子

export default {
//全部-全部
	allList() {
		return request({
			url: `/mock/5c206fc50fd1077df5e6e924/s/adress`,
			method: 'get'
		})
	},
	//全部-瓷器
	Porcelain(){
		return request({
			url:`mock/5c0106de4ed9b43d7590d4eb/estimation/mylist1`,
			method:'get'
		})
	},
	//全部-玉器
	Jade(){
		return request({
			url:`mock/5c0106de4ed9b43d7590d4eb/estimation/mylist2`,
			method:'get'
		})
	},
	//全部-字画
	painting(){
		return request({
			url:`mock/5c0106de4ed9b43d7590d4eb/estimation/mylist3`,
			method:'get'
		})
	},
	//全部-钱币
	Coin(){
		return request({
			url:`mock/5c0106de4ed9b43d7590d4eb/estimation/mylist4`,
			method:'get'
		})
	},
	//全部-木器
	Woodenware(){
		return request({
			url:`mock/5c0106de4ed9b43d7590d4eb/estimation/mylist5`,
			method:'get'
		})
	},
	//全部-铜器
	Bronze(){
		return request({
			url:`mock/5c0106de4ed9b43d7590d4eb/estimation/mylist6`,
			method:'get'
		})
	},
	//全部-珠宝
	Jewellery(){
		return request({
			url:`mock/5c0106de4ed9b43d7590d4eb/estimation/mylist7`,
			method:'get'
		})
	},
	//全部-钟表西洋器
	watches(){
		return request({
			url:`mock/5c0106de4ed9b43d7590d4eb/estimation/mylist8`,
			method:'get'
		})
	},
	//全部-文献书籍
	books(){
		return request({
			url:`mock/5c0106de4ed9b43d7590d4eb/estimation/mylist9`,
			method:'get'
		})
	},
	//全部-杂项
	miscellaneous(){
		return request({
			url:`mock/5c0106de4ed9b43d7590d4eb/estimation/mylist10`,
			method:'get'
		})
	}
	
	
	
}