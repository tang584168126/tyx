package class3;

import java.util.Scanner;

/**
 * ������ʲô����³Է���
 * @author fun
 *
 */
public class Test2 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		//��������
		String answer = "";	//�Ƿ���˵Ļش�
		double money = 0 ;	//�Ƿ���Ǯ��֤��
		
		Scanner sc = new Scanner(System.in);
		
		//���ʣ�
		System.out.println("��������(Y/N)");
		answer = sc.next();
		
		
		//�ַ����ж�
		if(answer.equals("Y") || answer.equals("y")){
			
			System.out.println("���ж���Ǯ��(��������)");
			money = sc.nextDouble();
			
			//�жϽ���Ƿ��㹻�Է�
			if(money >= 10){
				System.out.println("�Ҹ�С���ӳԷ�/��/����");
			}
			else{
				System.out.println("��Ǯ���ֵܣ�����");
			}
			
		}
		else{
			System.out.println("�����Ͳ��ó��ˣ�����");
		}
		
		
		
		
		
		

	}

}
