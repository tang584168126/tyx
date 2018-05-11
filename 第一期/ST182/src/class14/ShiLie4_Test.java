package class14;

import java.util.Scanner;

public class ShiLie4_Test {
	public static void main(String[] args){
		ShiLie4 student = new ShiLie4();
		Scanner sc = new Scanner(System.in);
		double[] scores = new double[5];
		int i = 0;
		
		for(i = 0 ; i < scores.length ; i++){
			System.out.print("请输入" + (i + 1) + "位学员的成绩：");
			scores[i] = sc.nextDouble();
		}
		System.out.println("平均成绩为：" + student.getavg(scores));
		
		System.out.println("最高分为：" + student.getmax(scores));
	}

}
