package class9.doubleloop;

/**
 * 
 *  ��ӡ��  
   
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
		
		//���ѭ����ʾ������
		for(i = 0 ; i < 5 ; i++){
			
			//�ڲ�ѭ����ʾ��
			for(j = 0 ; j < i * 2 + 1 ; j++){
				System.out.print("* ");
			}
			System.out.println();
		}
		
	}
}
