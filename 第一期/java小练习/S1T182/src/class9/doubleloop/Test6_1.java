package class9.doubleloop;
/**
 * 
 *  ��ӡ��  
   
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
		
		
		//���ѭ����ʾ������
		for(i = 0 ; i < 5 ; i++){
			
			//�ڲ�ѭ����ʾ������
			for(j = 0 ; j < 5 - i - 1 ; j++){
				System.out.print("* ");
			}
			
			System.out.println();
		}
		
	}
	
	
}










