package class3;

import java.util.Scanner;

public class Test7 {
	public static void main(String[] args) {
		
		//变量声明
		double score = 0 ;	//接收用户输入的百米成绩
		String sex = "";	//接收用户输入的性别
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入您百米成绩：");
		score = sc.nextDouble();
		
		//判断用户是否进入决赛
		if(score <= 10){
			
			//如果 用户 进入了决赛，则询问用户的性别
			System.out.println("请输入您的性别：(男/女)");
			sex = sc.next();
			
			//判断用户性别，决定分组情况
			if(sex.equals("男")){
				System.out.println("请于明日上午9:00 参加男子组决赛！");
			}
			else if(sex.equals("女")){
				System.out.println("请于明日下午2:00 参加女子组决赛！");
			}
			else{
				System.out.println("对不起，拒绝人妖参赛！");
			}
			
		}
		else{
			System.out.println("很遗憾，您的成绩不足以进入决赛！");
			
			//如果 用户 未进入决赛，则询问用户的性别
			System.out.println("请输入您的性别：(男/女)");
			sex = sc.next();

			//判断用户性别，决定分组情况
			if(sex.equals("男")){
				System.out.println("请于明日参观决赛！");
			}
			else if(sex.equals("女")){
				System.out.println("请于明日参加决赛拉拉队！");
			}
			else{
				System.out.println("对不起，拒绝人妖观赛！");
			}
		}
	}
}






