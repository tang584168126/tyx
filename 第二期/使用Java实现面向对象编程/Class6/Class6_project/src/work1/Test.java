package work1;

import java.util.InputMismatchException;
import java.util.Scanner;

public class Test {
	public static void main(String[] args) {
		int num;		//输入数字
		
		Scanner sc = new Scanner(System.in);
		
		try{
			System.out.println("请输入课程代号(1-3之间的数字)：");
			num = sc.nextInt();
			
			switch (num) {
			case 1:
				System.out.println("C#编程");
				break;
			case 2:
				System.out.println("Java编程");
				break;
			case 3:
				System.out.println("SQL基础");
				break;
			default:
				System.out.println("没有找到该课程！");
				break;
			}
		}catch(InputMismatchException e){
			System.err.println("输入错误");
		}catch(Exception ex){
			System.err.println("其他未知异常");
		}finally{
			System.out.println("欢迎提出建议！");
		}
	}
}	
