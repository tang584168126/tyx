package Class4;

import java.util.Scanner;

public class Test3 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {

		int month, wz = 0;
		double discount = 0.0;

		Scanner sc = new Scanner(System.in);

		System.out.println("请输入月份:");
		
		month = sc.nextInt();
		if(month > 12){
			System.out.println("输入错误");
			System.out.println("程序结束");
			System.exit(1);
		}
		System.out.println("头等舱请输入1，经济舱请输入2");
		wz = sc.nextInt();
		switch (month) {
		case 1:
		case 2:
		case 3:
		case 11:
		case 12:
			switch (wz) {
			case 1:
				discount = 0.5;
				break;
			case 2:
				discount = 0.4;
				break;
			}
			break;
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 10:
			switch (wz) {
				case 1:
					discount = 0.9;
					
					break;
				case 2:
					discount = 0.8;
					
					break;
				}
			break;
		}
		System.out.println("你的机票价格为：" + 5000 * discount);
	}

}
