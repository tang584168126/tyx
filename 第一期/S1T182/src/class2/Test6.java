package class2;

import java.util.*;

public class Test6 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// 由控制台输入王浩的三门功课的成绩，并
		//计算 java 与 sql 之间的分差
		//计算 三门功课平均分
		Scanner sc = new Scanner(System.in);
		int stbScore = 0 ;		//计算机基础
		int javaScore = 0 ;		//Java课程
		int sqlScore = 0 ;		//SQL数据库课程
		int fc = 0 ;			//java 与 sql 的分差
		double avg = 0 ;		//三门功课平均分
		
		//接收数据之前，必须给予用户提示
		System.out.println("请输入 计算机基础 成绩：");
		stbScore = sc.nextInt();
		
		System.out.println("请输入 Java课程 成绩：");
		javaScore = sc.nextInt();
		
		System.out.println("请输入 SQL数据库课程 成绩：");
		sqlScore = sc.nextInt();
		
		//计算 java 与 sql 之间的分差
		fc = javaScore - sqlScore ;
		
		//计算 三门功课平均分
		avg = (stbScore + javaScore + sqlScore) / 3.0 ;
		
		System.out.println("java 与 sql 之间的分差为：" + fc);
		System.out.println("三门功课平均分为：" + avg);
	}

}
