import request from '@/utils/request'

export default {
	//						我的卖单-全部卖单
	AllList() {
		return request({
			url: `mock/5bf796ef90fa7f6162070f84/trade_sale/#boughtlist`,
			method: 'get'
		})
	},
	//					我的卖单-进行中
	Conduct() {
		return request({
			url: `mock/5bf796ef90fa7f6162070f84/trade_sale/conduct`,
			method: 'get'
		})
	},
	//			我的买单-等待确认价格
	WConfirm() {
		return request({
			url: `mock/5bf796ef90fa7f6162070f84/trade_sale/confirm`,
			method: 'get'
		})
	},
	//			我的买单-等待付款
	WPayment() {
		return request({
			url: `mock/5bf796ef90fa7f6162070f84/trade_sale/payment`,
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
			url: 'mock/5bf796ef90fa7f6162070f84/trade_sale/Inspection',
			method: 'get'
		})
	},
	//			我的买单-交易成功
	Successtrade() {
		return request({
			url: 'mock/5bf796ef90fa7f6162070f84/trade_sale/transaction',
			method: 'get'
		})
	},
	//			我的买单-退款
	refund() {
		return request({
			url: 'mock/5bf796ef90fa7f6162070f84/trade_sale/refund',
			method: 'get'
		})
	},
	//			我的买单-需要评价
	evaluate() {
		return request({
			url: 'mock/5bf796ef90fa7f6162070f84/trade_sale/evaluate',
			method: 'get'
		})
	}

}