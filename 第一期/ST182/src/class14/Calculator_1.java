package class14;

import java.util.Scanner;

public class Calculator_1 {
	double num1;
	double num2;
	Scanner sc = new Scanner(System.in);
	Calculator cal = new Calculator();
	//选择的方法
	public void choice(){
		int num;
		System.out.println("请选择运算：(1.加法 2.减法 3.乘法 4.除法)");
		num = sc.nextInt();
		switch(num){
		case 1:
			shuRu();
			cal.add(num1, num2);
			System.out.println("***********");
			System.out.println("运算结果为：" + cal.result);
			break;
		case 2:
			shuRu();
			cal.minus(num1, num2);
			System.out.println("***********");
			System.out.println("运算结果为：" + cal.result);
			break;
		case 3:
			shuRu();
			cal.multiplde(num1, num2);
			System.out.println("***********");
			System.out.println("运算结果为：" + cal.result);
			break;
		case 4:
			shuRu();
			cal.divide(num1, num2);
			System.out.println("***********");
			System.out.println("运算结果为：" + cal.result);
			break;
		}
	}
	//输入的方法
	public void shuRu(){
		System.out.println("请输入第一个数：");
		num1 = sc.nextDouble();
		System.out.println("请输入第一个数：");
		num2 = sc.nextDouble();
		
	}
	

}
