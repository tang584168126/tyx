package class5;

import java.util.Scanner;

public class Test4 {

	public static void main(String[] args) {
		
		String answer = "";
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请问张浩的学习任务是否合格？(Y/N)");
		answer = sc.next();
		
		while(!answer.equalsIgnoreCase("y")){
			System.out.println("上午阅读教材，下午上机操作！");
			
			System.out.println("请问张浩的学习任务是否合格？(Y/N)");
			answer = sc.next();
		}
		
		System.out.println("程序结束！");
		
	}
	
}
