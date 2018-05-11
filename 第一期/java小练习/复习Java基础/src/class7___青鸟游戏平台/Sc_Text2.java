package class7___青鸟游戏平台;

import java.util.Scanner;

public class Sc_Text2 {
	public static void main(String[] args){
		int i = 0;
		int num = 0 ;				//输入的数字
		int result = 1 ;			//阶乘的结果
		
		Scanner sc = new Scanner(System.in);
		System.out.print("请输入正整数：");
		num = sc.nextInt();
		if(num < 1 && num > 10){
			System.out.println("无效数据");
			System.exit(1);
		}
		System.out.print(num + "！=");
		for(i = 1 ; i < num ; i++){
			result *= (i + 1) ;
			System.out.print(i + "*");
		}
		System.out.println(num + "=" + result);
				
	}

}
