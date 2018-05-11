package class5;

import java.util.Scanner;

public class Test6 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int num = 0 ;
		
		Scanner sc = new Scanner(System.in);
		do{
			System.out.println("1、登录");
			System.out.println("2、退出");
			System.out.println("请选择：");
			
			if(!sc.hasNextInt()){
				System.out.println("输入错误，请重新输入！");
				sc = new Scanner(System.in);
				
			}
			else{
				break;
			}
		}while(true);
		
		num = sc.nextInt();
		
		switch(num){
		case 1:
			System.out.println("1、客户管理");
			System.out.println("2、退出");
			System.out.println("请选择：");
			break;
		case 2:
			System.out.println("欢迎下次使用！");
			System.exit(1);
			break;
		}
		

	}

}
