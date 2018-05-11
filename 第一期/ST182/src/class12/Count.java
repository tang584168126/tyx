package class12;

import java.util.Scanner;

public class Count {
	Ren ren = new Ren();				//人
	Computer cpu = new Computer();		//机器
	int index;		//人计数器
	int index1;		//机器计数器
	int index2;		//平局计数器
	
	String isOK;
	
	Scanner sc = new Scanner(System.in);
	
	//显示游戏界面的方法
	public void jieMian(){
		System.out.println("*********************************");
		System.out.println("******		人机猜拳		**********");
		System.out.println("*********************************");
		System.out.println("请输入用户名：");
		ren.name = sc.next();
	}
	
	//开始游戏的方法
	public void judgeGames(){
		do{
			ren.num = ren.num;
			System.out.println("请输入" + ren.name + "的结果：" + ren.num);
			cpu.num = cpu.num;
			System.out.println("请输入机器的结果：" + cpu.num);
			
			
			//判断输赢的方法
			if(ren.num == 1 && cpu.num == 2 || ren.num == 2 && cpu.num == 3 || ren.num == 3 && cpu.num == 1){
				System.out.println("恭喜您！您赢了！！");
				index++;
			}else if(ren.num == cpu.num){
				System.out.println("平局！");
				index2++;
			}else{
				System.out.println("很遗憾！电脑胜利！");
				index1++;
			}
			
			System.out.println("继续吗？(Y/N)");
			isOK = sc.next();
		}while(isOK.equalsIgnoreCase("y"));
		
		//显示游戏结果
		System.out.println("您胜利的次数：" + index);
		System.out.println("电脑胜利的次数：" + index1);
		System.out.println("平局的次数：" + index2);
		
	}
	
	
	
}
