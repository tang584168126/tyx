package class2;

import java.util.*;

public class Test2 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		//��Ҫ���� �ɼ����������Ա�
		double score = 0 ;
		String name = "" ;
		//String sex = "";
		char sex = ' ';
		
		//������׼��������һ��ɨ��������
		Scanner sc = new Scanner(System.in);
		
		System.out.println("������Java�γ̷�����");
		score = sc.nextDouble();
		
		System.out.println("������ѧ��������");
		name = sc.next();
		
		System.out.println("������ѧ���Ա�");
		sex = sc.next().charAt(0);
		
		System.out.println("Java����Ϊ��" + score);
		System.out.println("ѧ������Ϊ��" + name);
		System.out.println("ѧ���Ա�Ϊ��" + sex);
		
	}

}

