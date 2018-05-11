package class12.homework;

import java.util.Scanner;

public class P245_5 {

	String[] goodsNames = new String[3];//商品名称
	int [] goodsprices = new int[3];	//商品价格
	int num = 0 ;						//竞猜商品的下标
	
	/**
	 * 商品信息初始化的方法
	 */
	public void init(){
		goodsNames[0] = "双门冰箱";
		goodsNames[1] = "平板彩电";
		goodsNames[2] = "滚筒洗衣机";
		
		goodsprices[0] = 5100;
		goodsprices[1] = 2999;
		goodsprices[2] = 1890;
		
	}
	

	/**
	 * 确定要竞猜的商品
	 */
	public void showGoods(){
		
		num = (int)(Math.random() * 3);
		
		System.out.println("本次竞猜的商品为：" + goodsNames[num]);
	}
	
	/**
	 * 开始竞猜游戏的方法
	 */
	public void startGame(){
		
		int money = 0 ;	//接收用户输入的竞猜价格
		int count = 0 ;	//统计用户输入竞猜价格的次数
		String msg = "";//给予用户的提示
		
		//首先初始化项目数据
		init();
		
		//获得要竞猜的商品
		showGoods();
		
		Scanner sc = new Scanner(System.in);
		
		do{
			//提示用户输入要竞猜的商品的价格
			System.out.println("请输入商品价格：");
			money = sc.nextInt();
			
			//判断用户输入的价格，与 要竞猜商品的价格的关系
			if(money == goodsprices[num]){
				//如果相等
				System.out.println("恭喜您猜中了，获得：" + goodsNames[num]);
				break;
			}
			else if(money > goodsprices[num]){
				//如果大于
				msg = "再少点！！";
			}
			else{
				//如果小于
				msg = "再多点！！";
			}
			
			count++;
			
			if(count >= 4){
				System.out.println("您已猜错 4 次，游戏结束！");
				break;
			}
			else{
				System.out.println(msg);
			}
			
		}while(true);
	}
}








