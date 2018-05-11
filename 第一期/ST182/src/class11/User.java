package class11;

import java.util.Scanner;

public class User {
	String name;
	String secret;
	int random;
	
	public void show(){
		Scanner sc = new Scanner(System.in);
		System.out.println("[奖客富翁系统 > 注册]");
		System.out.println("请填写个人注册信息：");
		System.out.print("用户名：");
		name = sc.next();		
		System.out.print("密码：");
		secret = sc.next();
		random = (int)(Math.random() * 9000 + 1000);
		System.out.println("注册成功，请记住您的会员卡号");	
		System.out.println("用户名\t密码\t会员卡号");
		
		System.out.println( name + "\t" + secret + "\t" + random);
		
	}

}
