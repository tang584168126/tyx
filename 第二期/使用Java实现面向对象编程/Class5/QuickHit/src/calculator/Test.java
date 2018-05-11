package calculator;

import java.util.Scanner;

/**
 * 测试类
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args) {
		double num1;
		double num2;
		double sum;
		char symbol;		//运算符号
		
		Scanner sc = new Scanner(System.in);
		
		Factory factory = new Factory();
		
		System.out.println("请输入第一个数：");
		num1 = sc.nextDouble();
		
		System.out.println("请输入运算符号：");
		symbol = sc.next().charAt(0);
		
		System.out.println("请输入第二个数：");
		num2 = sc.nextDouble();
		
		Operation operation = factory.createOperation(num1, num2, symbol);
		
		sum = operation.getResult(num1, num2);
		
		System.out.println(sum);
	}
}
