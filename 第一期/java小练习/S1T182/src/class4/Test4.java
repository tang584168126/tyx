package class4;

import java.util.Scanner;

/**
 * �������û������·ݣ���������·ݶ�Ӧ����
 * @author fun
 *
 */
public class Test4 {

	public static void main(String[] args) {
		
		int year = 0 , month = 0 , day = 0 ;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("��������ݣ�");
		year = sc.nextInt();
		
		System.out.println("�������·ݣ�");
		month = sc.nextInt();
		
		switch(month){
		case 1:
		case 3:
		case 5:
		case 7:
		case 8:
		case 10:
		case 12:
			day = 31 ;
			break;
		case 2:
			//��ƽ������
			
			//��� һ����� �ܹ��� 4 ������ͬʱ���ܱ�100����
			//���� �ܹ��� 400 ����
			//����������������ݼ�Ϊ������
			if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0){
				day = 29 ;
			}
			else{
				day = 28 ;
			}
			
			break;
		default:
			day = 30 ;
			break;
		}
		
		System.out.println(year + "��" + month + "���У�" + day + "��");
	}
	
}
