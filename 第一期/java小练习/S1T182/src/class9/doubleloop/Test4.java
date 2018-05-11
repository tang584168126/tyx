package class9.doubleloop;

/**
 * 
 *  打印：  
   
 	*				
	*	*			
	*	*	*		
	*	*	*	*	
	*	*	*	*	*

 
 
 * 
 * @author fun
 *
 */
public class Test4 {

	public static void main(String[] args) {
		
		int i = 0 , j = 0 ;
		
		//外层循环表示：行数
		for(i = 0 ; i < 5 ; i++){
			
			//内层循环表示：
			for(j = 0 ; j <= i ; j++){
				System.out.print("* ");
			}
			System.out.println();
		}
		
	}
}
