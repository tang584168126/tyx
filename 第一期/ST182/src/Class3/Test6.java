package Class3;

import java.util.Scanner;

public class Test6 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		
		int month = 0;
		int num = 0;
		double discount = 0.0;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("��������е��·ݣ�1~12");
		month = sc.nextInt();
		System.out.println("������ѡ��ͷ�Ȳջ��Ǿ��òգ�ͷ�Ȳ�����1�����ò�����2");
		num = sc.nextInt();
		
		//if else��if if   Ҫע������
		if(month >=4 && month <=10){
			if(num == 1){
				discount = 0.9;
				System.out.println("��Ļ�Ʊ�۸�Ϊ��" + 5000*discount);
		}
			else if(num == 2){
				discount = 0.8;
				System.out.println("��Ļ�Ʊ�۸�Ϊ��" + 5000*discount);
			}
		}
		else if((month <4 || month >10 && month <=12) && num == 1){
			discount = 0.5;
			System.out.println("��Ļ�Ʊ�۸�Ϊ��" + 5000*discount);
		}
		else if((month <4 || month >10 && month <=12) && num == 2){
			discount = 0.4;
			System.out.println("��Ļ�Ʊ�۸�Ϊ��" + 5000*discount);
		}
		else if(month >12 ){
			System.out.println("û������·ݣ�����������");
		}
		
		
		System.out.println("�������");
	}

}
