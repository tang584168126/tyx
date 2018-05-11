package class9;

import java.util.Scanner;

/**
 * 
 
* 				
*	*			
*	*	*		
*	*	*	*	
*	*	*	*	*

 * 
 * 
 * @author fun
 *
 */
public class Tu_2 {
	public static void main(String[] args){
		int i = 0 ; 
		int j = 0 ;
		int sum = 0 ;			//行数
		
		Scanner sc = new Scanner(System.in);
		System.out.print("请输入行数：");
		sum = sc.nextInt();
		
		for(i = 0 ; i < sum ; i++){
			for(j = 0 ; j <= i ; j++){
				System.out.print("* ");
			}
			System.out.println();
		}
	}
}
