package class8;

import java.util.*;


/**
 * ���������� 5 λѧ���ĳɼ�������������
 * @author fun
 *
 */
public class Test4 {

	public static void main(String[] args) {

		int i = 0 ;
		double [] stuScores = new double[5];
		
		Scanner sc = new Scanner(System.in);
		
		for(i = 0 ; i < stuScores.length ; i++){
			
			System.out.println("��" + (i + 1) + "��ѧ���ɼ���");
			stuScores[i] = sc.nextDouble();
			
		}
		
		//��ʾ ֮ǰ���յ�5��ѧ���ĳɼ�
		
		System.out.println("\n======================================\n");
		
		System.out.println("ѧ���ɼ�Ϊ��");
		
		for(i = 0 ; i < stuScores.length ; i++){
			System.out.println(stuScores[i]);
		}
		
		
		System.out.println("\n======================================\n");
		
		//�������������(����)
		Arrays.sort(stuScores);
		
		System.out.println("�����ѧ���ɼ�����Ϊ��");
		
		for(i = 0 ; i < stuScores.length ; i++){
			System.out.println(stuScores[i]);
		}
		
		System.out.println("\n======================================\n");
		
		
		System.out.println("�����ѧ���ɼ�����Ϊ��");
		
		for(i = stuScores.length - 1 ; i >= 0  ; i--){
			System.out.println(stuScores[i]);
		}
	}
}










