package DVD����;

import java.util.Scanner;

public class DVDTest {
	public static void main(String[] args){
		int num = 0;
		DvdManager dvd = new DvdManager();
		Scanner sc = new Scanner(System.in);
		dvd.init();
		do{
			do{
				dvd.menu();
				System.out.println("*****************************************");
				System.out.println("��ѡ�� 0 - 6��");
			//�������ʹ���
				if(!sc.hasNextInt()){
					System.out.println("�������");
					sc = new Scanner(System.in);
				}else{
					break;
				}
			}while(true);
			num = sc.nextInt();
			System.out.println("*****************************************\n");
			switch(num){
			case 1:
				dvd.addDVD();
				break;
			case 2:
				dvd.showDVD();
				break;
			case 3:
				dvd.delDVD();
				break;
			case 4:
				dvd.outDVD();
				break;
			case 5:
				dvd.backDVD();
				break;
			case 6:
				dvd.recompose();
				break;
			case 0:
				System.out.println("��ӭ�´�ʹ�ã�");
				System.exit(1);
				default:
					System.out.println("��������ȷ��ѡ�");
					break;
			}
			System.out.println("*****************************************\n");
			System.out.println("\n�밴Enter���������˵���");
			sc.nextLine();
			sc.nextLine();
		}while(true);
	}

}
