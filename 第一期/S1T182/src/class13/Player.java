package class13;

import java.util.Scanner;

public class Player {
	
	String name ;	//����
	int result ;	//����
	
	public int ��ȭ(){
		
		int num = 0 ;
		
		Scanner sc = new Scanner(System.in);
		
		do{
		
			num = sc.nextInt();	//������ҳ�ȭ
			
			switch(num){
			case 1:
				System.out.println("��ҳ�ȭ��ʯͷ");
				break;
			case 2:
				System.out.println("��ҳ�ȭ������");
				break;
			case 3:
				System.out.println("��ҳ�ȭ�� ��");
				break;
			default:
				System.out.println("��ȭ���������³�ȭ��");
				continue;
			}
			
			//����û���ȭ��ȷ����������ȭ����
			break;
			
		}while(true);
		
		//��ȭ��ȷ�Ժ󣬷�����ҳ�ȭ�Ľ������ ����
		return num ;
	}
}
