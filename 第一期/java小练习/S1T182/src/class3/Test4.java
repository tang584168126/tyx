package class3;

import java.util.Scanner;

public class Test4 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		double score = 0 ;
		
		System.out.println("请输入分数：");
		
		
		//多重IF结构
		/*
		if(score >= 90){
			System.out.println("优");
		}
		else if(score >= 80){
			System.out.println("良");
		}
		else if(score >= 70){
			System.out.println("中");
		}
		else if(score >= 60){
			System.out.println("及格");
		}
		else{
			System.out.println("还需要加油！！");
		}
		*/
		
		
		if(sc.hasNextDouble()){
			score = sc.nextDouble();
		}
		else{
			System.out.println("请输入正确的分数！");
			System.out.println("程序结束！");
			System.exit(1);
		}
		
		
		
		if(score < 60){
			System.out.println("还需要加油！！");
		}
		else if(score < 70){
			System.out.println("及格");
		}
		else if(score < 80){
			System.out.println("中");
		}
		else if(score < 90){
			System.out.println("良");
		}
		else{
			System.out.println("优");
		}
		

	}

}
