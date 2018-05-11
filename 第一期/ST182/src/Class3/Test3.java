package Class3;

import java.util.Scanner;

public class Test3 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int a,b,c,d = 0;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请示如第一个数：");
		a = sc.nextInt();
		System.out.println("请示如第二个数：");
		b = sc.nextInt();
		System.out.println("请示如第三个数：");
		c = sc.nextInt();
		
		
		/*
		if(a > b ){
			a = a + b;
			b = a - b;
			a = a - b;
		}
		if(a > c){
			a = a + c;
			c = a - c;
			a = a - c;
		}
		if(b > c){
			b = b + c;
			System.out.println("判断是否进入第三个IF b = " + b);
			c = b - c;
			b = b - c;
		}
		System.out.println("a=" + a + "\tb=" + b + "\tc=" + c);
		*/
		
		
		
		if(a > b){
			d = a;
			a = b;
			b = d;
		}
		if(a > c){
			d = a;
			a = c;
			c = d;
		}
		if(b > c){
			d = b;
			b = c;
			c = d;		
		}
		
		System.out.println("a=" + a + "b=" + b + "c=" + c);
		

	}

}
