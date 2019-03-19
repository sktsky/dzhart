import request from '@/utils/request'

export default {
    //手机号提交
  send(form) {
    return request({
      url: `phone/add.do`,
      method: 'post',
      data: form
    })
  }
}
