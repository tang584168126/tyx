package class13;

import java.util.Scanner;

public class Player {
	
	String name ;	//姓名
	int result ;	//积分
	
	public int 出拳(){
		
		int num = 0 ;
		
		Scanner sc = new Scanner(System.in);
		
		do{
		
			num = sc.nextInt();	//接收玩家出拳
			
			switch(num){
			case 1:
				System.out.println("玩家出拳：石头");
				break;
			case 2:
				System.out.println("玩家出拳：剪刀");
				break;
			case 3:
				System.out.println("玩家出拳： 布");
				break;
			default:
				System.out.println("出拳错误，请重新出拳！");
				continue;
			}
			
			//如果用户出拳正确，则跳出出拳步骤
			break;
			
		}while(true);
		
		//出拳正确以后，返回玩家出拳的结果，给 裁判
		return num ;
	}
}
