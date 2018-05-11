package class12;

import java.util.Scanner;

public class ScoreSalceTest {

	
	public static void main(String[] args) {
		
		double[] scores = new double[3];
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入分数：");
		
		for(int i = 0 ; i < scores.length ; i++){
			System.out.println("请输入第" + (i + 1) + "门功课分数：");
			scores[i] = sc.nextDouble();
		}
		
		//创建 成绩计算类的对象
		ScoreCalc ss = new ScoreCalc();
		
		//将用户输入的成绩赋值给 成绩计算类
		ss.scores = scores;
		
		//计算总分
		ss.getSum();
		
		//计算平均分
		ss.getAvg();
		
		//显示总分
		ss.showSum();
		
		//显示平均分
		ss.showAvg();
	}
	
}
