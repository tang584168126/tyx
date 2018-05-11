package Class4;

import java.util.Scanner;

public class Shop {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		double money = 0;
		int option = 0;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("请输入消费金额：");
		money = sc.nextDouble();
		System.out.println("是否参加优惠换购活动：");
		System.out.println("1:满50元，加2元换购百事可乐一瓶");
		System.out.println("2:满100元，加3元换购500ml可乐一瓶");
		System.out.println("3:满100元，加10元换购5公斤面粉一袋");
		System.out.println("4:满200元，加10元换购1个苏泊尔炒锅");
		System.out.println("5:满200元，加20元换购欧莱雅爽肤水一瓶");
		System.out.println("0：不换购");
		System.out.println("请选择：");
		option = sc.nextInt();
		
		switch(option){
		case 1:
			if(money<50){
				System.out.println("对不起，你不符合条件");
				System.out.println("本次消费总额：" + money);
			}else{
				System.out.println("本次消费总额：" + (money+2));
				System.out.println("恭喜你！换购百事可乐一瓶");
			}
			break;
		case 2:
			if(money<100){
				System.out.println("对不起，你不符合条件");
				System.out.println("本次消费总额：" + money);
			}else{
				System.out.println("本次消费总额：" + (money+3));
				System.out.println("恭喜你！换购500ml可乐一瓶");
			}
			break;
		case 3:
			if(money<100){
				System.out.println("对不起，你不符合条件");
				System.out.println("本次消费总额：" + money);
			}else{
				System.out.println("本次消费总额：" + (money+10));
				System.out.println("恭喜你！换购面粉5公斤");
			}
			break;
		case 4:
			if(money<200){
				System.out.println("对不起，你不符合条件");
				System.out.println("本次消费总额：" + money);
			}else{
				System.out.println("本次消费总额：" + (money+10));
				System.out.println("恭喜你！换购苏泊尔电炒锅一个");
			}
			break;
		case 5:
			if(money<200){
				System.out.println("对不起，你不符合条件");
				System.out.println("本次消费总额：" + money);
			}else{
				System.out.println("本次消费总额：" + (money+20));
				System.out.println("恭喜你！换购欧莱雅爽肤水一瓶");
			}
			break;
		case 0:
			System.out.println("本次消费总额：" + money);
			break;
			default:
				System.out.println("请输入有效的选项");
			break;
		}
		System.out.println("程序结束");

	}

}
