package class7___������Ϸƽ̨;

import java.util.Scanner;

public class Sc_Text2 {
	public static void main(String[] args){
		int i = 0;
		int num = 0 ;				//���������
		int result = 1 ;			//�׳˵Ľ��
		
		Scanner sc = new Scanner(System.in);
		System.out.print("��������������");
		num = sc.nextInt();
		if(num < 1 && num > 10){
			System.out.println("��Ч����");
			System.exit(1);
		}
		System.out.print(num + "��=");
		for(i = 1 ; i < num ; i++){
			result *= (i + 1) ;
			System.out.print(i + "*");
		}
		System.out.println(num + "=" + result);
				
	}

}
