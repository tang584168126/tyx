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
			System.out.print("请输入周" + (i+1) + "的学习时间");
			time = sc.nextInt();
			sum = sum + time;
		}
		
		avg = sum/5;
		System.out.println("周一至周五的学习时间是："+avg);

	}

}
