package class9.doubleloop;

/**
 * 
 *  打印：  
   
 	1	*								
	3	*	*	*						
	5	*	*	*	*	*				
	7	*	*	*	*	*	*	*		
	9	*	*	*	*	*	*	*	*	*


 
 
 * 
 * @author fun
 *
 */
public class Test5 {

	public static void main(String[] args) {
		
		int i = 0 , j = 0 ;
		
		//外层循环表示：行数
		for(i = 0 ; i < 5 ; i++){
			
			//内层循环表示：
			for(j = 0 ; j < i * 2 + 1 ; j++){
				System.out.print("* ");
			}
			System.out.println();
		}
		
	}
}
