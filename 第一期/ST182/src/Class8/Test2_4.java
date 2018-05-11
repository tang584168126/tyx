package Class8;

import java.util.Scanner;

public class Test2_4 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int [] nums = new int[10];//储存用户输入的10个值
		int [] count = new int[4];//储存相应数字的”个数“
		int a = 0;

		
		System.out.println("请输入"+ nums.length + "个数");
		for(a = 0; a < nums.length;a++){
			System.out.println("请输入第" + (a+1) + "个数");
			nums[a] = sc.nextInt();
			switch(nums[a]){
			case 1:
				count[0] +=1;
				break;
			case 2:
				count[1] +=1;
				break;
			case 3:
				count[2] +=1;
				break;
			default:
				count[3] +=1;
				break;
			}
		}
		System.out.println("数字1个数：" + count[0]);
		System.out.println("数字2个数"+count[1]);
		System.out.println("数字3个数"+count[2]);
		System.out.println("非法的个数"+count[3]);
		

	}

}
