package class12.homework;

import java.util.Scanner;

/**
 * ����������·ݣ��жϼ���
 * ʹ�÷��������ĸ�����
 * @author fun
 *
 */
public class P244_1 {

	int month ;	//�·�
	
	/**
	 * һ�������ж��ļ�
	 */
	public void �ļ�(){
		
		switch(month){
		case 3:
		case 4:
		case 5:
			System.out.println("����");
			break;
		case 6:
		case 7:
		case 8:
			System.out.println("�ļ�");
			break;
		case 9:
		case 10:
		case 11:
			System.out.println("�＾");
			break;
		case 12:
		case 1:
		case 2:
			System.out.println("����");
			break;
		default:
			System.out.println("��������ȷ���·ݣ�����");
			break;
		}
		
		
	}
	
	
	/**
	 * ���Լ���
	 * @param args
	 */
	public static void main(String[] args) {
		
		P244_1 p = new P244_1();
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("�������·ݣ�");
		p.month = sc.nextInt();
		
		p.�ļ�();
		

	}

}
