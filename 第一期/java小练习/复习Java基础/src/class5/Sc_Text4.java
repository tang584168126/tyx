package class5;

import java.util.Scanner;

public class Sc_Text4 {
	public static void main(String[] args){
		int sum = 0 ;
		int max = 0 , min = 0 ;
		
		Scanner sc = new Scanner(System.in);
		System.out.print("请输入一个整数（输入0结束）：");
		sum = sc.nextInt();
		max = sum ;
		min = sum ;
		do{
			System.out.print("请输入一个整数（输入0结束）：");
			sum = sc.nextInt();
			if(sum == 0 ){
				System.out.println("最大值：" + max + " 最小值：" + min);
				break;
			}
			if(max < sum){
				max = sum ;
			}
			if(min > sum){
				min = sum ;
			}
		}while(sum != 0);
		
				
	}

}
