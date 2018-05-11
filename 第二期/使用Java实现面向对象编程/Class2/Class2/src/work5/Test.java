package work5;

import java.util.Scanner;

/**
 * 测试类
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args){
		int day = 0;	//天数
		int money = 0;	//每日租金
		int count1 = 0;	//选项一次
		int count2 = 0;
		int index1 = 0;	//选项二次:轿车、客车
		int index2 = 0;	//选项二次：金杯，金龙
		int item1 = 0;	//选项三次：宝马
		int item2 = 0;	//选项三次：别客
		char matha = ' ';//随机字母
		int math1 = (int)(Math.random()*9000 + 1000);		//随机数数字
		
		Scanner sc = new Scanner(System.in);
		
		//随机两位大写字母
		for(int i = 0; i < 2; i++){
			matha += (char)(Math.random() * 26 + 'A');		
		}
		
		System.out.print("请输入要租赁的天数：");
		day = sc.nextInt();
		
		System.out.print("请输入要租赁汽车的类型：(1.轿车 2.客车)");
		count1 = sc.nextInt();
		
		if(count1 == 1){
			System.out.print("请输入要租赁汽车的品牌：(1.宝马 2.别克)");
			index1 = sc.nextInt();	
			if(index1 == 1){
				System.out.print("请输入轿车的型号1.宝马550i：");
				item1 = sc.nextInt();
				if(item1 == 1){
					System.out.println("分配给你的汽车号是：京" + matha + math1);
				}else{
					System.out.println("没有该型号的车！");
				}
			}else if(index1 == 2){
				System.out.print("请输入轿车的型号 2.商务舱GL8 3.林荫大道：");
				item2 = sc.nextInt();
				if(item2 ==2){
					System.out.println("分配给你的汽车号是：京" + matha + math1);
				}else if(item2 ==3){
					System.out.println("分配给你的汽车号是：京" + matha + math1);
				}else{
					System.out.println("没有该型号的车！");
				}
			}else{
				System.out.println("没有该品牌！");
			}
		}else if(count2 ==2){
			System.out.print("请输入要租赁客车的品牌：(1.金杯 2.金龙)");
			index2 = sc.nextInt();
			if(index2 == 1){
				
			}
		}
	}
}
