package com.cdqy.demo1;

import java.util.Scanner;

/**
 * ��ʾ�쳣�ĳ���
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-12 ����1:57:18
 * @version 1.0
 */
public class Test {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("���뱻����");
		int num1 = input.nextInt();
		System.out.println("�������");
		int num2 = input.nextInt();
		int result = num1 / num2;
		System.out.println("�����:"+result);
	}

}
