package class2;

import java.util.Scanner;

public class Sc_Boolean {
	public static void main(String[] args){
		double zhang = 0 ; 
		double li = 80 ; 
		boolean isok ;
		
		Scanner sc = new Scanner(System.in);
		System.out.println("�����ĳɼ���");
		li = sc.nextDouble();
		isok = zhang > li ; 
		System.out.println("�����ĳɼ������ĸ���" + isok);
	}
}
