var one = prompt("�������һ������","");
var two = prompt("������ڶ�������","");
var symbol = prompt("������������ţ�","");
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
			alert("��������Ϊ0��");
		}
		result = one / two;
		break;
	default:
		alert("û�и��������");
		break;	
}
