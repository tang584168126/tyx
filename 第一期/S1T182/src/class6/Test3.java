package class6;

import java.util.Scanner;

public class Test3 {

	public static void main(String[] args) {
		
		int num = 0 ;	//�����û����������
		Scanner sc = new Scanner(System.in);
		int i = 0 , j = 0 ;
		
		System.out.println("������һ��������");
		num = sc.nextInt();
		
		System.out.println("�������ֵ������ʾ���¼ӷ���");
		
		for(i = 0 , j = num ; i <= num ; i++ , j--){
			
			System.out.println(i + " + " + j + " = " + num);
			
		}
		
	}
}





