package class14;

import java.util.Scanner;

public class Test2 {
	
	public void getAvg(double[] stuScores){
		
		double avg = 0 ;
		
		avg = getSum(stuScores) / stuScores.length ;
		
		System.out.println("ƽ����Ϊ��" + avg);
	}
	
	public double getSum(double[] stuScores){
		
		double sum = 0 ;
		
		for(int i = 0 ; i < stuScores.length ; i++){
			
			sum += stuScores[i];
			
		}
		
		return sum ;
	}
	

	
	public static void main(String[] args) {
		
		double [] stuScores = new double[5];
		
		Scanner sc = new Scanner(System.in);
		
		for(int i = 0 ; i < stuScores.length ; i++){
			
			System.out.println("��" + (i + 1) + "��ѧ���ɼ���");
			stuScores[i] = sc.nextDouble();
		}
		
		
		Test2 t = new Test2();
		
		t.getAvg(stuScores);
		
		
		
	}
	
}
