package class12;

import java.util.Scanner;

public class Ren {

	String name ;		//����
	int result;			//����
	int num = 0;
	
	public int giveResult(){
		Scanner sc = new Scanner(System.in);
	
	
		do{
			
			System.out.println("���ȭ��(1.ʯͷ  2.����  3.��)");
			num = sc.nextInt();
			switch(num){
			case 1:
				System.out.println("�˳�ʯͷ");
				break;
			case 2:
				System.out.println("�˳�����");
				break;
			case 3:
				System.out.println("�˳���");
				break;
				default:
					System.out.println("����������������룡");
					continue;
			}
			break;
		}while(true);
		return num;
	}
	
}
