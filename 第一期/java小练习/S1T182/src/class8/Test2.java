package class8;

import java.util.Scanner;

public class Test2 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int i = 0 ;
		String[] stuNames = new String[3];
		double [] stuScores = new double[3];
		
		Scanner sc = new Scanner(System.in);
		
		
		//System.out.println("������ѧ��������������");
		
		for(i = 0 ; i < stuNames.length ; i++){
			
			System.out.println("�������" + (i + 1) + "��ѧԱ������");
			stuNames[i] = sc.next();
			
			System.out.println("�������" + (i + 1) + "��ѧԱ�ɼ���");
			stuScores[i] = sc.nextDouble(); 
		}
		
		System.out.println("\n==========================\n");
		
		
		System.out.println("ѧ������Ϊ��");
		for(i = 0 ; i < stuNames.length ; i++){
			
			System.out.println(i + 1 + ":" + stuNames[i] + " \t " + stuScores[i]);
			
		}
	}

}
