package class8;

import java.util.*;

public class Test6_2 {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int i = 0 ;
		int num = 0 ;	//接收用户输入的数据
		
		//声明一个 5 个元素 ， 带 初始值的数组
		int [] nums = {10,20,30,40,50};
		
		//声明一个数组，以 nums 数组元素个数 + 1 为元素个数
		int [] newNums = new int[nums.length + 1];
		
		
		//将 nums 的值 依次赋值给 newNums
		for(i = 0 ; i < nums.length ; i++){
			
			newNums[i] = nums[i] ;
			
		}
		
		//提示用户
		System.out.println("请输入一个整数:");
		num = sc.nextInt();
		
		//直接将 用户输入的数据放入最后一位
		newNums[newNums.length - 1] = num ;
		
		//排序
		Arrays.sort(newNums);
		
		for(i = 0 ; i < newNums.length ; i++){
			System.out.print(newNums[i] + "  ");
		}
		
	}
}




