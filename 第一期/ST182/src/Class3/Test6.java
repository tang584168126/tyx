package Class3;

import java.util.Scanner;

public class Test6 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		
		int month = 0;
		int num = 0;
		double discount = 0.0;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入出行的月份：1~12");
		month = sc.nextInt();
		System.out.println("请问你选择头等舱还是经济舱？头等舱输入1，经济舱输入2");
		num = sc.nextInt();
		
		//if else和if if   要注意区别
		if(month >=4 && month <=10){
			if(num == 1){
				discount = 0.9;
				System.out.println("你的机票价格为：" + 5000*discount);
		}
			else if(num == 2){
				discount = 0.8;
				System.out.println("你的机票价格为：" + 5000*discount);
			}
		}
		else if((month <4 || month >10 && month <=12) && num == 1){
			discount = 0.5;
			System.out.println("你的机票价格为：" + 5000*discount);
		}
		else if((month <4 || month >10 && month <=12) && num == 2){
			discount = 0.4;
			System.out.println("你的机票价格为：" + 5000*discount);
		}
		else if(month >12 ){
			System.out.println("没有这个月份，请重新输入");
		}
		
		
		System.out.println("程序结束");
	}

}
