package class11;

import java.util.Scanner;

public class Hero {
	String name ;
	String hp ;
	public void show(){
		Scanner sc = new Scanner(System.in);
		System.out.println("����Ӣ�ۣ��ҵĻ�����Ϣ���£�");
		System.out.print("������");
		name =  sc.next();
		System.out.print("����ֵ����");
		hp = sc.next();
		
	}

}
