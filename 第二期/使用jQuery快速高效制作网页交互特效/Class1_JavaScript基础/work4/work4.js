var result = 0;
var num = [];

while(true){
	var count = prompt("�����뿼�Կ�Ŀ������","");
	count = parseInt(count);
	if(count < 0){
		alert("���Կ�Ŀ����С��0��");
		continue;
	}
	if(isNaN(count)){
		alert("����Ĳ������֣�");
		continue;
	}

	for(var i = 0; i <count; i++){
		num[i] = prompt("�������" + i+1 +"�ſ�Ŀ�ɼ���","");
		
		if(num[i] < 0 ){
			alert("�ɼ�����Ϊ������");
			break;
		}
		result += parseFloat(num[i]);
	}

	alert(count + "�ſ�Ŀ�ܳɼ��ǣ�" + result);
	break;
}