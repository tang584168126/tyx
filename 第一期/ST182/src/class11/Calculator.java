package class11;

import java.util.Scanner;

public class Calculator {
	int num1 = 0 ;
	int num2 = 0;
	char index;
	double result ;
	Scanner sc = new Scanner(System.in);
	public void show(){
	do{
		System.out.print("�������һ������");
		num1 = sc.nextInt();
		System.out.print("������ڶ�������");
		num2 = sc.nextInt();
		System.out.println("��������ţ�");
		index = sc.next().charAt(0);
		switch(index){
		case '*' :
			System.out.println(num1 * num2);
			break;
		case '/' :
			System.out.println(num1 / num2);
			break;
		case '+' :
			System.out.println(num1 + num2);
			break;
		case '-' :
			System.out.println(num1 - num2);
			break;
		}
	}while(true);
	}
}