package class9;

import java.util.Scanner;

public class Test6 {
	public static void main(String[] args){
		int i = 0 ; 
		int j = 0 ; 
		int k = 0 ;
		int high = 0 ; 				//行数即高度
		int n = 0;
		
		Scanner sc = new Scanner(System.in);
		 System.out.print("请输入行数(奇数)：");
		 high = sc.nextInt();
		 while(high % 2 == 0){
			 System.out.print("请输入奇数：");
			 high = sc.nextInt();
		 }
		 n = high / 2 + 1 ;
		 for(i = 0 ; i < n ; i++){
			 for(k = 0 ; k < n - i - 1 ; k ++){
				 System.out.print("  ");
			 } 
			 for(j = 0 ; j < n - 3 + 2 * i ; j++){
				 System.out.print("* ");
			 }
			 System.out.println();
		 }
		 n = high / 2;
		 for(i = 0 ; i < n ; i++){
			 for(k = 0 ; k < 2 * n - 1 - 2 * i ; k ++){
				 System.out.print("  ");
			 }
			 for(j = 0 ; j < i + 1 ; j++){
				 System.out.print("* ");
			 }
			 System.out.println();
		 }
	}

}
