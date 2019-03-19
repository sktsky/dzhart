import request from '@/utils/request'

export default {
//	保证金明细
	Detailed() {
		return request({
			url: `mock/5c05e35de1eaff56e652cef1/myauction/bond`,
			method: 'get'
		})
	}
}