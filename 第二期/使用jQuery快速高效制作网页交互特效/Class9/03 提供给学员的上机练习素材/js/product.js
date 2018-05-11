/*浏览同级分类*/
var list = ["中国当代小说(13880)","中国近代小...(640)","中国古典小说(1547)","四大名著(696)","港澳台小说(838)","外国小说(5119)","侦探/悬疑/推...(2519)","惊悚/恐怖(796)"];
var $new = "";
for(var i = 0; i < list.length; i++){
	$new += "<li>"+ list[i] +"</li>" 
}
var $str = "<ul>" + $new + "</ul>";
$("#product_catList_class").append($str);		
