package Class3;

import java.util.Scanner;

public class Test3 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int a,b,c,d = 0;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("��ʾ���һ������");
		a = sc.nextInt();
		System.out.println("��ʾ��ڶ�������");
		b = sc.nextInt();
		System.out.println("��ʾ�����������");
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
			System.out.println("�ж��Ƿ���������IF b = " + b);
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
