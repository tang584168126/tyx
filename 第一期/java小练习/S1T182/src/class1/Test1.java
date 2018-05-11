package class1;

import java.util.*;

public class Test1 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);

		int i = 0 ;
		String id = "" ;		//用户名
		String pwd = "";		//密码
		
		System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * *");
		System.out.println("*                                               *");
		System.out.println("*                                               *");
		System.out.println("*                 我行我素购物管理系统             *");
		System.out.println("*                                               *");
		System.out.println("*                                               *");
		System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * *");
		
		System.out.println("\t\t1、系统登录");
		System.out.println("\t\t2、退出");
		
		System.out.println("请输入选项：");
		i = sc.nextInt();
		
		switch(i){
		case 1:
			System.out.println("请输入用户名：");
			id = sc.next();
			
			System.out.println("请输入密码：");
			pwd = sc.next();
			
			if(id.equals("admin") && pwd.equals("admin")){
				System.out.println();
				System.out.println("            欢迎进入 我行我素购物管理系统           ");
				System.out.println();
				System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * *");
				System.out.println("*                                               *");
				System.out.println("*                1、客户信息管理                  *");
				System.out.println("*                                               *");
				System.out.println("*                                               *");
				System.out.println("*                                               *");
				System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * *");
				
			}
			
			break;
		case 2:
			//退出系统之前给予感谢
			System.out.println("欢迎下次继续使用本系统");
			
			//退出系统
			System.exit(1);
			break;
		}
	}

}
