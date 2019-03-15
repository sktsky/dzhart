	<!--写短信 -->
<template>
			<div>
			<div class="msg_pbox" style="clear:both; height:55px;width:970px;background-color:#FFF;">
                <input id="btnsendMsg" class="msg_img msg_send_but mt15 ml15" value="" onclick="sendMsg();" type="button">
                <input class="msg_img msg_cancel_but mt15 ml15" id="Button3" value="" type="button">
            </div>
            <div class="msg_rbox mb80">
                <div class="msg_fapeople">发件人：<a href="" target="_blank">yeyou33</a></div>
                <div class="msg_shoupeople">收件人：<input name="msgTo" id="msgTo" class="msg_s_ptext" type="text"><select class="msg_s_psel" id="selType" onchange="msgTo.value=document.all.selType.value" style="width:initial;">
                        <option value="" selected="selected">常见网站工作人员选择</option>
                        <option value="管理员">管理员   （专场、战略合作）</option>
                        <option value="管理员1">管理员1 （网站产品策划、合作）</option>
                        <option value="管理员2">管理员2 （身份验证）</option>
                        <option value="管理员3">管理员3 （访谈、杂志、编辑）</option>
                        <option value="管理员4">管理员4 （编辑、市场合作）</option>
                        <option value="管理员5">管理员5 （网店及管理）</option>
                        <option value="管理员7">管理员7 （古玩城联盟）</option>
                        <option value="管理员8">管理员8 （网络网站服务）</option>
                        <option value="管理员9">管理员9 （展销、策划）</option>
                        <option value="管理员10">管理员10（商店与地摊）</option>
                        <option value="管理员11">管理员11（软件与活动）</option>
                        <option value="管理员12">管理员12（短信通与上海办事处）</option>
                        <option value="管理员16">管理员16（活动、午间小拍）</option>
                        <option value="管理员18">管理员18（评论管理、版主维护）</option>
                        <option value="JERRY">JERRY&nbsp;&nbsp;&nbsp;（交易员、密码）</option>
                    </select>
                    &lt; 详细了解工作人员 &gt;
                </div>
                <div class="msg_contitle" style="height: 60px;">
                    	主&nbsp;&nbsp;题：<input name="msgTitle" id="msgTitle" class="msg_c_ttext" type="text">
                    <p class="red" style="height: 30px; line-height: 30px;">温馨提示：请通过华夏收藏网平台交易，站外交易有风险，谨防被骗。</p>
                </div>
                <div class="msg_con_box">
                    <textarea name="msgContent" id="msgContent" rows="14" cols="80" class="msg_c_ctext ml20 mt15" onchange="msgclip.setText(this.value)"></textarea>
                </div>
                <div class="msg_tj_box mb40">
                    <input id="btnsendMsg1" class="msg_img msg_send_but mt15 ml15" value="" onclick="sendMsg();" type="button">
                    <input class="msg_img msg_cancel_but mt15 ml15" id="Button5" value="" type="button">
                    <div id="msg_copy_but" class="msg_copy_but mt15 ml15">[复制发送内容，以防丢失]</div>
                </div>
            </div>
            </div>
	</template>

<script>
	import '~/assets/css/msg.css'
	import '~/assets/css/jystyle.css'
	export default{
		
	}
</script>

<style>
</style>