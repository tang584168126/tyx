package class11;

import java.util.Scanner;

public class Monster {

	String name ;
	String hp ;
	String type;
	public void show(){
		Scanner sc = new Scanner(System.in);
		System.out.println("���ǹ���ҵĻ�����Ϣ���£�");
		System.out.print("������");
		name =  sc.next();
		System.out.print("����ֵ����");
		hp = sc.next();
		System.out.print("���ͣ���");
		type = sc.next();
		
	}
}
