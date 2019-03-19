	<!-- 店铺装修2 -->
	<template id="shop_list2">
            <div id="shop_cz_box" class="shop_cz_box">
                
                    <div class="shop_tpx_list">
                        <ul>
                            <li>
                                <span class="shop_tpx_bt">按店铺类型选择：</span>
                                <span class="shop_tpx_ispan shop_tpx_ispan_sel" data="-1">全部</span>
                                
                                <span class="shop_tpx_ispan" data="1">玉器</span>
                                
                                <span class="shop_tpx_ispan" data="2">瓷器</span>
                                
                                <span class="shop_tpx_ispan" data="3">铜器</span>
                                
                                <span class="shop_tpx_ispan" data="4">杂项</span>
                                
                                <span class="shop_tpx_ispan" data="5">木器</span>
                                
                                <span class="shop_tpx_ispan" data="6">钱币</span>
                                
                                <input id="HidCategory" type="hidden" value="-1">
                            </li>
                            <li>
                                <span class="shop_tpx_bt">按色系选择：</span>
                                <span class="shop_tpx_ispan shop_tpx_ispan_sel" data="-1">全部</span>
                                
                                <span class="shop_tpx_ispan" data="1">生机绿</span>
                                
                                <span class="shop_tpx_ispan" data="2">喜庆红</span>
                                
                                <span class="shop_tpx_ispan" data="3">经典黑</span>
                                
                                <span class="shop_tpx_ispan" data="4">财气紫</span>
                                
                                <span class="shop_tpx_ispan" data="5">土黄</span>
                                
                                <span class="shop_tpx_ispan" data="6">蓝色</span>
                                
                                <span class="shop_tpx_ispan" data="7">水墨</span>
                                
                                <input id="HidColor" type="hidden" value="-1">
                            </li>
                            <li>
                                <span class="shop_tpx_bt">按招牌类型选择：</span>
                                <span class="shop_tpx_ispan shop_tpx_ispan_sel" data="-1">全部</span>
                                
                                <span class="shop_tpx_ispan" data="1">图片</span>
                                
                                <span class="shop_tpx_ispan" data="2">flash</span>
                                
                                <input id="HidType" type="hidden" value="-1">
                            </li>
                            
                            <li style="height:70px;">
                                <span class="shop_tpx_bt">当前使用招牌：</span>
                                <div id="banner_dnowbox">
                                    <span id="banner_dnow" style="display:inline;float:left;"><img src="/" style="height:70px;border:0px;"></span>
                                    <img id="shop_tbn" style="" src="/">
                                </div>
                                <a class="shop_ms_ll" href="http://shop.cang.com/357102" target="_blank">浏览</a>
                            </li>
                            <li style="height:70px;">
                                <span class="shop_tpx_bt">当前店铺标志：</span>
                                <span style="display:inline;float:left;"><img src="/" style="height:70px;border:0px;"></span>
                                <span class="shop_ms_bz">
                                <input name="cbFlag" type="checkbox" id="cbFlag" value="0" checked="checked" onclick="e_shopbn(this)">
                            	    店标和店名出现在招牌 <a href="http://pay.cang.com/myhome/shop/shopInfo_M.aspx" style=" color:Green;">[修改店标]</a>
                                </span>
                                <span class="shop_ms_bz colf0 hand" onclick="mrbanner()">
                                
                           	     使用店铺默认招牌
                                </span>
                            </li>
                            <li style="margin-bottom:10px;"><span style="color:#686868;margin-left:10px;">如果你有好的模板，请发email给我们，要求：尺寸：960*150,格式：JPG,大小：小于40K，图片某些地方可以适当为自己做广告，mail：yg@hxscw.com</span></li>
                        </ul>
                    </div>
 
                    <div class="shop_mb_box">
                        
                            <ul class="shop_mb_iul">
                                <li class="shop_mb_img"><img src="/"></li>
                                <li class="shop_mb_info">
                                    <span class="shop_mb_name">20160708Banner</span>
                                    <span class="shop_mb_time">上架时间：2016-07-08</span>
                                </li>
                                <li class="shop_mb_bs">
                                    <div class="shop_mb_bsb">
                                        <span id="banner_22" class="shop_mb_sy_no" onclick="xzbanner(this,1,22)" url="http://imgnews.cang.com/201607/08/201607081605496877.jpg">使用</span>
                                    </div>
                                </li>
                            </ul>
                        
                            <ul class="shop_mb_iul">
                                <li class="shop_mb_img"><img src="/"></li>
                                <li class="shop_mb_info">
                                    <span class="shop_mb_name">杂项-黄</span>
                                    <span class="shop_mb_time">上架时间：2016-05-24</span>
                                </li>
                                <li class="shop_mb_bs">
                                    <div class="shop_mb_bsb">
                                        <span id="banner_20" class="shop_mb_ll" onclick="xzbanner(this,1,20)" url="http://imgnews.cang.com/201605/24/20160524094157_2642.jpg">使用中</span>
                                    </div>
                                </li>
                            </ul>
                        
                            <ul class="shop_mb_iul">
                                <li class="shop_mb_img"><img src="/"></li>
                                <li class="shop_mb_info">
                                    <span class="shop_mb_name">寻根山舍</span>
                                    <span class="shop_mb_time">上架时间：2016-03-02</span>
                                </li>
                                <li class="shop_mb_bs">
                                    <div class="shop_mb_bsb">
                                        <span id="banner_19" class="shop_mb_sy_no" onclick="xzbanner(this,1,19)" url="http://imgnews.cang.com/201603/02/201603021138259377.jpg">使用</span>
                                    </div>
                                </li>
                            </ul>
                        
                            <ul class="shop_mb_iul">
                                <li class="shop_mb_img"><img src="/"></li>
                                <li class="shop_mb_info">
                                    <span class="shop_mb_name">杂项系列120323</span>
                                    <span class="shop_mb_time">上架时间：2013-03-22</span>
                                </li>
                                <li class="shop_mb_bs">
                                    <div class="shop_mb_bsb">
                                        <span id="banner_16" class="shop_mb_sy_no" onclick="xzbanner(this,1,16)" url="http://imgnews.cang.com/201303/22/y20130322173438759.jpg">使用</span>
                                    </div>
                                </li>
                            </ul>
                        
                            <ul class="shop_mb_iul">
                                <li class="shop_mb_img"><img src="/"></li>
                                <li class="shop_mb_info">
                                    <span class="shop_mb_name">杂项系列130322</span>
                                    <span class="shop_mb_time">上架时间：2013-03-22</span>
                                </li>
                                <li class="shop_mb_bs">
                                    <div class="shop_mb_bsb">
                                        <span id="banner_15" class="shop_mb_sy_no" onclick="xzbanner(this,1,15)" url="http://imgnews.cang.com/201303/22/y20130322173358672.jpg">使用</span>
                                    </div>
                                </li>
                            </ul>
                        
                            <ul class="shop_mb_iul">
                                <li class="shop_mb_img"><img src="/"></li>
                                <li class="shop_mb_info">
                                    <span class="shop_mb_name">珠宝蜜蜡</span>
                                    <span class="shop_mb_time">上架时间：2013-03-22</span>
                                </li>
                                <li class="shop_mb_bs">
                                    <div class="shop_mb_bsb">
                                        <span id="banner_14" class="shop_mb_sy_no" onclick="xzbanner(this,1,14)" url="http://imgnews.cang.com/201303/22/y20130322173232249.jpg">使用</span>
                                    </div>
                                </li>
                            </ul>
                        
                            <ul class="shop_mb_iul">
                                <li class="shop_mb_img"><img src="/"></li>
                                <li class="shop_mb_info">
                                    <span class="shop_mb_name">杂项-水墨</span>
                                    <span class="shop_mb_time">上架时间：2012-09-02</span>
                                </li>
                                <li class="shop_mb_bs">
                                    <div class="shop_mb_bsb">
                                        <span id="banner_13" class="shop_mb_sy_no" onclick="xzbanner(this,1,13)" url="http://imgnews.cang.com/201209/02/y20120902232038467.jpg">使用</span>
                                    </div>
                                </li>
                            </ul>
                        
                            <ul class="shop_mb_iul">
                                <li class="shop_mb_img"><img src="/"></li>
                                <li class="shop_mb_info">
                                    <span class="shop_mb_name">玉器-淡黄</span>
                                    <span class="shop_mb_time">上架时间：2012-09-02</span>
                                </li>
                                <li class="shop_mb_bs">
                                    <div class="shop_mb_bsb">
                                        <span id="banner_12" class="shop_mb_sy_no" onclick="xzbanner(this,1,12)" url="http://imgnews.cang.com/201209/02/y20120902231939474.jpg">使用</span>
                                    </div>
                                </li>
                            </ul>
                        
                            <ul class="shop_mb_iul">
                                <li class="shop_mb_img"><img src="/"></li>
                                <li class="shop_mb_info">
                                    <span class="shop_mb_name">水墨中国</span>
                                    <span class="shop_mb_time">上架时间：2012-09-02</span>
                                </li>
                                <li class="shop_mb_bs">
                                    <div class="shop_mb_bsb">
                                        <span id="banner_11" class="shop_mb_sy_no" onclick="xzbanner(this,1,11)" url="http://imgnews.cang.com/201209/02/y20120902231853169.jpg">使用</span>
                                    </div>
                                </li>
                            </ul>
                        
                    </div>
                    <div class="shop_pt_box">
                        <div class="shop_pt_pages">
                            <div class="p_input_html">
                        	    第<input class="p_input_page" type="text" value="1" data="3">页
                            
                            </div>
                            <a class="nextpage" href="javascript:void(0);">下一页</a>
                            <a class="uppage" href="javascript:void(0);">上一页</a>
                            <div class="p_info_html">
                                <span>1</span>/3
                            </div>
                        </div>
                    </div>
                
            </div>
	</template>
	<!-- 店铺装修end-->	

<script>
	import '~/assets/css/shop.css'
	export default {
		
	}
</script>

<style>
</style>