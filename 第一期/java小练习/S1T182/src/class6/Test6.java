package class6;

import java.util.Scanner;

/**
 * 描述：输入 5个学生分数，统计 80分以上人数
 * 输出 80分以上人数占总人数的比例
 * @author fun
 *
 */

public class Test6 {

	public static void main(String[] args) {
		
		int i = 0 ;
		int score = 0 ;	//分数
		int count = 0 ;	//人数
		double bl = 0;	//80以上人数占比
		
		Scanner sc = new Scanner(System.in);
		
		for(i = 0 ; i < 5 ; i++){
			System.out.println("第" + (i + 1) + "个学生分数：");
			score = sc.nextInt();
			
			if(score < 80){
				continue;
			}
			
			count++;
		}
		
		bl = count / 5.0 * 100;
		
		System.out.println("80 以上人数为：" + count);
		System.out.println("80 以上人数占总人数比例为：" + bl + "%");
		
	}
}





