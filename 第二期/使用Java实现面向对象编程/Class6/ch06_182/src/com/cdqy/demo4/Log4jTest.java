package com.cdqy.demo4;

import java.util.InputMismatchException;
import java.util.Scanner;

import org.apache.log4j.Logger;



public class Log4jTest {
	//创建日志对象
	static Logger logger = Logger.getLogger(Log4jTest.class);
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		try {
			System.out.println("输入被除数");
			int num1 = input.nextInt();
			System.out.println("输入除数");
			int num2 = input.nextInt();
			int result = num1 / num2;
			System.out.println("结果是:"+result);
		} catch (ArithmeticException e) {
			//算术异常
			logger.debug("除数为零");
		}catch(InputMismatchException ex){
			//输入不匹配异常
			logger.debug("输入非法");
		}finally{
			System.out.println("程序结束");
		}
		
		
	}

}
