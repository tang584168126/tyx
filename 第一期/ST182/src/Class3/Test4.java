package Class3;

import java.util.Scanner;

public class Test4 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		
		int num = 0;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("请输入数字：");
		num = sc.nextInt();
		
		
		//任意数对整型 3 取膜 等于0的话那么改数是3的倍数
		if(num % 3 == 0 || num %5 == 0){
			System.out.println("该数是3 或者5的倍数");
		}
		else{
			System.out.println("不是3或者5的倍数");
		}
		
		
		System.out.println("程序结束");

	}

}
