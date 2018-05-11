package class9.doubleloop;

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
public class Test7 {

	public static void main(String[] args) {
		
		int i = 0 , j = 0 , k = 0 ;
		
		
		//外层循环表示：行数
		for(i = 0 ; i < 5 ; i++){
			
			//内层循环1表示：空格的数量
			for(k = 0 ; k < 5 - i - 1 ; k++){
				System.out.print("  ");
			}
			
			
			//内层循环2表示：要打印的列数量
			for(j = 0 ; j < i * 2 + 1 ; j++){
				System.out.print("* ");
			}
			System.out.println();
		}
		
		
		//外层循环表示：行数
		for(i = 0 ; i < 5 - 1 ; i++){
			
			//内层循环1表示：空格的数量
			for(k = 0 ; k <= i ; k++){
				System.out.print("  ");
			}
			
			
			//内层循环2表示：要打印的列数量
			for(j = 0 ; j < 9 - 2 * i - 2 ; j++){
				System.out.print("* ");
			}
			System.out.println();
		}
		
	}
}
