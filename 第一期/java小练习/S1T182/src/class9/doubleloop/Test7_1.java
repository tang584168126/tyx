package class9.doubleloop;

/**
 * 
 *  打印：  
   
 		*	*	*	*	*	*	*
 			*	*	*	*	*	
 				*	*	*		
 					*			




 
 
 * 
 * @author fun
 *
 */
public class Test7_1 {

	public static void main(String[] args) {
		
		int i = 0 , j = 0 , k = 0 ;
		
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
