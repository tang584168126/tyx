package Class3;

import java.util.Scanner;

public class Test1 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		
		int password = 0;
		String name = "";
		
		
		Scanner sc = new Scanner(System.in);
		
		
		System.out.println("�������û���");
		name = sc.next();
		System.out.println("����������");
		password = sc.nextInt();

		if(name.equals("��") && password == 123){
			System.out.println("��ӭ�㣬��");
					
		}else{
			
			System.out.println("�Բ����㲻����");
		}
		System.out.println("�������");

	}
}
