package class4;

import java.util.Scanner;

public class Test1 {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		int mc = 0 ;
		
		System.out.println("请输入大赛名次：");
		mc = sc.nextInt();
		
		if(mc == 1){
			System.out.println("奖励：麻省理工大学夏令营一个月！");
		}
		else if(mc == 2){
			System.out.println("奖励：HP 笔记本电脑一台！");
		}
		else if(mc == 3){
			System.out.println("奖励：移动硬盘一个！");
		}
		else{
			System.out.println("没有奖励");
		}
	}
}
