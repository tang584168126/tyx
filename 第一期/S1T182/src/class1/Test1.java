package class1;

import java.util.*;

public class Test1 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);

		int i = 0 ;
		String id = "" ;		//�û���
		String pwd = "";		//����
		
		System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * *");
		System.out.println("*                                               *");
		System.out.println("*                                               *");
		System.out.println("*                 �������ع������ϵͳ             *");
		System.out.println("*                                               *");
		System.out.println("*                                               *");
		System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * *");
		
		System.out.println("\t\t1��ϵͳ��¼");
		System.out.println("\t\t2���˳�");
		
		System.out.println("������ѡ�");
		i = sc.nextInt();
		
		switch(i){
		case 1:
			System.out.println("�������û�����");
			id = sc.next();
			
			System.out.println("���������룺");
			pwd = sc.next();
			
			if(id.equals("admin") && pwd.equals("admin")){
				System.out.println();
				System.out.println("            ��ӭ���� �������ع������ϵͳ           ");
				System.out.println();
				System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * *");
				System.out.println("*                                               *");
				System.out.println("*                1���ͻ���Ϣ����                  *");
				System.out.println("*                                               *");
				System.out.println("*                                               *");
				System.out.println("*                                               *");
				System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * *");
				
			}
			
			break;
		case 2:
			//�˳�ϵͳ֮ǰ�����л
			System.out.println("��ӭ�´μ���ʹ�ñ�ϵͳ");
			
			//�˳�ϵͳ
			System.exit(1);
			break;
		}
	}

}
