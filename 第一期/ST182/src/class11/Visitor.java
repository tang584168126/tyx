package class11;

import java.util.Scanner;

public class Visitor {
	String name;
	int year ;
	int price;
	//��ֵ����ң����ҾͿ������  ���û�������Ͳ����жϼ۸�
	public void show(){
		Scanner sc = new Scanner(System.in);
		System.out.println("������������");
		name = sc.next();
		System.out.println("���������䣺");
		year = sc.nextInt();
		if(year > 60 || year < 18){
			price = 20;
			System.out.println("Ʊ��Ϊ��" + price);
		}
		while(name.equals("n")){
		System.out.println("�˳�����");
		System.exit(1);
		}
	}

}
