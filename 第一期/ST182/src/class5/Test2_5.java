package class5;

import java.util.Scanner;

public class Test2_5 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int num = 0;
		String day = "";
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("������С��7������");
		num = sc.nextInt();
		
		do{
			while(num>7){
				System.out.println("�������");
				System.out.println("������С��7������");
				num = sc.nextInt();
			}
			switch(num){
			case 1:
				day = "MON";
				break;
			case 2:
				day = "TUE";
				break;
			case 3:
				day = "WED";
				break;
			case 4:
				day = "THU";
				break;
			case 5:
				day = "ERI";
				break;
			case 6:
				day = "SAT";
				break;
			case 7:
				day = "SUN";
				break;
			}
			if(num != 0){
			System.out.println("������"+ day);
			System.out.println("������С��7������");
			num = sc.nextInt();
			}
		}while(num != 0);
		System.out.println("�������");

	}

}
