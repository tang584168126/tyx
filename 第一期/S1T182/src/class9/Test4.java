package class9;

import java.util.Scanner;

public class Test4 {

	public static void main(String[] args) {
		
		int a = 5 , b = 10 , c = 0;
		boolean isMan = true ;
		
//		if(a >= 5){
//			c = 10 ;
//		}
//		else{
//			c = 20 ;
//		}
		
		//三元运算符 
		// 条件 ? 真的结果 : 假的结果 ;
		//c = a >= 5 ? 100 : 200 ;
		
		
//		if(a > 5){
//			c = 10 ;
//		}
//		else{
//			if(b > 5){
//				c = 20 ;
//			}
//			else{
//				c = 30 ;
//			}
//		}
		
		//三元运算符 
		// 条件 ? 真的结果 : 假的结果 ;
		c = a > 5 ? 100 : b > 5 ? 200 : 300 ;
		
		
		if(a >= 5){
			if(b <= 10){
				c = 10 ;
			}
			else{
				c = 15 ;
			}
		}
		else{
			if(b > 5){
				c = 20 ;
			}
			else{
				c = 30 ;
			}
		}
	
		//三元运算符 
		// 条件 ? 真的结果 : 假的结果 ;
		c = a > 5 ? b <= 10 ? 10 : 15 : b > 5 ? 200 : 300 ;
	
		System.out.println("C = " + c);
		
		System.out.println(c > 10 ? "真的" : "假的");
		
		
		
		isMan = false;
		
		System.out.println( isMan ? "男" : "女");
		
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("碟片是否已出租？");
		
		String answer = sc .next();
		
		System.out.println( answer.equals("y") ? "已出租" : "" );
	}
}
