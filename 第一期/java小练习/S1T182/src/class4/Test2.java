package class4;

import java.util.Scanner;

public class Test2 {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		int mc = 0 ;
		
		System.out.println("请输入大赛名次：");
		mc = sc.nextInt();
		
		switch(mc){
		case 1:
			System.out.println("奖励：麻省理工大学夏令营一个月！");
			break;
		case 2:
			System.out.println("奖励：HP 笔记本电脑一台！");
			break;
		case 3:
			System.out.println("奖励：移动硬盘一个！");
			break;
		default:
			System.out.println("没有奖励");
			break;
		}
		
		
		
	}
}
