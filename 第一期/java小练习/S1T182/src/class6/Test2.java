package class6;

import java.util.Scanner;

public class Test2 {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int i = 0 ;
		String name = "";
		double score = 0 ;
		int num = 0 ;		//��Ŀ����
		double sum = 0 , avg = 0 ;
		
		System.out.println("������ѧ��������");
		name = sc.next();
		
		System.out.println("������ѧ����Ŀ������");
		num = sc.nextInt();
		
		for(i = 0 ; i < num ; i++){
			
			System.out.print("�� " + (i + 1) + " �Ź��γɼ���");
			score = sc.nextDouble();
			
			//ÿ����һ���û��ķ������ͽ��÷��������ܷ�
			sum += score ;
			
		}
		
		//����ƽ����
		avg = sum / num ;
		
		System.out.println(name + "��ƽ����Ϊ��" + avg);
	}
}
