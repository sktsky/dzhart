import request from '@/utils/request'

export default {
	//上架商品-全部商品
	allList() {
		return request({
			url: `mock/5c206fc50fd1077df5e6e924/s/shang`,
			method: 'get'
		})
	},
	//上架商品-待售商品
	forsale() {
		return request({
			url: `mock/5c206fc50fd1077df5e6e924/s/s1`,
			method: 'get'
		})
	},
	//上架商品-已定商品
	fixed() {
		return request({
			url: `mock/5c206fc50fd1077df5e6e924/s/s2`,
			method: 'get'
		})
	},
	//上架商品-已售商品
	sold() {
		return request({
			url: `mock/5c206fc50fd1077df5e6e924/s/s3`,
			method: 'get'
		})
	},
	//上架商品-推荐商品
	Recommend() {
		return request({
			url: `mock/5c206fc50fd1077df5e6e924/s/s4`,
			method: 'get'
		})
	},
	//上架商品-置顶商品
	roof() {
		return request({
			url: `mock/5c206fc50fd1077df5e6e924/s/s5`,
			method: 'get'
		})
	},
	//所有商品
	allgoods(){
		return request({
			url:`mock/5c206fc50fd1077df5e6e924/s/`,
			method:'get'
		})
	},
	//下架商品-审核下架
	examine(){
		return request({
			url:`mock/5c206fc50fd1077df5e6e924/s/shelf`,
			method:'get'
		})
	},
	//下架商品-自行下架
	Voluntarily(){
		return request({
			url:`mock/5c206fc50fd1077df5e6e924/s/shelf2`,
			method:'get'
		})
	},
	//待审商品
	Pending(){
		return request({
			url:`mock/5c206fc50fd1077df5e6e924/s/dai`,
			method:'get'
		})
	},
	//地摊导入
	leading(){
		return request({
			url:`mock/5c206fc50fd1077df5e6e924/s/dao`,
			method:'get'
		})	
	},
	//商品评论-我的商品评论
	Comment(){
		return request({
			url:`mock/5c04e14c2775cc3f82910d30/shop/shopprod`,
			method:'get'
		})
	},
	//商品评论-商品收藏
	Collection(){
		return request({
			url:`mock/5c04e14c2775cc3f82910d30/shop/cang`,
			method:'get'
		})
	}
}