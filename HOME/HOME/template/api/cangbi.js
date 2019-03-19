import request from '@/utils/request'

export default {
//	藏币收支
	Budget() {
		return request({
			url: `mock/5bfcdf487b0f173d0a13af27/cangbi/cangbi`,
			method: 'get'
		})
	}
}