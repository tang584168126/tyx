package com.cdqy.demo2;

import java.util.InputMismatchException;
import java.util.Scanner;

public class Test {

	public static void main(String[] args) /*throws Exception */{
		/*
		Scanner input = new Scanner(System.in);
		try {
			System.out.println("���뱻����");
			int num1 = input.nextInt();
			System.out.println("�������");
			int num2 = input.nextInt();
			int result = num1 / num2;
			System.out.println("�����:" + result);
			
		}
		catch (ArithmeticException ex) {
			//��ӡ�쳣��ջ��Ϣ
			//ex.printStackTrace();
			System.out.println("��������Ϊ��");
			//System.exit(1);
			return;
		}catch(InputMismatchException ex){
			System.out.println("����Ƿ�");
		}catch(Exception ex){
			ex.printStackTrace();
		}finally{
			System.out.println("�������...");
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
		System.out.println("���뱻����");
		int num1 = input.nextInt();
		System.out.println("�������");
		int num2 = input.nextInt();
		int result = num1 / num2;
		System.out.println("�����:" + result);
	}

}
