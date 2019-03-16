import request from '@/utils/request'
const group_name = 'personaldate'
//const api_name = 'enterprise'
export default {
  getList() {
    return request({
      url: `/${group_name}/findOne.do?id=38`,
      method: 'get'
    })
  },
  save(form) {
    return request({
      url: `/$(group_name)/add.do`,
      method: 'post',
      data: form
    })
  },
  getlist() {
    return request({
      url: `/mock/5c206fc50fd1077df5e6e924/s/adress`,
      method: 'get'
    })
  }
}
