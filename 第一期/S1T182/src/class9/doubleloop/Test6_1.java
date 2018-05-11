package class9.doubleloop;
/**
 * 
 *  打印：  
   
 	4	*	*	*	*					
	3	*	*	*	
	2	*	*				
	1	*		
	0	



 
 
 * 
 * @author fun
 *
 */
public class Test6_1 {

	public static void main(String[] args) {
		
		int i = 0 , j = 0 ;
		
		
		//外层循环表示：行数
		for(i = 0 ; i < 5 ; i++){
			
			//内层循环表示：列数
			for(j = 0 ; j < 5 - i - 1 ; j++){
				System.out.print("* ");
			}
			
			System.out.println();
		}
		
	}
	
	
}










