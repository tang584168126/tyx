package class3;

import java.util.Scanner;

public class Test3 {

	public static void main(String[] args) {
		
		//��������
		String �н� = "";
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("�Ƿ��н�����(Y/N)");
		�н� = sc.next();
		
		if(�н�.equalsIgnoreCase("y")){
			System.out.println("�򳵡��򷿡���ϣ������");
		}
		else{
			System.out.println("���������Ʊ���������㣡��");
		}
			
		
		
		
	}
}
