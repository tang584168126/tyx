package class8;

import java.util.Scanner;

/**
 * 描述：二维数组
 * @author fun
 *
 */
public class Test7 {

	public static void main(String[] args) {
		
		//一维数组的呈现形式：
		// 1 2 3 4 5
		
		//二维数组的呈现形式：
		/*
			1  2  3
			4  5  6
			7  8  9
		*/
		
		int [][] stuScores = new int[2][3];
		int i = 0 , j = 0 ;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入各班级学生分数：");
		
		for(i = 0 ; i < 2 ; i++){
			System.out.println("第 " + (i + 1) + " 个班：");
			for(j = 0 ; j < 3 ; j++){
				System.out.println("第 " + (j + 1) + " 个学生：");
				stuScores[i][j] = sc.nextInt();
			}
		}
		
		
		System.out.println("=============================");
		
		System.out.println(" \t 学生1 \t 学生2 \t 学生3");
		
		for(i = 0 ; i < 2 ; i++){
			
			System.out.print("第 " + (i + 1) + " 个班：  ");
			
			for(j = 0 ; j < 3 ; j++){
				System.out.print(stuScores[i][j] + " \t ");
			}
			
			System.out.println();
		}
		
		
	}
}
