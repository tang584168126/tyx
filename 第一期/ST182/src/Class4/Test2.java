package Class4;

import java.util.Scanner;

public class Test2 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//当swilch1选项太多时可以考滤 用变量/10
		int score = 0;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请你输入分数：");
		
		if(sc.hasNextInt()){
			score = sc.nextInt();
		
		switch(score/10){
		case 10:
			System.out.println("父亲给你买一辆车");
			break;
		case 9:
			System.out.println("母亲给你买一部笔记本电脑");
			break;
		case 8:
		case 7:
		case 6:
			System.out.println("母亲给你每一部手机");
			break;
			default:
				System.out.println("没有奖励");
				break;
		}		
		}else{
			System.out.println("请重新输入");
		}

		System.out.println("程序结束");

	}

}
