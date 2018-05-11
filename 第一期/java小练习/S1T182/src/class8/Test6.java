package class8;

import java.util.*;

/**
 * 插入算法
 * @author fun
 *
 */
public class Test6 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int i = 0 ;
		int num = 0 ;		//接收用户输入的整数
		int index = -1 ;	//index表示的是查出来的 下标，如果为0 ， 有可能被误认为是 第一个元素
		
		Scanner sc = new Scanner(System.in);
		
		//声明一个 5 个元素 ， 带 初始值的数组
		int [] nums = {10,20,30,40,50};
		
		//声明一个数组，以 nums 数组元素个数 + 1 为元素个数
		int [] newNums = new int[nums.length + 1];
		

		//将 nums 的值 依次赋值给 newNums
		for(i = 0 ; i < nums.length ; i++){
			
			newNums[i] = nums[i] ;
			
		}
		
		//打印原始数据
		for(i = 0 ; i < nums.length ; i++){
			
			System.out.print(nums[i] + "  ");
			
		}
		
		//由用户输入一个整数，放入 newNums 中，要求实现有序
		System.out.println("请输入一个整数：");
		num = sc.nextInt();
		
		//找到 newNums 中 比 用户输入值 大的那个数的下标
		for(i = 0 ; i < newNums.length ; i++){

			//判断 哪个数组元素 比 用户输入的值要大
			if(newNums[i] > num){
				//将 用户输入的数要放入的下标记录下来
				index = i ;
				break;	//找到了要放入的位置后，跳出查找
			}
			
		}
		
		//如果 用户输入的值最大，则 index 无法额外获取下标，
		//此时 index 将为： -1
		if(index == -1){
			newNums[newNums.length - 1] = num ;
		}
		else{
			//将 要放入用户输入的数据的下标之后的所有值
			//向后移动一位
			for(i = newNums.length - 1; i > index; i--){
				
				//将 下标 i - 1 的值 赋值给 下标 i 的元素
				newNums[i] = newNums[i - 1] ;
				
			}
			
			//最后一步，将用户输入的值 放入 应该放入的位置
			newNums[index] = num ;
		}
		
		//打印结果
		for(i = 0 ; i < newNums.length ; i++){
			
			System.out.print(newNums[i] + "  ");
			
		}
	}

}



