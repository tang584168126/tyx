package class14;

import java.util.Scanner;

public class Test2 {
	
	public void getAvg(double[] stuScores){
		
		double avg = 0 ;
		
		avg = getSum(stuScores) / stuScores.length ;
		
		System.out.println("平均分为：" + avg);
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
			
			System.out.println("第" + (i + 1) + "个学生成绩：");
			stuScores[i] = sc.nextDouble();
		}
		
		
		Test2 t = new Test2();
		
		t.getAvg(stuScores);
		
		
		
	}
	
}
