package Class3;

import java.util.Scanner;

public class Test4 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		
		int num = 0;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("���������֣�");
		num = sc.nextInt();
		
		
		//������������ 3 ȡĤ ����0�Ļ���ô������3�ı���
		if(num % 3 == 0 || num %5 == 0){
			System.out.println("������3 ����5�ı���");
		}
		else{
			System.out.println("����3����5�ı���");
		}
		
		
		System.out.println("�������");

	}

}
