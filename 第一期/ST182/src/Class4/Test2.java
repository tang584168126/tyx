package Class4;

import java.util.Scanner;

public class Test2 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//��swilch1ѡ��̫��ʱ���Կ��� �ñ���/10
		int score = 0;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("�������������");
		
		if(sc.hasNextInt()){
			score = sc.nextInt();
		
		switch(score/10){
		case 10:
			System.out.println("���׸�����һ����");
			break;
		case 9:
			System.out.println("ĸ�׸�����һ���ʼǱ�����");
			break;
		case 8:
		case 7:
		case 6:
			System.out.println("ĸ�׸���ÿһ���ֻ�");
			break;
			default:
				System.out.println("û�н���");
				break;
		}		
		}else{
			System.out.println("����������");
		}

		System.out.println("�������");

	}

}
