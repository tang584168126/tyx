package class14;

import java.util.Scanner;

public class Calculator_1 {
	double num1;
	double num2;
	Scanner sc = new Scanner(System.in);
	Calculator cal = new Calculator();
	//ѡ��ķ���
	public void choice(){
		int num;
		System.out.println("��ѡ�����㣺(1.�ӷ� 2.���� 3.�˷� 4.����)");
		num = sc.nextInt();
		switch(num){
		case 1:
			shuRu();
			cal.add(num1, num2);
			System.out.println("***********");
			System.out.println("������Ϊ��" + cal.result);
			break;
		case 2:
			shuRu();
			cal.minus(num1, num2);
			System.out.println("***********");
			System.out.println("������Ϊ��" + cal.result);
			break;
		case 3:
			shuRu();
			cal.multiplde(num1, num2);
			System.out.println("***********");
			System.out.println("������Ϊ��" + cal.result);
			break;
		case 4:
			shuRu();
			cal.divide(num1, num2);
			System.out.println("***********");
			System.out.println("������Ϊ��" + cal.result);
			break;
		}
	}
	//����ķ���
	public void shuRu(){
		System.out.println("�������һ������");
		num1 = sc.nextDouble();
		System.out.println("�������һ������");
		num2 = sc.nextDouble();
		
	}
	

}
