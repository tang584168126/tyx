package class9.doubleloop;

import java.util.Scanner;

/**
 * 
 *  ��ӡ��  
   
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
public class Test8 {

	public static void main(String[] args) {
		
		int i = 0 , j = 0 , k = 0 ;
		int num = 0 ;	//�û����������
		int sum = 0 ;	//�������
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("����������������(ֻ�������������������ż�������ǽ�Ĭ�ϼ� 1 )");
		num = sc.nextInt();
		
		num = num / 2 + 1;
		
		//���ѭ����ʾ������
		for(i = 0 ; i < num ; i++){
			
			//�ڲ�ѭ��1��ʾ���ո������
			for(k = 0 ; k < num - i - 1 ; k++){
				System.out.print("  ");
			}
			
			
			//�ڲ�ѭ��2��ʾ��Ҫ��ӡ��������
			for(j = 0 ; j < i * 2 + 1 ; j++){
				System.out.print("* ");
			}
			System.out.println();
		}
		
		sum = j ;
		
		
		//���ѭ����ʾ������
		for(i = 0 ; i < num - 1 ; i++){
			
			//�ڲ�ѭ��1��ʾ���ո������
			for(k = 0 ; k <= i ; k++){
				System.out.print("  ");
			}
			
			
			//�ڲ�ѭ��2��ʾ��Ҫ��ӡ��������
			for(j = 0 ; j < sum - 2 * i - 2 ; j++){
				System.out.print("* ");
			}
			System.out.println();
		}
		
	}
}
