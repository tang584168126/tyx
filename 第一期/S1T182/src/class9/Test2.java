package class9;

import java.util.Scanner;

public class Test2 {

	public static void main(String[] args) {
		
		int i = 0 , j = 0 ; 
		double score = 0 ;
		double sum = 0 ;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("������ѧ���ɼ���");
		
		//���ѭ���˴������༶
		for(i = 0 ; i < 3 ; i++){
			System.out.println("��" + (i + 1) + "���༶��");
			
			//�ֹܷ���
			sum = 0 ;
			
			//�ڲ�ѭ���˴���ʾ��ÿ��� 4 ��ѧ��
			for(j = 0 ; j < 4 ; j++){
				System.out.println("��" + (j + 1) + "��ѧ���ɼ���");
				score = sc.nextDouble();
				
				sum += score ;
			}
			
			System.out.println("�ð�ѧ���ܷ֣�" + sum);
			System.out.println("�ð�ѧ��ƽ���֣�" + sum / j);
			
		}
		
	}
}





