package Class3;

import java.util.Scanner;

public class Test5 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		
		double scoer = 0;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入刘珊珊的成绩：");
		scoer = sc.nextInt();
		
		//此时需用else if  而不是多重if
		if(scoer == 100){
			System.out.println("父亲给他买一辆车");
		}else
		if(scoer >= 90){
			System.out.println("母亲给她买一部笔记本电脑");
		}else
		if(scoer >= 60){
			System.out.println("母亲给他买一部手机");
		}else{
		System.out.println("没有奖励");
		}
		System.out.println("程序结束");
	}

}
