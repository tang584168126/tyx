package class6;

import java.util.Scanner;

/**
 * ���Ǳ����԰��ӣ�
	��˭�ԵĶ�
	1��ÿ��ÿ�ֳ�1��
	2��N�ֺ����˿���ס��
	����ν��
 * @author fun
 *
 */
public class Test5 {

	public static void main(String[] args) {
		
		int count = 0 ;
		String answer = "";
		
		Scanner sc = new Scanner(System.in);
		
		for(count = 1 ; count <= 50 ; count++){
			
			System.out.println("����" + count + "��");
			
			System.out.println("���Ե��·񣿣�Y/N��");
			answer = sc.next();
			
			if(answer.equalsIgnoreCase("n")){
				break;	//ǿ������ѭ������������
			}
			
		}
		
		System.out.println("���˽���������������" + count + "�����ӣ�");
	}
	
}



