package class15;

import java.util.Scanner;

public class RegisterTest {
	public static void main(String[] args){
		String name = "";
		String pwd = "";
		String delpwd = "";
		
		Register register = new Register();
		Scanner sc = new Scanner(System.in);
		do{
			System.out.println("�������û�����");
			name = sc.next();
			System.out.println("���������룺");
			pwd = sc.next();
			System.out.println("���ٴ��������룺");
			delpwd = sc.next();
			register.verify(name , pwd , delpwd);
		}while(register.isok == false);
		System.out.println("ע��ɹ������μ��û��������롣");
	}

}
