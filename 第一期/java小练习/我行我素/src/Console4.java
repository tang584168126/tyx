

import java.util.Scanner;

public class Console4 {
	public static void main(String[] args) {
		int numShirt = 0;
		int numShoe = 0;
		int numPad = 0;
		Scanner sc = new Scanner(System.in);
		System.out.println("T恤个数：");
		numShirt = sc.nextInt();
		System.out.println("球鞋个数：");
		numShoe = sc.nextInt();
		System.out.println("球拍个数：");
		numPad = sc.nextInt();
		int buyShirt = numShirt * 245;
		int buyShoe = numShoe * 570;
		int buyPad = numPad * 320;
		System.out.println("*************消费单***********");
		System.out.println("购买物品 \t 单价 \t 个数 \t 金额");
		System.out.println("T恤 \t ￥245 \t" + numShirt + "\t ￥" + buyShirt);
		System.out.println("球鞋 \t ￥570 \t" + numShoe + "\t ￥" + buyShoe);
		System.out.println("球拍 \t ￥320\t" + numPad+ "\t ￥" + buyPad);
		System.out.println("折扣：");
		double zheKo = sc.nextDouble();
		double shoudJiao = (numShirt * 245 + numShoe * 570 + numPad * 320) * (1 - zheKo);
		System.out.println("应缴费：" + shoudJiao);
		System.out.println("实际交费：");
		int jiaoFei = sc.nextInt();
		double yu = jiaoFei - shoudJiao;
		System.out.println("找零：" + yu);
		int fen = (int)shoudJiao * 3 /100;
		System.out.println("本次购物所获得的积分：" + fen);
	}

}
