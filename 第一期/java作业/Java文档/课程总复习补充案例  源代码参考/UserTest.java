package test;

import info.User;

import java.util.Scanner;

public class UserTest {

	//���Է���
	public static void main(String[] args){
		//ʵ�������󣬶��������Ը�ֵ
		User one=new User();
	
	    one.setName("������");
	    one.setPassword("123456");
	    one.setBalance(2000);
	    one.setAccount("179708064356");
	
		//�����û�������Ϣ�����ô��ķ���
		Scanner input =new Scanner(System.in);
		System.out.println("�������˺ţ�");
		String account=input.nextLine();
		System.out.println("���������");
		double money=input.nextDouble();
		one.saving(account, money);
		System.out.println("=============================");
		//�����û�������Ϣ�����ô��ķ���
		System.out.println("������ȡ���");
		money=input.nextDouble();
		one.getting(account, money);

	}
}
