package class9;

import java.util.Scanner;

public class Test4 {
	public static void main(String[] args){
		int i = 0 ; 			//班级
		int j = 0 ;				//	参赛学员	
		double score = 0 ;
		double avg = 0	;
		double sum = 0	;
		int index = 0 ;			//计数器
		Scanner sc = new Scanner(System.in);
		
		for(i = 0 ; i < 3; i++){
			System.out.println("第" + (i + 1) + "个班：");
			for(j = 0 ; j < 4 ; j++){
				System.out.print("第" + (j + 1) + "个学员的成绩：");
				score = sc.nextInt();
				if(score > 85){
					sum += score ; 
					index++;
				}
			}
		}
		avg = sum / index ;
		System.out.println("所有参赛学员成绩大于85分的平均分为：" + avg);
	}

}
