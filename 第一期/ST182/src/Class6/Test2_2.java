package Class6;

import java.util.Scanner;

public class Test2_2 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int time = 0;
		double sum =0;
		double avg = 0;
		
		Scanner sc = new Scanner(System.in);
		
		for(int i = 0;i<5;i++){
			System.out.print("��������" + (i+1) + "��ѧϰʱ��");
			time = sc.nextInt();
			sum = sum + time;
		}
		
		avg = sum/5;
		System.out.println("��һ�������ѧϰʱ���ǣ�"+avg);

	}

}
