package Class1;

import java.util.Scanner;

public class 我行我素购物管理系统 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//购物第一层输入0及0一下的数字 提醒错误 小数
		
		int option1,option2= 0; //选项变量1层/2层
		int number = 0;       	//商品编号
		int amount = 0;			//商品数量
		int id1 = 0;			//会员卡号1
		int baiwei = 0;			//取膜百位
		
		double discount = 0;		//折扣
		double money1 = 0;			//金额
		double money2 = 0;			//应付金额
		double money3 = 0;			//实付金额
		double money4 = 0;			//找的金额
		double price = 0;		//商品价格
		String proceed = "0";	//继续
		String name = "0";  	//商品名称
		String id,password = "0";//用户名/密码
		
		Scanner sc = new Scanner(System.in);
		
		//第一层界面
		System.out.println("————————————————————————————————————————");
		System.out.println("                                        ");
		System.out.println("\t\t\t1.登录系统                                       ");
		System.out.println("\t\t\t2.退出                                                ");
		System.out.println("                                        ");
		System.out.println("                                        ");
		System.out.println("————————————————————————————————————————");
		do{
		System.out.print("请输入数字：");
		
		
		//判断选项合法
		
		if(!sc.hasNextInt()){
			sc = new Scanner(System.in);
		}else{
			break;
			}
		}while(true);
		
		option1 = sc.nextInt();
		
		
		
		
		while(option1 > 2){
			do{
			System.out.println("请输入3以下的数字");
			System.out.println("请输入数字：");
			if(!sc.hasNextInt()){
				sc = new Scanner(System.in);
			}else{
				break;
				}
			}while(true);
			option1 = sc.nextInt();
		}
		
		
		//第一层功能选择
		switch(option1){
		case 1:
			System.out.println("请输入用户名");
			id = sc.next();
			System.out.println("请输入密码");
			password = sc.next();
			
			//判断用户名和密码
			if(id.equals("admin") && password.equals("admin")){
				System.out.println("————————————————————————————————————————");
				System.out.println("\t\t\t1.客户信息管理                           ");
				System.out.println("\t\t\t2.购物管理结                                ");
				System.out.println("\t\t\t3.真情回馈                                       ");
				System.out.println("\t\t\t4.注销                                                ");
				System.out.println("                                        ");
				System.out.println("————————————————————————————————————————");
				System.out.println("请输入数字选项");
				//判断输入是否合法
			if(!sc.hasNext()){
				System.out.println("请输入 数 字 ");
				System.out.println("程序结束");
				System.exit(1);
			}
			option2 = sc.nextInt();
			//第二层功能选择
			switch(option2){
			case 1:
				System.out.println("————————————————————————————————————————");
				System.out.println("                                        ");
				System.out.println("                                        ");
				System.out.println("\t\t\t对不起暂时没有客户信息               ");
				System.out.println("                                        ");
				System.out.println("                                        ");
				System.out.println("————————————————————————————————————————");
				System.out.println("输入数字1录入新会员");//待开发				
				break;
			case 2:
				
				System.out.println("————————————————————————————————————————");
				System.out.println("请输入购买商品的编号                          ");
				System.out.println("1.T恤\t2.网球鞋\t3.网球拍                               ");
				System.out.println("————————————————————————————————————————");
				System.out.println("请输入商品的编号                                                                  ");
				number = sc.nextInt();
				System.out.println("请输入商品的数量                                                                   ");
				amount = sc.nextInt();
				switch(number){
				case 1:
					name = "T恤";
					price = 245.0;
					break;
				case 2:
					name = "网球鞋";
					price = 570;
					break;
				case 3:
					name = "网球拍";
					price = 320.0;
					break;
				default:
					System.out.println("没有此商品请输入1 2 3");
					break;//开发循环
				}
				money1 = price*amount;
				System.out.println(name + "￥" + price + "\t数量" + amount + "\t合计￥" + money1);
				System.out.println("是否继续y/n");//开发能同时购买多个商品以及n的循环
				proceed = sc.next();
				
				if(proceed.equals("y")){
					
					System.out.print("请输入折扣：");
					discount = sc.nextDouble();
					
					money2 = money1*discount;
					System.out.println("应付金额：" + money2);
					System.out.print("请输入实付金额：");
					money3 = sc.nextDouble();
					
					money4 = money3-money2;
					System.out.println("找钱" + money4);//开发返回
					
				}
				break;
			case 3:
				System.out.println("现在的活动只有查看是否是幸运用户");
				System.out.println("请输入4位会员卡号：");
				id1 = sc.nextInt();
				baiwei = id1/100%10;
				
				int random = (int)(Math.random()*10);
				
				if(baiwei == random){
					System.out.println("恭喜你你是幸运客户获得MP3一个");
				}else{
					System.out.println("很遗憾你不是幸运客户");
				}
				
				break;
			case 4:
				//注销 待开发
				break;
			default:
				System.out.println("没有这个选项请重新输入");//待循环
				break;
			}
			}else{
				System.out.println("密码或用户名错误，请重新启动本系统");
			}
			break;
		case 2:
			System.out.println("欢迎下次使用本系统");
			break;
		
		}
		System.out.println("程序结束");

	}

}
