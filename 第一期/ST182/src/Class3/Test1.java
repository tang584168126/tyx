package Class3;

import java.util.Scanner;

public class Test1 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		
		int password = 0;
		String name = "";
		
		
		Scanner sc = new Scanner(System.in);
		
		
		System.out.println("请输入用户名");
		name = sc.next();
		System.out.println("请输入密码");
		password = sc.nextInt();

		if(name.equals("青") && password == 123){
			System.out.println("欢迎你，青");
					
		}else{
			
			System.out.println("对不起你不是青");
		}
		System.out.println("程序结束");

	}
}
