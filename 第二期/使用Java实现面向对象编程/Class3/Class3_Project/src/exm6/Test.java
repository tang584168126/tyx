package exm6;

import java.util.Scanner;

/**
 * ������
 * @author Administrator
 *
 */
public class Test {

	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		Person person = new Person("ţ��");
		int index;
		
		System.out.println("(1.�й�����2.��������)���ݷã�");
		index = sc.nextInt();
		Friend friend = person.getFriend(index);
		if(friend != null){
			System.out.println("�������ˣ�");
			friend.print();
		}else{
			System.out.println("(1.�й�����2.��������)���ݷã�");
		}
	}
}
