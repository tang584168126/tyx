package Class8;

import java.util.Scanner;

public class Test2_2 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		int a = 0;
		String[] b = new String[5];
		
		System.out.println("������5�仰");
		for(a = 0;a<b.length;a++){
			System.out.print("��" + (a+1) + "�仰");
			b[a] = sc.next();
			
		}
		System.out.println("��������������������������������������������������������������������������������������������������������");
		for(a = 0;a<b.length;a++){
			System.out.print(b[a]);
		}
		
		System.out.println("");
		System.out.println("�����ӡ��5�仰Ϊ��");
		System.out.println("��������������������������������������������������������������������������������������������������������");
		for(a = b.length-1;a>=0;a--){
			System.out.print(b[a]);
		}

	}

}
