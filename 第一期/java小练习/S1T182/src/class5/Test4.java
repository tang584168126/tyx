package class5;

import java.util.Scanner;

public class Test4 {

	public static void main(String[] args) {
		
		String answer = "";
		Scanner sc = new Scanner(System.in);
		
		System.out.println("�����źƵ�ѧϰ�����Ƿ�ϸ�(Y/N)");
		answer = sc.next();
		
		while(!answer.equalsIgnoreCase("y")){
			System.out.println("�����Ķ��̲ģ������ϻ�������");
			
			System.out.println("�����źƵ�ѧϰ�����Ƿ�ϸ�(Y/N)");
			answer = sc.next();
		}
		
		System.out.println("���������");
		
	}
	
}
