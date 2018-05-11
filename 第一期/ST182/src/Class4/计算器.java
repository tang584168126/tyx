package Class4;

import java.util.Scanner;

public class 计算器 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		double a,b = 0.0;
		char c = '0';
		
		Scanner sc = new Scanner(System.in);
		do{
		do{
		System.out.println("请输入一个合理的算式");
		
		if(!sc.hasNextInt()){
			sc = new Scanner(System.in);
		}else{
			break;
			}
		
		
		}while(true);
		a = sc.nextDouble();
		
		
		
		c = sc.next().charAt(0);
		
		
		
		
		do{
			
			
			if(!sc.hasNextInt()){
				sc = new Scanner(System.in);
			}else{
				break;
				}
			
			
			}while(true);
			b = sc.nextDouble();
		
		switch(c){
		case '+':
			System.out.println(a + "+" + b + "=" + (a + b));
			break;
		case '-':
			System.out.println(a + "-" + b + "=" + (a - b));
			break;
		case '*':
			System.out.println(a + "*" + b + "=" + (a * b));
			break;
		case '/':
			System.out.println(a + "/" + b + "=" + (a / b));
			break;
		case '%':
			System.out.println(a + "%" + b + "=" + (a % b));
			break;
		}
		}while(true);
		
		
			

	}

	}
