package class3;

import java.util.Scanner;

/**
 * 描述：Java成绩 大于 98 分 可 获得 MP4 奖励
 * 
 * @author fun
 *
 */
public class Test1 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		double score = 0 ;	//java 分数变量
		
		Scanner sc = new Scanner(System.in);

		System.out.println("请输入Java课程分数：");
		score = sc.nextDouble();
		
		//判断 分数 是否 大于 98
		if(score > 98){
			System.out.println("获得 MP4 奖励!");
			System.out.println("获得 老师口头 奖励!");
		}
		else{
			System.out.println("面壁思过！");
		}
		
		System.out.println("程序结束！");
	}

}







