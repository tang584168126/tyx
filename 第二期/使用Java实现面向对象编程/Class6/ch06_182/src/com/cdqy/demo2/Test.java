package com.cdqy.demo2;

import java.util.InputMismatchException;
import java.util.Scanner;

public class Test {

	public static void main(String[] args) /*throws Exception */{
		/*
		Scanner input = new Scanner(System.in);
		try {
			System.out.println("输入被除数");
			int num1 = input.nextInt();
			System.out.println("输入除数");
			int num2 = input.nextInt();
			int result = num1 / num2;
			System.out.println("结果是:" + result);
			
		}
		catch (ArithmeticException ex) {
			//打印异常堆栈信息
			//ex.printStackTrace();
			System.out.println("除数不能为零");
			//System.exit(1);
			return;
		}catch(InputMismatchException ex){
			System.out.println("输入非法");
		}catch(Exception ex){
			ex.printStackTrace();
		}finally{
			System.out.println("程序结束...");
		}
*/
		try {
			calc();
		} catch (Exception e) {
			e.printStackTrace();
		}
		
	}
	@SuppressWarnings("unused")
	private static void calc() throws Exception{
		Scanner input = new Scanner(System.in);
		System.out.println("输入被除数");
		int num1 = input.nextInt();
		System.out.println("输入除数");
		int num2 = input.nextInt();
		int result = num1 / num2;
		System.out.println("结果是:" + result);
	}

}
