// JavaScript Document



(function($) {
	$.extend($.fx.step,{
	    backgroundPosition: function(fx) {
            if (fx.state === 0 && typeof fx.end == 'string') {
                var start = $.curCSS(fx.elem,'backgroundPosition');
                start = toArray(start);
                fx.start = [start[0],start[2]];
                var end = toArray(fx.end);
                fx.end = [end[0],end[2]];
                fx.unit = [end[1],end[3]];
			}
            var nowPosX = [];
            nowPosX[0] = ((fx.end[0] - fx.start[0]) * fx.pos) + fx.start[0] + fx.unit[0];
            nowPosX[1] = ((fx.end[1] - fx.start[1]) * fx.pos) + fx.start[1] + fx.unit[1];
            fx.elem.style.backgroundPosition = nowPosX[0]+' '+nowPosX[1];

           function toArray(strg){
               strg = strg.replace(/left|top/g,'0px');
               strg = strg.replace(/right|bottom/g,'100%');
               strg = strg.replace(/([0-9\.]+)(\s|\)|$)/g,"$1px$2");
               var res = strg.match(/(-?[0-9\.]+)(px|\%|em|pt)\s(-?[0-9\.]+)(px|\%|em|pt)/);
               return [parseFloat(res[1],10),res[2],parseFloat(res[3],10),res[4]];
           }
        }
	});
})(jQuery);


//自顶向下
$(function(){
	$("#a a").css({backgroundPosition: "-20px 35px"}).mouseover(function(){
		$(this).stop().animate({
			backgroundPosition:"(-20px 94px)"
		},{duration:500})
	}).mouseout(function(){
		$(this).stop().animate({
			backgroundPosition:"(40px 35px)"
		},{duration:200, complete:function(){
			$(this).css({backgroundPosition: "-20px 35px"})
		}})
	})
	
	//楼层式
	$("#Louti ul li:even").addClass("bgl");
	$("#Louti ul li:odd").addClass("bg2");
	$("#Louti ul li").mouseenter(function(){
		$(this).addClass("bg3").siblings("li").removeClass("bg3");
		});
	
	$("#Louti ul li").click(function(){
		var _index = $(this).index();
		$("body,html").animate({scrollTop:_index*700},500);
		});
});


//搜索框
jQuery(document).ready(function(){
								
	  //download script
	  jQuery('.s_download').on("click", function(e) {
			var semail = jQuery("#itzurkarthi_email").val();
			if(semail == '')
			{
				return false;
			}
			var str = "sub_email="+semail
			jQuery.ajax({
				type: "POST",
				url: "",
				data: str,
				cache: false,
				success: function(htmld){
						jQuery('#down_update').html(htmld);
				}
			});
	  });
});


//jQuery轻量级焦点图切换
jQuery(".foucebox").slide({ effect:"fold", autoPlay:true, delayTime:300, startFun:function(i){	
	jQuery(".foucebox .showDiv").eq(i).find("h2").css({display:"none",bottom:0}).animate({opacity:"show",bottom:"60px"},300);
	
	jQuery(".foucebox .showDiv").eq(i).find("p").css({display:"none",bottom:0}).animate({opacity:"show",bottom:"10px"},300);
}});
