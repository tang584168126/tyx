package class9;

import java.util.Scanner;

public class Sx4 {
	public static void main(String[] args){
		int i = 0 ; 
		int j = 0;
		int k = 0;
		int high = 0 ; 			//输入的最长行数
		int sum = 0 ; 			//输入的最长列数
		Scanner sc = new Scanner(System.in);
		System.out.print("请输入高度(高度为奇数，若为偶数则高度自动加1)：");
		high = sc.nextInt();
		high = high / 2 + 1;
		for(i = 0 ; i < high ; i++){
			for(k = 0 ; k < high - 1 - i ; k ++){
				System.out.print("  ");
			}
			for(j = 0 ; j < 2 * i + 1 ; j++){
				System.out.print("* ");
			}
			System.out.println();
		}
		sum = j ;
		for(i = 0 ; i < high - 1 ; i++){
			for(k = 0 ; k <= i ; k++){
				System.out.print("  ");
			}
			for(j = 0 ; j < sum - 2 - 2 * i ; j++){
				System.out.print("* ");
			}
			System.out.println();
		}
	}

}
