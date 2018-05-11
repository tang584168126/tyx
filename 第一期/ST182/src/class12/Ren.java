package class12;

import java.util.Scanner;

public class Ren {

	String name ;		//名字
	int result;			//积分
	int num = 0;
	
	public int giveResult(){
		Scanner sc = new Scanner(System.in);
	
	
		do{
			
			System.out.println("请出拳：(1.石头  2.剪刀  3.布)");
			num = sc.nextInt();
			switch(num){
			case 1:
				System.out.println("人出石头");
				break;
			case 2:
				System.out.println("人出剪刀");
				break;
			case 3:
				System.out.println("人出布");
				break;
				default:
					System.out.println("输入错误，请重新输入！");
					continue;
			}
			break;
		}while(true);
		return num;
	}
	
}
