package class14;

import java.util.Scanner;

public class ShiLie4_Test {
	public static void main(String[] args){
		ShiLie4 student = new ShiLie4();
		Scanner sc = new Scanner(System.in);
		double[] scores = new double[5];
		int i = 0;
		
		for(i = 0 ; i < scores.length ; i++){
			System.out.print("������" + (i + 1) + "λѧԱ�ĳɼ���");
			scores[i] = sc.nextDouble();
		}
		System.out.println("ƽ���ɼ�Ϊ��" + student.getavg(scores));
		
		System.out.println("��߷�Ϊ��" + student.getmax(scores));
	}

}
