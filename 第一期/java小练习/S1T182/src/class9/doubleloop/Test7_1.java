package class9.doubleloop;

/**
 * 
 *  ��ӡ��  
   
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
		
		//���ѭ����ʾ������
		for(i = 0 ; i < 5 - 1 ; i++){
			
			//�ڲ�ѭ��1��ʾ���ո������
			for(k = 0 ; k <= i ; k++){
				System.out.print("  ");
			}
			
			
			//�ڲ�ѭ��2��ʾ��Ҫ��ӡ��������
			for(j = 0 ; j < 9 - 2 * i - 2 ; j++){
				System.out.print("* ");
			}
			System.out.println();
		}
		
	}
}
