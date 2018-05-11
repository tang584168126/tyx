package class6;

import java.util.Scanner;

/**
 * 我们比赛吃包子：
	看谁吃的多
	1、每人每轮吃1个
	2、N轮后有人扛不住了
	问如何解决
 * @author fun
 *
 */
public class Test5 {

	public static void main(String[] args) {
		
		int count = 0 ;
		String answer = "";
		
		Scanner sc = new Scanner(System.in);
		
		for(count = 1 ; count <= 50 ; count++){
			
			System.out.println("吃了" + count + "个");
			
			System.out.println("还吃得下否？（Y/N）");
			answer = sc.next();
			
			if(answer.equalsIgnoreCase("n")){
				break;	//强制跳出循环，结束比赛
			}
			
		}
		
		System.out.println("该人结束比赛，他吃了" + count + "个包子！");
	}
	
}



