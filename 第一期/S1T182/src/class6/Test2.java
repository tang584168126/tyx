package class6;

import java.util.Scanner;

public class Test2 {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int i = 0 ;
		String name = "";
		double score = 0 ;
		int num = 0 ;		//科目数量
		double sum = 0 , avg = 0 ;
		
		System.out.println("请输入学生姓名：");
		name = sc.next();
		
		System.out.println("请输入学生科目数量：");
		num = sc.nextInt();
		
		for(i = 0 ; i < num ; i++){
			
			System.out.print("第 " + (i + 1) + " 门功课成绩：");
			score = sc.nextDouble();
			
			//每接收一次用户的分数，就将该分数放入总分
			sum += score ;
			
		}
		
		//计算平均分
		avg = sum / num ;
		
		System.out.println(name + "的平均分为：" + avg);
	}
}
