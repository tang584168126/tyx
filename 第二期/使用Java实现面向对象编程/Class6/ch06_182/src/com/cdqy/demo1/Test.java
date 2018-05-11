package com.cdqy.demo1;

import java.util.Scanner;

/**
 * 演示异常的出现
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-12 下午1:57:18
 * @version 1.0
 */
public class Test {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入被除数");
		int num1 = input.nextInt();
		System.out.println("输入除数");
		int num2 = input.nextInt();
		int result = num1 / num2;
		System.out.println("结果是:"+result);
	}

}
