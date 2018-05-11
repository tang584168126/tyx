package class6;

import java.util.Scanner;

public class Test3 {

	public static void main(String[] args) {
		
		int num = 0 ;	//接收用户输入的数字
		Scanner sc = new Scanner(System.in);
		int i = 0 , j = 0 ;
		
		System.out.println("请输入一个整数：");
		num = sc.nextInt();
		
		System.out.println("根据这个值可以显示以下加法表：");
		
		for(i = 0 , j = num ; i <= num ; i++ , j--){
			
			System.out.println(i + " + " + j + " = " + num);
			
		}
		
	}
}





