package class12;

import java.util.Scanner;

public class Seasom {
	int num = 0;
	public void quess(){
		Scanner sc = new Scanner(System.in);
		System.out.print("�������·ݣ�");
		if(sc.hasNext()){
			System.out.println("�������");
		}else{
			num = sc.nextInt();
		}
		switch(num){
		case 3:
		case 4:
		case 5:
			System.out.println("�ü���Ϊ����");
			break;
		case 6:
		case 7:
		case 8:
			System.out.println("�ü���Ϊ�ļ�");
			break;
		case 9:
		case 10:
		case 11:
			System.out.println("�ü���Ϊ�＾");
			break;
		case 12:
		case 1:
		case 2:
			System.out.println("�ü���Ϊ����");
			break;
			default:
				System.out.println("�������");
				break;
		}
	}

}
