package class4;

import java.util.Scanner;

public class Test3 {

	public static void main(String[] args) {
		
		int num = 0 ;	//�û����Ž��
		Scanner sc = new Scanner(System.in);
		
		System.out.println("1����");
		System.out.println("2����");
		System.out.println("3��ү");
		System.out.println("4����");
		System.out.println("ѡ�񲦺Ű�����");
		
		if(!sc.hasNextInt()){
			System.out.println("��������ǿպţ�");
			System.exit(1);
		}
		
		num = sc.nextInt();
		
		switch(num){
		case 1:
			System.out.println("���ڲ��򣺰ְֵĵ绰......");
			break;
		case 2:
			System.out.println("���ڲ�������ĵ绰......");
			break;
		case 3:
			System.out.println("���ڲ���үү�ĵ绰......");
			break;
		case 4:
			System.out.println("���ڲ������̵ĵ绰......");
			break;
		default:
			System.out.println("�����øð�������");
			break;
		}
		
	}
	
}
