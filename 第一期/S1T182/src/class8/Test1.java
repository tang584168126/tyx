package class8;

import java.util.Scanner;

public class Test1 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		//�������� a �� ���� 5��Ԫ�صĿռ�
		int [] a = new int[5];
		
		//Ϊ��һ������Ԫ�ظ�ֵ Ϊ 8
		//[0] ��ʾ ��һ������Ԫ�ص��±�
		//a[0] = 8 ;
		
		System.out.println("�����һ��Ԫ�ص�ֵΪ��" + a[0]);
		
		
		double [] stuScores = new double[30];
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("�������1��ѧ���ķ�����");
		stuScores[0] = sc.nextDouble();
		
		System.out.println("�������2��ѧ���ķ�����");
		stuScores[1] = sc.nextDouble();
		
		System.out.println("�������3��ѧ���ķ�����");
		stuScores[2] = sc.nextDouble();
		
		
		
		

	}

}
