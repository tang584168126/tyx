package class9;

import java.util.Scanner;

public class Test2 {

	public static void main(String[] args) {
		
		int i = 0 , j = 0 ; 
		double score = 0 ;
		double sum = 0 ;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入学生成绩：");
		
		//外层循环此处代表：班级
		for(i = 0 ; i < 3 ; i++){
			System.out.println("第" + (i + 1) + "个班级：");
			
			//总分归零
			sum = 0 ;
			
			//内层循环此处表示：每班的 4 个学生
			for(j = 0 ; j < 4 ; j++){
				System.out.println("第" + (j + 1) + "个学生成绩：");
				score = sc.nextDouble();
				
				sum += score ;
			}
			
			System.out.println("该班学生总分：" + sum);
			System.out.println("该班学生平均分：" + sum / j);
			
		}
		
	}
}





