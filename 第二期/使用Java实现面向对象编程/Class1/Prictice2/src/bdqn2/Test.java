package bdqn2;

import java.util.Scanner;

public class Test {

	public static void main(String[] args)
	{
		int choice;	//ѡ��
		String name;	//��������
		String colour;	//������ɫ
		String strain;	//Ʒ��
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("������Ҫ������������ͣ�(1.���� 2.����)");
		choice = sc.nextInt();
		
		switch(choice)
		{
			case 1:
				System.out.println("������Ʒ�֣�");
				strain = sc.next();
				System.out.println("��������ɫ��");
				colour = sc.next();
				System.out.println("�������ǳƣ�");
				name = sc.next();
				
				Dog dog = new Dog();
				dog.name = name;
				dog.colour = colour;
				dog.strain = strain;
				
				dog.print();
				break;
			case 2:
				System.out.println("�ó��������꣬���½⣡");
				break;
			default:
				System.out.println("û�и�ѡ�");
				break;
		
		}
	}
}
