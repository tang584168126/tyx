package class8;

import java.util.Scanner;

public class Test1 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		//声明数组 a 并 开辟 5个元素的空间
		int [] a = new int[5];
		
		//为第一个数组元素赋值 为 8
		//[0] 表示 第一个数组元素的下标
		//a[0] = 8 ;
		
		System.out.println("数组第一个元素的值为：" + a[0]);
		
		
		double [] stuScores = new double[30];
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入第1个学生的分数：");
		stuScores[0] = sc.nextDouble();
		
		System.out.println("请输入第2个学生的分数：");
		stuScores[1] = sc.nextDouble();
		
		System.out.println("请输入第3个学生的分数：");
		stuScores[2] = sc.nextDouble();
		
		
		
		

	}

}
