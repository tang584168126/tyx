package work1;

import java.util.InputMismatchException;
import java.util.Scanner;

public class Test {
	public static void main(String[] args) {
		int num;		//��������
		
		Scanner sc = new Scanner(System.in);
		
		try{
			System.out.println("������γ̴���(1-3֮�������)��");
			num = sc.nextInt();
			
			switch (num) {
			case 1:
				System.out.println("C#���");
				break;
			case 2:
				System.out.println("Java���");
				break;
			case 3:
				System.out.println("SQL����");
				break;
			default:
				System.out.println("û���ҵ��ÿγ̣�");
				break;
			}
		}catch(InputMismatchException e){
			System.err.println("�������");
		}catch(Exception ex){
			System.err.println("����δ֪�쳣");
		}finally{
			System.out.println("��ӭ������飡");
		}
	}
}	
