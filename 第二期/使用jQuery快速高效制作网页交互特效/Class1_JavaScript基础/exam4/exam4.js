function show(address){
	var count = 0;
	var name = "";
	while(true){
		name = "";
		count = 0;
		count = address.indexOf("@");
		if(count == 0){
			alert("邮箱名不能为空！");
			break;
		}
		if(count == -1){
			alert("没有“@”符号！");
			break;
		}
		name = address.substring(0,count);
		count = address.indexOf(".");
		if(count == -1){
			alert("没有“.”符号！");
			break;
		}
		if(count == 0){
			alert("邮箱名输入不正确！");
			break;
		}
		alert("邮箱地址正确，邮箱名称是：" + name);
		break;
	}
}