package class12;

import java.util.Scanner;

public class ScoreSalceTest {

	
	public static void main(String[] args) {
		
		double[] scores = new double[3];
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("�����������");
		
		for(int i = 0 ; i < scores.length ; i++){
			System.out.println("�������" + (i + 1) + "�Ź��η�����");
			scores[i] = sc.nextDouble();
		}
		
		//���� �ɼ�������Ķ���
		ScoreCalc ss = new ScoreCalc();
		
		//���û�����ĳɼ���ֵ�� �ɼ�������
		ss.scores = scores;
		
		//�����ܷ�
		ss.getSum();
		
		//����ƽ����
		ss.getAvg();
		
		//��ʾ�ܷ�
		ss.showSum();
		
		//��ʾƽ����
		ss.showAvg();
	}
	
}
