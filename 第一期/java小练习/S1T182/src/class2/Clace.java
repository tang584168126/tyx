package class2;

import java.util.*;

/**
 *  描述： 接收用户输入的两个数字，进行计算。
 *	作者： fun
 *	时间： 2014-4-26
 *	地点： 青羊校区一教学楼208	
 */


public class Clace {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		//做好接收用户输入的准备
		Scanner sc = new Scanner(System.in);
		
		//声明2个存储数据的变量
		
//		double num1 = 0 ;
//		double num2 = 0 ;
		double num1 = 0 , num2 = 0 ;
		
		//提示用户要输入数据了
		System.out.println("请输入第一个数：");
		num1 = sc.nextDouble();
		
		System.out.println("请输入第二个数：");
		num2 = sc.nextDouble();
		
		System.out.println("=================================");
		
		System.out.println("您输入的第一个数是：" + num1);
		System.out.println("您输入的第二个数是：" + num2);
		
		System.out.println("=================================");
		
		System.out.println("两数之和为：" + (num1 + num2));
		System.out.println("两数之差为：" + (num1 - num2));
		System.out.println("两数之积为：" + (num1 * num2));
		System.out.println("两数之商为：" + (num1 / num2));
		
		System.out.println("=================================");
		
		System.out.println("两数之和为：" + num1 + " + " + num2 + " = " + (num1 + num2));
		System.out.println("两数之差为：" + num1 + " - " + num2 + " = " + (num1 - num2));
		System.out.println("两数之积为：" + num1 + " * " + num2 + " = " + (num1 * num2));
		System.out.println("两数之商为：" + num1 + " / " + num2 + " = " + (num1 / num2));
	}

}
