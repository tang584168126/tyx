package Class4;

import java.util.Scanner;

public class Test1 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int day = 0;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("������������ڼ���");
		
		if(sc.hasNextInt() == true){
			day = sc.nextInt();
			if(day > 7){
				System.out.println("û������������");
			}
		
		switch(day){
		case 1:
		case 3:
		case 5:
			System.out.println("ѧϰ���");
			break;
		case 2:
		case 4:
		case 6:
			System.out.println("ѧϰӢ��");
			break;
		case 7:
			System.out.println("��Ϣ");
			break;
		}
		}else{
			System.out.println("û������ ����������");
		}
		System.out.println("�������");

	}

}
