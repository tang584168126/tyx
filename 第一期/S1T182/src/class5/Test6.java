package class5;

import java.util.Scanner;

public class Test6 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int num = 0 ;
		
		Scanner sc = new Scanner(System.in);
		do{
			System.out.println("1����¼");
			System.out.println("2���˳�");
			System.out.println("��ѡ��");
			
			if(!sc.hasNextInt()){
				System.out.println("����������������룡");
				sc = new Scanner(System.in);
				
			}
			else{
				break;
			}
		}while(true);
		
		num = sc.nextInt();
		
		switch(num){
		case 1:
			System.out.println("1���ͻ�����");
			System.out.println("2���˳�");
			System.out.println("��ѡ��");
			break;
		case 2:
			System.out.println("��ӭ�´�ʹ�ã�");
			System.exit(1);
			break;
		}
		

	}

}
