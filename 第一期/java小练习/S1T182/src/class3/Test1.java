package class3;

import java.util.Scanner;

/**
 * ������Java�ɼ� ���� 98 �� �� ��� MP4 ����
 * 
 * @author fun
 *
 */
public class Test1 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		double score = 0 ;	//java ��������
		
		Scanner sc = new Scanner(System.in);

		System.out.println("������Java�γ̷�����");
		score = sc.nextDouble();
		
		//�ж� ���� �Ƿ� ���� 98
		if(score > 98){
			System.out.println("��� MP4 ����!");
			System.out.println("��� ��ʦ��ͷ ����!");
		}
		else{
			System.out.println("���˼����");
		}
		
		System.out.println("���������");
	}

}







