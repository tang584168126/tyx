package class9.doubleloop;

/**
 * 
 *  ��ӡ��  
   
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
		
		//���ѭ����ʾ������
		for(i = 0 ; i < 5 ; i++){
			
			//�ڲ�ѭ����ʾ��
			for(j = 0 ; j <= i ; j++){
				System.out.print("* ");
			}
			System.out.println();
		}
		
	}
}
