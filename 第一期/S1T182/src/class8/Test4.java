package class8;

import java.util.*;


/**
 * 描述：接收 5 位学生的成绩，并排序后输出
 * @author fun
 *
 */
public class Test4 {

	public static void main(String[] args) {

		int i = 0 ;
		double [] stuScores = new double[5];
		
		Scanner sc = new Scanner(System.in);
		
		for(i = 0 ; i < stuScores.length ; i++){
			
			System.out.println("第" + (i + 1) + "个学生成绩：");
			stuScores[i] = sc.nextDouble();
			
		}
		
		//显示 之前接收的5个学生的成绩
		
		System.out.println("\n======================================\n");
		
		System.out.println("学生成绩为：");
		
		for(i = 0 ; i < stuScores.length ; i++){
			System.out.println(stuScores[i]);
		}
		
		
		System.out.println("\n======================================\n");
		
		//对数组进行排序(升序)
		Arrays.sort(stuScores);
		
		System.out.println("排序后学生成绩升序为：");
		
		for(i = 0 ; i < stuScores.length ; i++){
			System.out.println(stuScores[i]);
		}
		
		System.out.println("\n======================================\n");
		
		
		System.out.println("排序后学生成绩降序为：");
		
		for(i = stuScores.length - 1 ; i >= 0  ; i--){
			System.out.println(stuScores[i]);
		}
	}
}










