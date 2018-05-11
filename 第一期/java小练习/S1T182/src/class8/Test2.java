package class8;

import java.util.Scanner;

public class Test2 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int i = 0 ;
		String[] stuNames = new String[3];
		double [] stuScores = new double[3];
		
		Scanner sc = new Scanner(System.in);
		
		
		//System.out.println("请输入学生姓名及分数：");
		
		for(i = 0 ; i < stuNames.length ; i++){
			
			System.out.println("请输入第" + (i + 1) + "个学员姓名：");
			stuNames[i] = sc.next();
			
			System.out.println("请输入第" + (i + 1) + "个学员成绩：");
			stuScores[i] = sc.nextDouble(); 
		}
		
		System.out.println("\n==========================\n");
		
		
		System.out.println("学生姓名为：");
		for(i = 0 ; i < stuNames.length ; i++){
			
			System.out.println(i + 1 + ":" + stuNames[i] + " \t " + stuScores[i]);
			
		}
	}

}
