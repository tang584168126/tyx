package class9.doubleloop;

import java.util.Scanner;

/**
 * 
 *  打印：  
   
 	1					*				
	3				*	*	*			
	5			*	*	*	*	*		
	7		*	*	*	*	*	*	*	
	9	*	*	*	*	*	*	*	*	*
	 		*	*	*	*	*	*	*
	 			*	*	*	*	*	
	 				*	*	*		
	 					*	


 
 
 * 
 * @author fun
 *
 */
public class Test8 {

	public static void main(String[] args) {
		
		int i = 0 , j = 0 , k = 0 ;
		int num = 0 ;	//用户输入的行数
		int sum = 0 ;	//最长的列数
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入菱形行数：(只能是奇数，如果您输入偶数，我们将默认加 1 )");
		num = sc.nextInt();
		
		num = num / 2 + 1;
		
		//外层循环表示：行数
		for(i = 0 ; i < num ; i++){
			
			//内层循环1表示：空格的数量
			for(k = 0 ; k < num - i - 1 ; k++){
				System.out.print("  ");
			}
			
			
			//内层循环2表示：要打印的列数量
			for(j = 0 ; j < i * 2 + 1 ; j++){
				System.out.print("* ");
			}
			System.out.println();
		}
		
		sum = j ;
		
		
		//外层循环表示：行数
		for(i = 0 ; i < num - 1 ; i++){
			
			//内层循环1表示：空格的数量
			for(k = 0 ; k <= i ; k++){
				System.out.print("  ");
			}
			
			
			//内层循环2表示：要打印的列数量
			for(j = 0 ; j < sum - 2 * i - 2 ; j++){
				System.out.print("* ");
			}
			System.out.println();
		}
		
	}
}
