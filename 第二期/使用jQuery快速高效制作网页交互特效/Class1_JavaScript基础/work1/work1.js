var num = ["America","Greece","Britain","Canada","Chain","Egypt"];
var count=0;
document.write("在以下字符中：<br/>");
for(var i= 0;i<num.length;i++){
	document.write(num[i] + "<br/>");
	num[i] = num[i].toUpperCase();
	var str = num[i].indexOf("A");
				
	if(str != -1){
		count++ ;
	}
}
			
document.write("共有" + count + "个字符串中包含a或A");