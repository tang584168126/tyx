package class12;

import java.util.Scanner;

public class QuessMachine {
	String[] goods = new String[5];
	int[] price = new int[5];
	int num;
	public void intn(){
		goods[0] = "电动车";
		goods[1] = "双门冰箱";
		goods[2] = "笔记本电脑";
		goods[3] = "iphone手机";
		goods[4] = "全自动洗衣机";
		
		price[0] = 850;
		price[1] = 4800;
		price[2] = 3200;
		price[3] = 2999;
		price[4] = 1680;
	}
	public void guess(){
		intn();
		int money;
		int count = 0;
		String msg = "";
		Scanner sc = new Scanner(System.in);
		num = (int)(Math.random() * 5);
		System.out.println("商品：" + goods[num]);
		do{
			System.out.print("请输入商品价格：");
			money = sc.nextInt();
			if(money == price[num]){
				System.out.println("恭喜您！获得大奖！");
				break;
			}else if(money > price[num]){
				msg = "再小点！";
			}else if(money < price[num]){
				msg = "再大点！";
			}
			count++;
			if(count >= 4){
				System.out.println("4次都没猜对！下次努力吧！");
				break;
			}
			else{
				System.out.println(msg);
			}
		}while(true);

				
	}
	

}
