package Class3;

import java.util.Scanner;

public class Test5 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		
		double scoer = 0;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("��������ɺɺ�ĳɼ���");
		scoer = sc.nextInt();
		
		//��ʱ����else if  �����Ƕ���if
		if(scoer == 100){
			System.out.println("���׸�����һ����");
		}else
		if(scoer >= 90){
			System.out.println("ĸ�׸�����һ���ʼǱ�����");
		}else
		if(scoer >= 60){
			System.out.println("ĸ�׸�����һ���ֻ�");
		}else{
		System.out.println("û�н���");
		}
		System.out.println("�������");
	}

}
