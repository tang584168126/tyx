package calculator;

import java.util.Scanner;

/**
 * ������
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args) {
		double num1;
		double num2;
		double sum;
		char symbol;		//�������
		
		Scanner sc = new Scanner(System.in);
		
		Factory factory = new Factory();
		
		System.out.println("�������һ������");
		num1 = sc.nextDouble();
		
		System.out.println("������������ţ�");
		symbol = sc.next().charAt(0);
		
		System.out.println("������ڶ�������");
		num2 = sc.nextDouble();
		
		Operation operation = factory.createOperation(num1, num2, symbol);
		
		sum = operation.getResult(num1, num2);
		
		System.out.println(sum);
	}
}
