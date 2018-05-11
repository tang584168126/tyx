package class15;

import java.util.Scanner;

public class RegisterTest {
	public static void main(String[] args){
		String name = "";
		String pwd = "";
		String delpwd = "";
		
		Register register = new Register();
		Scanner sc = new Scanner(System.in);
		do{
			System.out.println("请输入用户名：");
			name = sc.next();
			System.out.println("请输入密码：");
			pwd = sc.next();
			System.out.println("青再次输入密码：");
			delpwd = sc.next();
			register.verify(name , pwd , delpwd);
		}while(register.isok == false);
		System.out.println("注册成功！请牢记用户名和密码。");
	}

}
