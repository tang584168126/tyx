function show(address){
	var count = 0;
	var name = "";
	while(true){
		name = "";
		count = 0;
		count = address.indexOf("@");
		if(count == 0){
			alert("����������Ϊ�գ�");
			break;
		}
		if(count == -1){
			alert("û�С�@�����ţ�");
			break;
		}
		name = address.substring(0,count);
		count = address.indexOf(".");
		if(count == -1){
			alert("û�С�.�����ţ�");
			break;
		}
		if(count == 0){
			alert("���������벻��ȷ��");
			break;
		}
		alert("�����ַ��ȷ�����������ǣ�" + name);
		break;
	}
}