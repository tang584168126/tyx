package class9;

import java.util.Scanner;

public class Test4 {
	public static void main(String[] args){
		int i = 0 ; 			//�༶
		int j = 0 ;				//	����ѧԱ	
		double score = 0 ;
		double avg = 0	;
		double sum = 0	;
		int index = 0 ;			//������
		Scanner sc = new Scanner(System.in);
		
		for(i = 0 ; i < 3; i++){
			System.out.println("��" + (i + 1) + "���ࣺ");
			for(j = 0 ; j < 4 ; j++){
				System.out.print("��" + (j + 1) + "��ѧԱ�ĳɼ���");
				score = sc.nextInt();
				if(score > 85){
					sum += score ; 
					index++;
				}
			}
		}
		avg = sum / index ;
		System.out.println("���в���ѧԱ�ɼ�����85�ֵ�ƽ����Ϊ��" + avg);
	}

}
