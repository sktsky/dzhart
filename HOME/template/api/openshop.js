import request from '@/utils/request'

export default {
    //邮箱提交
  send(form) {
    return request({
      url: `applicationshop/add.do`,
      method: 'post',
      data: form
    })
  }
}
