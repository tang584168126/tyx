package class1;

import java.util.Scanner;

public class SMS {
	
	Scanner sc = new Scanner(System.in);
	int i = 0 ;
	String id , pwd ;
	
	public void menu(){
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
	}
	
	public void menuClien(){
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
		System.out.println("������ѡ�");
	}
	
	public void start(){
		do{
			menu();
			i = sc.nextInt();
			
			switch(i){
			case 1:
				System.out.println("�������û�����");
				id = sc.next();
				
				System.out.println("���������룺");
				pwd = sc.next();
				
				if(id.equals("admin") && pwd.equals("admin")){
					menuClien();
				}
			break;
			case 2:
				System.out.println("��ӭ�´μ���ʹ�ñ�ϵͳ");
				System.exit(1);
				break;
			}
		}while(true);
	}
	
	public static void main(String[] args) {
		
		SMS sms = new SMS();
		
		sms.start();
		
	}
}
