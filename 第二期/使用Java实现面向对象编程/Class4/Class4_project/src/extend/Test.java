package extend;

import java.util.Scanner;

/**
 * ������
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args){
		double digtA = 0;		//�����һ������
		double digtB = 0;
		int choice;			//ѡ��������
		
		Scanner sc = new Scanner(System.in);
		
		Counter counter = new Counter();
		
		System.out.print("���������֣�");
		digtA = sc.nextDouble();
		
		for(int i = 0; i <10000; i++){

			System.out.print("��ѡ��������(1.+  2.-  3.*  4./  5.=)��");
			choice = sc.nextInt();
			
			switch(choice){
				case 1:
					System.out.print("���������֣�");
					digtB = sc.nextDouble();
					counter.add(digtA, digtB);
					System.out.println("���Ϊ��" + counter.result);
					break;
				case 2:
					System.out.print("���������֣�");
					digtB = sc.nextDouble();
					counter.subtract(digtA, digtB);
					System.out.println("���Ϊ��" + counter.result);
					break;
				case 3:
					System.out.print("���������֣�");
					digtB = sc.nextDouble();
					counter.pursue(digtA, digtB);
					System.out.println("���Ϊ��" + counter.result);
					break;
				case 4:
					System.out.print("���������֣�");
					digtB = sc.nextDouble();
					counter.remove(digtA, digtB);
					System.out.println("���Ϊ��" + counter.result);
					break;
				case 5:
					counter.result = digtA;
					System.out.println("���Ϊ��" + counter.result);
					break;
				default:
					System.out.println("û�и�ѡ�������ѡ��");
					break;
			}
			
			System.out.print("���������֣�");
			digtA = sc.nextDouble();
		}
	}
}
