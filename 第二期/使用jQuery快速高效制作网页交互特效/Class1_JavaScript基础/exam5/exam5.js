function moth(week){
	switch(week){
		case "星期一":
			alert("新的一周开始了");
			break;
		case "星期二":
		case "星期三":
		case "星期四":
			alert("努力工作");
			break;	
		case "星期五":
			alert("明天就是周末了");
			break;
		default:
			alert("放松的休息");
			break;
	}
}