package test;

import info.User;

import java.util.Scanner;

public class UserTest {

	//测试方法
	public static void main(String[] args){
		//实例化对象，对所有属性赋值
		User one=new User();
	
	    one.setName("王丽丽");
	    one.setPassword("123456");
	    one.setBalance(2000);
	    one.setAccount("179708064356");
	
		//接收用户输入信息，调用存款的方法
		Scanner input =new Scanner(System.in);
		System.out.println("请输入账号：");
		String account=input.nextLine();
		System.out.println("请输入存款金额：");
		double money=input.nextDouble();
		one.saving(account, money);
		System.out.println("=============================");
		//接收用户输入信息，调用存款的方法
		System.out.println("请输入取款金额：");
		money=input.nextDouble();
		one.getting(account, money);

	}
}
