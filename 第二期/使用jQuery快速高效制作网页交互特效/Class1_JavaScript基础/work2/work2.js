var hours=prompt("请输入当前小时数：","");

if(hours >=12 && hours <=18){
	document.write("下午好！欢迎来到贵美");
}else if(hours >=19 && hours <=23){
	document.write("晚上好！欢迎来到贵美");
}else{
	document.write("上午好！欢迎来到贵美");
}