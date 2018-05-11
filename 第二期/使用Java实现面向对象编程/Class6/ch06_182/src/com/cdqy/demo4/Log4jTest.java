package com.cdqy.demo4;

import java.util.InputMismatchException;
import java.util.Scanner;

import org.apache.log4j.Logger;



public class Log4jTest {
	//������־����
	static Logger logger = Logger.getLogger(Log4jTest.class);
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		try {
			System.out.println("���뱻����");
			int num1 = input.nextInt();
			System.out.println("�������");
			int num2 = input.nextInt();
			int result = num1 / num2;
			System.out.println("�����:"+result);
		} catch (ArithmeticException e) {
			//�����쳣
			logger.debug("����Ϊ��");
		}catch(InputMismatchException ex){
			//���벻ƥ���쳣
			logger.debug("����Ƿ�");
		}finally{
			System.out.println("�������");
		}
		
		
	}

}
