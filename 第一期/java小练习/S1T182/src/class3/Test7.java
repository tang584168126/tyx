package class3;

import java.util.Scanner;

public class Test7 {
	public static void main(String[] args) {
		
		//��������
		double score = 0 ;	//�����û�����İ��׳ɼ�
		String sex = "";	//�����û�������Ա�
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("�����������׳ɼ���");
		score = sc.nextDouble();
		
		//�ж��û��Ƿ�������
		if(score <= 10){
			
			//��� �û� �����˾�������ѯ���û����Ա�
			System.out.println("�����������Ա�(��/Ů)");
			sex = sc.next();
			
			//�ж��û��Ա𣬾����������
			if(sex.equals("��")){
				System.out.println("������������9:00 �μ������������");
			}
			else if(sex.equals("Ů")){
				System.out.println("������������2:00 �μ�Ů���������");
			}
			else{
				System.out.println("�Բ��𣬾ܾ�����������");
			}
			
		}
		else{
			System.out.println("���ź������ĳɼ������Խ��������");
			
			//��� �û� δ�����������ѯ���û����Ա�
			System.out.println("�����������Ա�(��/Ů)");
			sex = sc.next();

			//�ж��û��Ա𣬾����������
			if(sex.equals("��")){
				System.out.println("�������ղι۾�����");
			}
			else if(sex.equals("Ů")){
				System.out.println("�������ղμӾ��������ӣ�");
			}
			else{
				System.out.println("�Բ��𣬾ܾ�����������");
			}
		}
	}
}






