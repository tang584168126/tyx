package class6;

import java.util.Scanner;

/**
 * ���������� 5��ѧ��������ͳ�� 80����������
 * ��� 80����������ռ�������ı���
 * @author fun
 *
 */

public class Test6 {

	public static void main(String[] args) {
		
		int i = 0 ;
		int score = 0 ;	//����
		int count = 0 ;	//����
		double bl = 0;	//80��������ռ��
		
		Scanner sc = new Scanner(System.in);
		
		for(i = 0 ; i < 5 ; i++){
			System.out.println("��" + (i + 1) + "��ѧ��������");
			score = sc.nextInt();
			
			if(score < 80){
				continue;
			}
			
			count++;
		}
		
		bl = count / 5.0 * 100;
		
		System.out.println("80 ��������Ϊ��" + count);
		System.out.println("80 ��������ռ����������Ϊ��" + bl + "%");
		
	}
}





