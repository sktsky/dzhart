import request from '@/utils/request'

export default {
	//	专拍申请-我的专场
	Special() {
		return request({
			url: `mock/5c05e35de1eaff56e652cef1/myauction/list`,
			method: 'get'
		})
	}
}