var result = 0;
var num = [];

while(true){
	var count = prompt("请输入考试科目数量：","");
	count = parseInt(count);
	if(count < 0){
		alert("考试科目不能小于0！");
		continue;
	}
	if(isNaN(count)){
		alert("输入的不是数字！");
		continue;
	}

	for(var i = 0; i <count; i++){
		num[i] = prompt("请输入第" + i+1 +"门科目成绩：","");
		
		if(num[i] < 0 ){
			alert("成绩不能为负数！");
			break;
		}
		result += parseFloat(num[i]);
	}

	alert(count + "门科目总成绩是：" + result);
	break;
}