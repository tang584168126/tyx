package class11;

import java.util.Scanner;

public class User {
	String name;
	String secret;
	int random;
	
	public void show(){
		Scanner sc = new Scanner(System.in);
		System.out.println("[���͸���ϵͳ > ע��]");
		System.out.println("����д����ע����Ϣ��");
		System.out.print("�û�����");
		name = sc.next();		
		System.out.print("���룺");
		secret = sc.next();
		random = (int)(Math.random() * 9000 + 1000);
		System.out.println("ע��ɹ������ס���Ļ�Ա����");	
		System.out.println("�û���\t����\t��Ա����");
		
		System.out.println( name + "\t" + secret + "\t" + random);
		
	}

}
