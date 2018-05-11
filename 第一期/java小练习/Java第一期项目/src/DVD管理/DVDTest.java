package DVD管理;

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
				System.out.println("请选择 0 - 6：");
			//输入类型错误
				if(!sc.hasNextInt()){
					System.out.println("输入错误！");
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
				System.out.println("欢迎下次使用！");
				System.exit(1);
				default:
					System.out.println("请输入正确的选项！");
					break;
			}
			System.out.println("*****************************************\n");
			System.out.println("\n请按Enter键返回主菜单！");
			sc.nextLine();
			sc.nextLine();
		}while(true);
	}

}
