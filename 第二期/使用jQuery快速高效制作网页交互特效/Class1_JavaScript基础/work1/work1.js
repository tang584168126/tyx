var num = ["America","Greece","Britain","Canada","Chain","Egypt"];
var count=0;
document.write("�������ַ��У�<br/>");
for(var i= 0;i<num.length;i++){
	document.write(num[i] + "<br/>");
	num[i] = num[i].toUpperCase();
	var str = num[i].indexOf("A");
				
	if(str != -1){
		count++ ;
	}
}
			
document.write("����" + count + "���ַ����а���a��A");