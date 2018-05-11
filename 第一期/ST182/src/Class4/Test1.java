package Class4;

import java.util.Scanner;

public class Test1 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int day = 0;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入今天星期几：");
		
		if(sc.hasNextInt() == true){
			day = sc.nextInt();
			if(day > 7){
				System.out.println("没有星期天以上");
			}
		
		switch(day){
		case 1:
		case 3:
		case 5:
			System.out.println("学习编程");
			break;
		case 2:
		case 4:
		case 6:
			System.out.println("学习英语");
			break;
		case 7:
			System.out.println("休息");
			break;
		}
		}else{
			System.out.println("没有这天 请重新输入");
		}
		System.out.println("程序结束");

	}

}
