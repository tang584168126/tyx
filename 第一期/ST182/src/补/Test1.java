package ��;

import java.util.Scanner;

public class Test1 {
	public static void main(String[] args){
		String name = "";
		double score = 0 ;
		Scanner sc = new Scanner(System.in);
		do{
			System.out.println("������������");
			name = sc.next();
			System.out.println("������ɼ���");
			score = sc.nextDouble();
			if(score >= 90){
				System.out.println("A");
			}else if(score >= 60 ){
				System.out.println("B");
			}else{
				System.out.println("C");
			}
		}while(true);
		
	}

}
