package class2;

import java.util.*;

/**
 *  ������ �����û�������������֣����м��㡣
 *	���ߣ� fun
 *	ʱ�䣺 2014-4-26
 *	�ص㣺 ����У��һ��ѧ¥208	
 */


public class Clace {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		//���ý����û������׼��
		Scanner sc = new Scanner(System.in);
		
		//����2���洢���ݵı���
		
//		double num1 = 0 ;
//		double num2 = 0 ;
		double num1 = 0 , num2 = 0 ;
		
		//��ʾ�û�Ҫ����������
		System.out.println("�������һ������");
		num1 = sc.nextDouble();
		
		System.out.println("������ڶ�������");
		num2 = sc.nextDouble();
		
		System.out.println("=================================");
		
		System.out.println("������ĵ�һ�����ǣ�" + num1);
		System.out.println("������ĵڶ������ǣ�" + num2);
		
		System.out.println("=================================");
		
		System.out.println("����֮��Ϊ��" + (num1 + num2));
		System.out.println("����֮��Ϊ��" + (num1 - num2));
		System.out.println("����֮��Ϊ��" + (num1 * num2));
		System.out.println("����֮��Ϊ��" + (num1 / num2));
		
		System.out.println("=================================");
		
		System.out.println("����֮��Ϊ��" + num1 + " + " + num2 + " = " + (num1 + num2));
		System.out.println("����֮��Ϊ��" + num1 + " - " + num2 + " = " + (num1 - num2));
		System.out.println("����֮��Ϊ��" + num1 + " * " + num2 + " = " + (num1 * num2));
		System.out.println("����֮��Ϊ��" + num1 + " / " + num2 + " = " + (num1 / num2));
	}

}
