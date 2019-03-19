import request from '@/utils/request'

export default {
    //邮箱提交
  send(form) {
    return request({
      url: `email/add.do`,
      method: 'post',
      data: form
    })
  }
}
