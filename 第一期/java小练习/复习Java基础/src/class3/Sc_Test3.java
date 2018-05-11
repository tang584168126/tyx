package class3;

import java.util.Scanner;

public class Sc_Test3 {
	
	public static void main(String[] args){
		int a = 0 ;
		int b = 0 ;
		int c = 0 ; 
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("a:" );
		a = sc.nextInt();
		System.out.println("b:" );
		b = sc.nextInt();
		System.out.println("c:" );
		c = sc.nextInt();
		
		if(a > b && a > c){
			if(b > c){
				System.out.println(a + ">" + b + ">" + c);
			}else if(c > b){
				System.out.println(a + "> " + c + " >" + b);
			}
		}else if(b > a && b > c){
			if(a > c){
				System.out.println(b + "> "  + a + " >" + c);
			}else if(a < c){
				System.out.println( b + ">" + c + ">" + a);
			}
		}else if(c > a && c > b){
			if(a > b){
				System.out.println(c + "> "  + a + " >" + b);
			}else if(a < b){
				System.out.println( c + ">" + b + ">" + a);
			}
		}
		
	}

}
