import request from '@/utils/request'
export default {
	//			我的买单-全部买单
	allPay() {
		return request({
			url: `mock/5bee927124e7ee36667dbb0f/trade/#boughtlist`,
			method: 'get'
		})
	},
	//			我的买单-进行中	
	Conduct() {
		return request({
			url: `mock/5bee927124e7ee36667dbb0f/trade/conduct#conductlist`,
			method: 'get'
		})
	},
	//			我的买单-等待确认价格
	WConfirm() {
		return request({
			url: `mock/5bee927124e7ee36667dbb0f/trade/confirm`,
			method: 'get'
		})
	},
	//			我的买单-等待付款
	WPayment() {
		return request({
			url: `mock/5bee927124e7ee36667dbb0f/trade/payment`,
			method: 'get'
		})
	},
	//			我的买单-等待发货
	Wgoods() {
		return request({
			url: 'mock/5bf796ef90fa7f6162070f84/trade_sale/goods',
			method: 'get'
		})
	},
	//			我的买单-等待验货
	WInspection() {
		return request({
			url: 'mock/5bee927124e7ee36667dbb0f/trade/Inspection',
			method: 'get'
		})
	},
	//			我的买单-交易成功
	Successtrade() {
		return request({
			url: 'mock/5bee927124e7ee36667dbb0f/trade/transaction',
			method: 'get'
		})
	},
	//			我的买单-退款
	refund() {
		return request({
			url: 'mock/5bee927124e7ee36667dbb0f/trade/refund',
			method: 'get'
		})
	},
	//			我的买单-需要评价
	evaluate() {
		return request({
			url: 'mock/5bee927124e7ee36667dbb0f/trade/evaluate',
			method: 'get'
		})
	}

}