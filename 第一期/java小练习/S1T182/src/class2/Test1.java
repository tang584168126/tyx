package class2;

import java.util.Scanner;

public class Test1 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//做好接收用户输入数据的准备
		Scanner sc = new Scanner(System.in);
		
		//创建一个变量，用来表示用户存到银行的存款数
		int bankMoney = 0 ;
		
		//在接收用户输入数据之前 一定要给予用户提示
		System.out.println("请输入存款金额：");
		
		//接收用户输入的金额
		bankMoney = sc.nextInt();
		

		System.out.print("您已存入：" + bankMoney + " 元");
	}

}
