package class14;

import java.util.Scanner;

public class ScoreCale {

	String[] gongKe = new String[3];
	double score = 0;
	double sum = 0;
	double avg = 0;
	int i = 0;
	
	
	public void getScore(){
		Scanner sc = new Scanner(System.in);
		for(i = 0 ; i < gongKe.length ; i++){
			System.out.println("�����빦�Σ�" );
			gongKe[i] = sc.next();
			System.out.print("������ɼ���");
			score = sc.nextInt();
			sum += score;
		}
		avg = sum / gongKe.length;
	}
}
