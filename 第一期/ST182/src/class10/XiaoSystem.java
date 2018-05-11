package class10;

import java.util.Scanner;

public class XiaoSystem {
	public static void main(String[] args){
		int num1  ;			//层数
		int random = 0  ;			//随机数
		String name = "" , pw = "" ;			//注册用户名和密码
		String name1 = "" , pw1 = "";			//输入的用户名和密码
		String isOK ;
		int id = 0;
		int i = 0 , j = 0;
		int[] num2 = new int[5];
		boolean isPoint = false ;
		
		Scanner sc = new Scanner(System.in);
		
		do{
			System.out.println("*****************************************\n");
			System.out.println("***********欢迎进入奖客富翁系统********\n");
			System.out.println("\t\t1.注册\n");
			System.out.println("\t\t2.登陆\n");
			System.out.println("\t\t3.抽奖\n");
			System.out.println("*****************************************\n");
			do{
			System.out.print("请选择菜单：");
			
			
			
			if(!sc.hasNextInt()){
				System.out.println("输入错误，请重新输入：");
				sc = new Scanner(System.in);
			}else{
				break;
			}
			}while(true);
			num1 = sc.nextInt();
			switch(num1){
			case 1:
				System.out.println("[奖客富翁系统 > 注册]");
				System.out.println("请填写个人注册信息：");
				System.out.print("用户名：");
				name = sc.next();		
				System.out.print("密码：");
				pw = sc.next();
				random = (int)(Math.random() * 9000 + 1000);
				System.out.println("注册成功，请记住您的会员卡号");	
				System.out.println("用户名\t密码\t会员卡号");
				
				System.out.println( name + "\t" + pw + "\t" + random);
				System.out.print("继续吗？（Y/N）：");
				isOK = sc.next();
				if(isOK.equalsIgnoreCase("n")){
					System.out.println("谢谢使用！");
					System.exit(1);
				}
				System.out.println();
				break;
				
			case 2:
				System.out.println("[奖客富翁系统 > 登陆]");
				for(i = 0 ; i< 3 ; i ++){
					System.out.print("请输入用户名：");
					name1 = sc.next();
					System.out.print("请输入密码：");
					pw1 = sc.next();
					if(name1.equals(name)  && pw1.equals(pw)  ){
						System.out.println("登陆成功！");
						isPoint = true;
						break;
						}else{
							System.out.println("用户名/密码错误");
							System.out.println("您还" + (2 - i) + "有次机会");
						}
					if(i == 2){
						System.out.println("输入错误，系统退出");
						System.exit(1);
					}
				}
				break;
				
			case 3:
				if(!isPoint){
					System.out.println("您还没登陆，请登陆");
					continue;
				}
				System.out.println("[奖客富翁系统 > 抽奖]");
				do{
					System.out.print("请输入您的卡号");
					id = sc.nextInt();
					if(id == random){
						System.out.print("本日幸运数字为：");
						for(j = 0 ; j < 5 ; j++){
							num2[j] = (int)(Math.random() * 9000 + 1000);
							System.out.print(num2[j] + "  ");		
							
							
							
							
							if(id == num2[j]){
								System.out.println("恭喜您！您是幸运会员！");
								System.out.print("继续吗？（Y/N）：");
								isOK = sc.next();
								
								if(isOK.equalsIgnoreCase("n")){
									System.out.println("谢谢使用！");
									System.exit(1);
								
								}
								break;
							}
						}
						System.out.println();
						}	
						break;
					
				
				}while(true);
				break;
				
			default:
				System.out.println("输入错误，请重新输入");
				break;
			}
		}while(true);
	}

}
