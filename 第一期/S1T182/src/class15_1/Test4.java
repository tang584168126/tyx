package class15_1;

import java.util.Scanner;

/**
 * �������ҵ��û����������еĶ�� �� ��
 * @author fun
 *
 */
public class Test4 {

	public static void main(String[] args) {
		
		int i = 0 , count = 0 ;
		String str = "";
		Scanner sc = new Scanner(System.in);
		
		System.out.println("���������ݣ�");
		str = sc.nextLine();
		
		//����ѭ������ �û����������е�  ��  ��
		for(i = 0 ; i < str.length() ; i++){
			
			if(str.indexOf("��", i) != -1){
				
				//���ҵ��� �ַ��±� ���¿�ʼ����
				//�� �ҵ����±� ��ֵ�� i
				i = str.indexOf("��", i) ;
				
				System.out.print(i + " ");
				count++;	//ͳ���ҵ����ٸ�
			}
			
		}
		
		System.out.println("\n���ƣ�" + count + " �� �� ��");
	}
}





