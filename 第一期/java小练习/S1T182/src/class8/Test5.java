package class8;

import java.util.Scanner;

/**
 * 描述：
 * @author fun
 *
 */
public class Test5 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int i = 0 ;
		int [] nums = new int[5] ;
		int max = 0 ;
		
		Scanner sc = new Scanner(System.in);
		
		for(i = 0 ; i < nums.length ; i++){
			//接收用户输入的数组元素
			System.out.println("请输入第" + (i + 1) + "个数：");
			nums[i] = sc.nextInt();
		}

		System.out.println("\n==============================\n");
		
		//找到最大值：
		//1、假设 数组中第一个元素最大
		max = nums[0] ;
		
		//2、用 max 与数组中所有元素依次比较
		for(i = 0 ; i < nums.length ; i++){
			
			//判断 如果 某个元素 大于 最大值
			if(max > nums[i]){
				//成立：将 数组中这个比 max 还要大的值 
				//赋值给 max
				max = nums[i] ;
			}
			
		}
		
		System.out.println("最大值为：" + max);
	}

}





