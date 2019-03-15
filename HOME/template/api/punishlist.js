import request from '@/utils/request'

export default {
//	我作出的投诉
	Make() {
		return request({
			url: `mock/5bf7cc8f2caeed673a1af57b/Trade_Complaint/Trade_Complaint#complaintlist`,
			method: 'get'
		})
	},
//	我收到的投诉
	Received(){
		return request({
			url:`mock/5bf7cc8f2caeed673a1af57b/Trade_Complaint/Trade_Complaint#complaintlist`,
			method:'get'
		})
	}
}