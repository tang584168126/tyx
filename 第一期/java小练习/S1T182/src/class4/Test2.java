package class4;

import java.util.Scanner;

public class Test2 {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		int mc = 0 ;
		
		System.out.println("������������Σ�");
		mc = sc.nextInt();
		
		switch(mc){
		case 1:
			System.out.println("��������ʡ����ѧ����Ӫһ���£�");
			break;
		case 2:
			System.out.println("������HP �ʼǱ�����һ̨��");
			break;
		case 3:
			System.out.println("�������ƶ�Ӳ��һ����");
			break;
		default:
			System.out.println("û�н���");
			break;
		}
		
		
		
	}
}
