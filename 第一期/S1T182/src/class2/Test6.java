package class2;

import java.util.*;

public class Test6 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// �ɿ���̨�������Ƶ����Ź��εĳɼ�����
		//���� java �� sql ֮��ķֲ�
		//���� ���Ź���ƽ����
		Scanner sc = new Scanner(System.in);
		int stbScore = 0 ;		//���������
		int javaScore = 0 ;		//Java�γ�
		int sqlScore = 0 ;		//SQL���ݿ�γ�
		int fc = 0 ;			//java �� sql �ķֲ�
		double avg = 0 ;		//���Ź���ƽ����
		
		//��������֮ǰ����������û���ʾ
		System.out.println("������ ��������� �ɼ���");
		stbScore = sc.nextInt();
		
		System.out.println("������ Java�γ� �ɼ���");
		javaScore = sc.nextInt();
		
		System.out.println("������ SQL���ݿ�γ� �ɼ���");
		sqlScore = sc.nextInt();
		
		//���� java �� sql ֮��ķֲ�
		fc = javaScore - sqlScore ;
		
		//���� ���Ź���ƽ����
		avg = (stbScore + javaScore + sqlScore) / 3.0 ;
		
		System.out.println("java �� sql ֮��ķֲ�Ϊ��" + fc);
		System.out.println("���Ź���ƽ����Ϊ��" + avg);
	}

}
