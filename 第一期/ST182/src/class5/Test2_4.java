package class5;

import java.util.Scanner;

public class Test2_4 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		
		int t = 0;
		
		
		Scanner sc = new Scanner(System.in);
		System.out.print("请输入一个整数：\n");
		 t = sc.nextInt();
		 int max = t;
		 int min = t;
		
		do{
			
		 if(max < t){
			
			 max = max + t;
			 t = max - t;
			 max = max - t;
			 System.out.println("这是MAX:" + t);
		 }else
		 if(min > t && t!=0){
			 
			 min = min + t;
			 t = min - t;
			 min = min - t;
			 System.out.println("这是MIN:" + t);
		 }
		 System.out.print("请输入一个整数：\n");
		 t = sc.nextInt();
		 
		}while(t != 0);
		System.out.println("最大值：" + max + "最小值" + min);

	}

}
