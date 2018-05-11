package class10;

import java.util.*;

/**
 * 描述：LuckMS
 * 幸运抽奖管理系统
 * @author fun
 *
 */

public class LMS {
	
	public static void main(String[] args) {
		
		//会员用户要存储 ： 账号 ， 密码 ， 会员号 ， 生日 , 姓名
		String zhs = "";
		String pwds = "";
		int ids = 0;
		String birthdays = "";
		String names = "";
		
		//随机出来的幸运数字
		int luckNum = 0 ;
		
		//接收用户选择的变量
		int num = 0 ;
		
		//判断用户是否登录成功  true 表示 成功登录 ， false 表示 未登录
		boolean isLogin = false;
		
		//存储用户登录信息的变量
		String loginName = "" , loginPwd = "";
		
		//存储 幸运 会员号的数组
		String[] luckIds = new String[5];
		
		int i = 0 ;
		
		Scanner sc = new Scanner(System.in);
		
		do{
			System.out.println("****************************************");
			System.out.println("*                                      *");
			System.out.println("*           幸运抽奖系统                 *");
			System.out.println("*                                      *");
			System.out.println("*                   　 -- 抽奖皮包公司    *");
			System.out.println("*                                      *");
			System.out.println("****************************************");
			
			System.out.println("\t\t1、注册");
			System.out.println("\t\t2、登录");
			System.out.println("\t\t3、幸运抽奖");
			System.out.println("\t\t0、退出");
			
			System.out.println("\n请选择以上功能：");
			num = sc.nextInt();
			
			switch(num){
			case 1:
				System.out.println("请填写个人注册信息");
				System.out.println("用户名：");
				zhs = sc.next();
				
				System.out.println("密码：");
				pwds = sc.next();
				
				//随机 1000 - 9999 赋值给 会员号
				ids = (int)(Math.random() * 9000 + 1000);
				
				System.out.println("\n您的注册信息为：\n");
				System.out.println("账号 \t 密码 \t\t 会员号 ");
				System.out.println(zhs + " \t " + pwds + " \t " + ids);
				System.out.println("\n按回车继续...\n");
				
				sc.nextLine();
				sc.nextLine();
				
				break;
			case 2:
				
				System.out.println("请输入登录信息：");
				
				System.out.println("用户名：");
				loginName = sc.next();
				
				System.out.println("密码：");
				loginPwd = sc.next();
				
				//判断用户登录信息是否符合注册信息
				if(loginName.equals(zhs) && loginPwd.equals(pwds)){
					//用户如果成功登录，更改登录状态为 true
					isLogin = true ;
					System.out.println("成功登录，按回车回到主界面...");
					
					sc.nextLine();
					sc.nextLine();
				}
				else{
					//用户如果没有登录，更改登录状态为 false
					isLogin = false ;
					
					System.out.println("登录失败，按回车回到主界面...");
				}
				
				break;
			case 3:
				
				//判断登录状态
				if(!isLogin){
					
					//如果用户没有经过登录进入此功能，则跳回主界面
					System.out.println("请登录后进入此功能，按回车键继续...");
					
					sc.nextLine();
					sc.nextLine();
					
					continue;
				}
				
				System.out.println("进入幸运抽奖环节：抽奖针对登录用户的 会员号 进行(此处与书不一致)");
				//抽奖针对登录用户的 会员号 进行(此处与书不一致)
				
				System.out.print("\n本日幸运会员号为：");
				
				//随机产生 5 个 4位的幸运会员号
				for(i = 0 ; i < 5 ; i++){
					luckIds[i] = (int)(Math.random() * 9000 + 1000) + "";
					
					System.out.print(luckIds[i] + "  ");
				}
				System.out.println();
				
				//判断登录用户是否为幸运会员
				//1、遍历所有幸运会员号
				for(i = 0 ; i < luckIds.length ; i++){
					
					//2、判断幸运会员号是否与登录用户的会员号一致
					if((ids + "").equals(luckIds[i])){
						break;
					}
					
				}
				
				//判断用户是否中奖
				if(i < luckIds.length){
					System.out.println("恭喜您，会员号为：" + ids + " 的会员中奖了！");
				}
				else{
					System.out.println("很遗憾，您没有中奖！");
				}
				
				sc.nextLine();
				sc.nextLine();
				
				break;
			case 0:
				System.out.println("欢迎下次继续使用！");
				System.exit(1);
				break;
			default:
				System.out.println("选择错误！");
				break;
			}
		
		}while(true);
	}
	
}











