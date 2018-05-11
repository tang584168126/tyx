package class3;

import java.util.Scanner;

public class Test3 {

	public static void main(String[] args) {
		
		//声明变量
		String 中奖 = "";
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("是否中奖？？(Y/N)");
		中奖 = sc.next();
		
		if(中奖.equalsIgnoreCase("y")){
			System.out.println("买车、买房、捐希望工程");
		}
		else{
			System.out.println("继续购买彩票，继续烧香！！");
		}
			
		
		
		
	}
}
