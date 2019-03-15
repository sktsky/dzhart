<template>
  <div class="mright">
    <div class="msg_menu">
      <router-link to="/msglistsd" class="msg_m_i">
        <span class="msg_img msg_m_img msg_m_fa_s"></span>
        <span class="msg_m_name">收信箱</span>
      </router-link>
      <router-link to="/msglistse" class="msg_m_i">
        <span class="msg_img msg_m_img msg_m_shou"></span>
        <span class="msg_m_name">发信箱</span>
      </router-link>
      <router-link to="/msglistsf" class="msg_m_i">
        <span class="msg_img msg_m_img msg_m_xie"></span>
        <span class="msg_m_name">写短信</span>
      </router-link>
      <div class="msg_m_iso">
        <div class="msg_img msg_m_isb">
          <input
            name="txtTitle"
            id="txtTitle"
            class="msg_m_iskey"
            value="可输网名或标题关键字查询……"
            onfocus="if(this.value=='可输网名或标题关键字查询……'){this.value='';this.style.color='';}"
            maxlength="15"
            type="text"
          >
          <input name="btnSelect" value id="btnSelect" class="msg_m_isbut fl" type="submit">
        </div>
      </div>
    </div>
    <nuxt-child/>
  </div>
</template>

<script>
import "~/assets/css/msg.css";
export default {};
</script>

<style>
</style>