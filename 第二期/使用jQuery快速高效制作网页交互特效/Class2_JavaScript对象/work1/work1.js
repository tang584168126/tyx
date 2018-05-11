function open1(){
	var first = confirm("您本次购买的商品信息如下：\n\n商品名称：诺基亚N95；\n商品数量：1件；\n商品单价：2200；\n运费：20元；\n\n运费总计：2400元；\n\n请确认以上信息是否有误！！！");
	
	if(first){
		alert("您的订单已提交");
	}
}

function open2(){
	window.open("fullscreen");
}