package class9;

import java.util.Scanner;

public class Test4_1 {
	public static void main(String[] args){
		double[] score = new double[4];		//成绩
		int i , j ;
		double avg = 0;
		double sum =  0 ;
		int index = 0 ;
		Scanner sc = new Scanner(System.in);
		for(i = 0 ; i < 3 ; i++){
			System.out.println("第" + (i + 1) + "个班：");
			for(j = 0 ; j < score.length ; j++){
				System.out.print("第" + (j + 1) + "个学员的成绩：");
				score[j] = sc.nextDouble();
				if(score[j] > 85){
					sum += score[j] ; 
					index++;
				}
			}
		}
		avg = sum / index ;
		System.out.println("所有参赛学员成绩大于85分的平均分为：" + avg);
	}

}
