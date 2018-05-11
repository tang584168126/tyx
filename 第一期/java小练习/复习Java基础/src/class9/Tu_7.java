package class9;

import java.util.Scanner;

/**
 * 
 * 				*				
			*	*	*			
		*	*	*	*	*		
	*	*	*	*	*	*	*	
*	*	*	*	*	*	*	*	*
	*	*	*	*	*	*	*	
		*	*	*	*	*		
			*	*	*			
				*				

 * 
 * 
 * 
 * 
 * @author fun
 *
 */
public class Tu_7 {
	public static void main(String[] args){
		int i = 0 ; 
		int j = 0 ;
		int k = 0 ;
		int sum = 0 ;			//行数
		
		Scanner sc = new Scanner(System.in);
		System.out.print("请输入行数：");
		sum = sc.nextInt();
		
		sum = sum / 2 + 1 ;
		for(i = 0 ; i < sum ; i++){
			for(k = 0 ; k < sum - i - 1 ; k++){
				System.out.print("  ");
			}
			
			for(j = 0 ; j < 2 * i + 1 ; j++){
				System.out.print("* ");
			}
			System.out.println();
		}
		
		sum = sum - 1 ;
		for(i = 0 ; i < sum ; i++){
			for(k = 0 ; k <= i ; k++){
				System.out.print("  ");
			}
			
			for(j = 0 ; j < 2 * sum - 1 - 2 * i ; j++){
				System.out.print("* ");
			}
			System.out.println();
		}
	}
}
