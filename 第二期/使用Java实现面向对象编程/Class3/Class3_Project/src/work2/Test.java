package work2;

import java.util.Scanner;

/**
 * ������
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		
		Master master = new Master("С��",100);
		
		System.out.println("��ѡ����ˣ�ĳ��(1.���� 2.���)");
		int index = sc.nextInt();
		Pet pet = master.getPet(index);
		if(pet != null){
			System.out.println("ѡ�����ɹ���");
			master.play(pet);
		}else{
			System.out.println("û����ֻ���");
		}
	}
}
