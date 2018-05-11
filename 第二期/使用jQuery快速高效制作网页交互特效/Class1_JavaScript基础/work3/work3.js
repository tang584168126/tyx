var one = prompt("请输入第一个数：","");
var two = prompt("请输入第二个数：","");
var symbol = prompt("请输入运算符号：","");
var result = 0;

switch(symbol){
	case "+":
		result = one + two;
		break;
	case "-":
		result = one - two;
		break;
	case "*":
		result = one * two;
		break;
	case "/":
		if(two == 0){
			alert("除数不能为0！");
		}
		result = one / two;
		break;
	default:
		alert("没有该运算符！");
		break;	
}
