package class4;

import java.util.Scanner;

public class Test1 {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		int mc = 0 ;
		
		System.out.println("������������Σ�");
		mc = sc.nextInt();
		
		if(mc == 1){
			System.out.println("��������ʡ����ѧ����Ӫһ���£�");
		}
		else if(mc == 2){
			System.out.println("������HP �ʼǱ�����һ̨��");
		}
		else if(mc == 3){
			System.out.println("�������ƶ�Ӳ��һ����");
		}
		else{
			System.out.println("û�н���");
		}
	}
}
