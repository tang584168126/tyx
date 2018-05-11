$(function(){
	/*弹窗*/
	window.open("open.html");
	/*右侧广告图片*/
	$("#dd_close").click(function(){
		$("#right").hide();
	});
	$(document).scroll(function(){		
		$("#right").css("marginTop",$(document).scrollTop());
	});
	/*循环广告图片*/  
	var i = 0;
	$("#scroll_number li:eq(0)").addClass("scroll_number_over");	
	var ff = setInterval(function(){
		$("#scroll_img li").fadeOut();
		$("#scroll_number li").removeClass("scroll_number_over");
		i++;
		if(i == 6){
			i = 0;
		}	
		$("#scroll_number li:eq("+i+")").addClass("scroll_number_over");
		$("#scroll_img li:eq("+i+")").fadeIn();						
	},5000);
	$("#scroll_number li").mouseover(function(){		
		$(this).siblings().removeClass("scroll_number_over");
		$(this).addClass("scroll_number_over");		
		i = $(this).text()-1;
		$("#scroll_img li").fadeOut();
		$("#scroll_img li:eq("+i+")").fadeIn();		
	});
	/*Tab切换特效*/
	$("#history,#family,#culture,#novel").mouseover(function(){
		var $id = $("#book_"+$(this).attr("id"));
		$(this).siblings().removeClass("book_type_out");
		$($id).siblings().css("display","none");
		$(this).addClass("book_type_out");
		$($id).css("display","block");
	});
	$("#book_history dd,#book_family dd,#book_novel dd,#book_culture dd").hover(function(){
		$(this).css({"border":"2px #ccc solid"});
	},function(){
		$(this).css({"border":"2px #fff solid"});
	});
	//书讯快递
	var b = setInterval(function(){
		var j = 0;
		var $mail = $("#express li:first").remove();
		$("#express").append($mail);		
	},1000)
	
})