package Class7;

import java.util.Scanner;

public class 青鸟迷你游戏 {

	public static void main(String[] args) {
		String name, password = "";
		String name1, password1 = "";		// 注册用户 密码
		int idop = 0;						// 注册选项
		int option, option1 = 0;			// 第一层选项
		int a = 0;							// 游戏次数
		int b = 0;							// 要录入用户的数量
		int score = 0;						
		String p = "";						// 判断是否继续	
		int sum = 0;				
		int sum1 = 0;
		double avg = 0;					
		int time = 0;
		int lx = 0;							// 游戏支付类型
		double money = 0;
		int dj = 0;							// 游戏点击率
		int id = 0;							// 用户名
		int year = 0;						// 年龄
		int money1 = 0;						// 余额
		String hh2 = "";
		int [] dex = new int[4];			//游戏局数
		int [] zz = new int[7];				//记录用户输入时的提醒的

		Scanner sc = new Scanner(System.in);
		System.out.println("************************************************\n");
		System.out.println("欢迎来到青鸟迷你游戏平台\n");
		System.out.println("\t1.注册\n");
		System.out.println("\t2.登陆\n");
		System.out.println("************************************************\n");
		
		do{
			do{
		System.out.println("请选择，输入数字:");
		if(!sc.hasNextInt()){
			sc = new Scanner(System.in);
		}else{
			break;
		}
		}while(true);
		idop = sc.nextInt();
		
		if (idop == 1) {
			System.out.println("请输入想要注册的用户名");
			name = sc.next();
			name1 = name;						// 保存用户注册的用户名
			System.out.println("请输入想要注册的密码");
			password = sc.next();
			password1 = password;				// 保存用户注册的密码

			System.out.println("注册成功！");
			do {
				System.out.println("请输入用户名");
				name = sc.next();
				System.out.println("请输入密码");
				password = sc.next();
				if (name.equals(name1) && password.equals(password1)) {
					break;
				} else {
					System.out.println("用户名或密码错误，请重新输入");
				}
			} while (true);
		

		} else if (idop == 2) {				// 直接登录 密码用户名为默认的
			do {
				System.out.println("请输入用户名");
				name = sc.next();
				System.out.println("请输入密码");
				password = sc.next();
				if (name.equals("admin") && password.equals("admin")) {
					break;
				} else {
					System.out.println("用户名或密码错误，请重新输入");
				}
			} while (true);
		}}while(idop>=3);
		
		do{
		System.out.println("************************************************\n");
		System.out.println("欢迎来到青鸟迷你游戏平台\n");
		System.out.println("\t1.游戏币支付\n");
		System.out.println("\t2.游戏点击率\n");
		System.out.println("\t3.添加用户信息\n");
		System.out.println("\t4.玩游戏\n");
		System.out.println("************************************************\n");
		
		do {
			if(zz[0] == 0){
				System.out.println("请选择，输入数字:");
				zz[0]++;
				// 判断选项合法
				if (!sc.hasNextInt()) {
					sc = new Scanner(System.in);
					
				} else {
					break;
				}
			}else{
				System.out.println("输入错误");
				System.out.println("请选择，输入数字:");
				if (!sc.hasNextInt()) {
					sc = new Scanner(System.in);
				} else {
					break;
				}
			}
			
		} while (true);

		option = sc.nextInt();

		while (option > 4) {
			do {
				if(zz[1] == 0){
				System.out.println("请选择，输入数字:");
				zz[1]++;
				if (!sc.hasNextInt()) {
					sc = new Scanner(System.in);
				} else {
					break;
				}
			}else{
				System.out.println("输入错误");
				System.out.println("请选择，输入数字:");

				if (!sc.hasNextInt()) {
					sc = new Scanner(System.in);
				} else {
					break;
				}
			}
			} while (true);
			option = sc.nextInt();
		}
		switch (option) {
		case 1:
			
			System.out.println("************************************************\n");
			System.out.println("青鸟游戏迷你平台>游戏币支付\n");
			System.out.println("请选择你玩的游戏类型：\n");
			System.out.println("\t1.休闲竞技类\n");
			System.out.println("\t2.牌类\n");
			System.out.println("************************************************\n");
			System.out.print("请输入游戏类型：");
			lx = sc.nextInt();
			System.out.print("请输入游戏时长");
			time = sc.nextInt();
			if (lx == 1) {
				if (time > 10) {
					money = time * 20 * 0.5;
					System.out.println("您玩的是休闲竞技类游戏，时长是：" + time
							+ "小时，可以享受5折优惠");
					System.out.println("您需要支付" + money + "个游戏币");
				} else {
					money = time * 20 * 0.8;
					System.out.println("您玩的是休闲竞技类游戏，时长是：" + time
							+ "小时，可以享受8折优惠");
					System.out.println("您需要支付" + money + "个游戏币");
				}
			} else if (lx == 2) {
				if (time > 10) {
					money = time * 10 * 0.5;
					System.out.println("您玩的是牌类游戏，时长是：" + time + "小时，可以享受5折优惠");
					System.out.println("您需要支付" + money + "个游戏币");
				} else {
					money = time * 10 * 0.8;
					System.out.println("您玩的是牌类游戏，时长是：" + time + "小时，可以享受8折优惠");
					System.out.println("您需要支付" + money + "个游戏币");
				}
			}

			break;
		case 2:
			
			System.out.println("************************************************\n");
			System.out.println("青鸟迷你游戏平台>游戏点击率\n");
			for (a = 1; a <= 4; a++) {
				System.out.println("请输入第" + a + "个游戏的点击率:");
				dj = sc.nextInt();
				if (dj > 100) {
					sum++;
				}
			}
			avg = sum * 25;
			System.out.println("点击率大于100的游戏数数：" + sum);
			System.out.println("点击率大于100的游戏所占的比例为：" + avg + "%");
			a = 0;				
			sum = 0;
			break;
		case 3:
			
			System.out.println("************************************************\n");
			System.out.println("青鸟迷你游戏平台>添加用户信息\n");
			System.out.println("请输入要录入用户的数量：");
			a = sc.nextInt();
			for (b = 1; b <= a; b++) {
				System.out.print("请输入用户编号(<4位整数>)：");
				id = sc.nextInt();
				System.out.print("请输入用户年龄：");
				year = sc.nextInt();
				System.out.print("请输入会员余额：");
				money1 = sc.nextInt();
				if (year < 10) {
					System.out.println("很抱歉，你的年龄不适宜玩游戏");
					System.out.println("录入信息失败");
				}
				System.out.println("您录入的会员信息是：");
				System.out.println("用户编号" + id + "\t年龄：" + year + "\t余额："+ money1);
			}

			break;
		case 4:
			
				System.out.println("欢迎来到青鸟迷你游戏平台");
				System.out.println("请选择你喜爱的游戏");
				System.out.println("************************************************\n");
				System.out.println("\t1.斗地主\n");
				System.out.println("\t2.斗牛\n");
				System.out.println("\t3.泡泡龙\n");
				System.out.println("\t4.连连看\n");
				System.out.println("************************************************\n");
				
				do {
					System.out.println("请选择，输入数字:");
				
					if (!sc.hasNextInt()) {
						sc = new Scanner(System.in);
					} else {
						break;
					}
				} while (true);

				option1 = sc.nextInt();

				while (option1 > 4) {
					do {
						System.out.println("请选择，输入数字:");

						if (!sc.hasNextInt()) {
							sc = new Scanner(System.in);
						} else {
							break;
						}
					} while (true);
					option1 = sc.nextInt();
				}
				switch (option1) {

				case 1:
					System.out.println("您已进入斗地主房间\n");
					System.out.println("************************************************\n");
					System.out.println("青鸟迷你游戏平台>游戏晋级\n");

					for (a = 1; a <= 5; a++) { 
						score = (int) (Math.random() *10 + 1);
						System.out.println("您正在玩第" + a + "局游戏,成绩为:"+ (score * 10));

						// 录入成绩超过80和超过60分数的次数
						if (score > 80) {
							sum++;
						} else if (score > 60) {
							sum1++;
						}

						// 如果循环到第5局游戏 则不打印继续下一局
						if (a == 5) {

						} else {
							System.out.print("继续玩下一局吗？（Y/N）");
							p = sc.next();
						}
						if (p.equalsIgnoreCase("N")) {
							System.out.println("您已中途退出游戏。");
							System.out.println("对不起，您未能晋级，继续加油啊！");
							break;
						}
						dex[0]++;
					}
					if(dex[0] < 5){
						break;
					}else{
					System.out.println("游戏结束");

					if (sum >= 4) {
						System.out.println("恭喜你!通过一级");
						System.out.println("游戏体验次数用完！继续晋级请回主菜单充值游戏币");
					} else if (sum1 >= 3) {
						System.out.println("通过二级，继续努力啊！");
						System.out.println("游戏体验次数用完！继续晋级请回主菜单充值游戏币");
					} else {
						System.out.println("对不起，您未能晋级，继续加油啊！");
						System.out.println("游戏体验次数用完！继续晋级请回主菜单充值游戏币");
					}// 添加发挥
					break;
					}
				case 2:
					System.out.println("您已进入斗牛房间\n");
					System.out.println("************************************************\n");
					System.out.println("青鸟迷你游戏平台>游戏晋级\n");
					System.out.println("");

					for (a = 1; a <= 5; a++) { 
						score = (int) (Math.random() *10 + 1);
						System.out.println("您正在玩第" + a + "局游戏,成绩为:"+ (score * 10));
						// 录入成绩超过80和超过60分数的次数
						if (score > 80) {
							sum++;
						} else if (score > 60) {
							sum1++;
						}

						// 如果循环到第5局游戏 则不打印继续下一局
						if (a == 5) {

						} else {
							System.out.print("继续玩下一局吗？（Y/N）");
							p = sc.next();
						}
						if (p.equalsIgnoreCase("N")) {
							System.out.println("您已中途退出游戏。");
							System.out.println("对不起，您未能晋级，继续加油啊！");
							break;
						}
						dex[1]++;
					}
					if(dex[1] < 5){
						break;
					}else{
					System.out.println("游戏结束");

					if (sum >= 4) {
						System.out.println("恭喜你!通过一级");
						System.out.println("游戏体验次数用完！继续晋级请回主菜单充值游戏币");
					} else if (sum1 >= 3) {
						System.out.println("通过二级，继续努力啊！");
						System.out.println("游戏体验次数用完！继续晋级请回主菜单充值游戏币");
					} else {
						System.out.println("对不起，您未能晋级，继续加油啊！");
						System.out.println("游戏体验次数用完！继续晋级请回主菜单充值游戏币");
					}
					break;
					}
				case 3:
					System.out.println("您已进入泡泡龙房间\n");
					System.out.println("************************************************\n");
					System.out.println("青鸟迷你游戏平台>游戏晋级\n");

					for (a = 1; a <= 5; a++) { 
						score = (int) (Math.random() *10 + 1);
						System.out.println("您正在玩第" + a + "局游戏,成绩为:"+ (score * 10));
						if (score > 80) {
							sum++;
						} else if (score > 60) {
							sum1++;
						}

						// 如果循环到第5局游戏 则不打印继续下一局
						if (a == 5) {

						} else {
							System.out.print("继续玩下一局吗？（Y/N）");
							p = sc.next();
						}
						if (p.equalsIgnoreCase("N")) {
							System.out.println("您已中途退出游戏。");
							System.out.println("对不起，您未能晋级，继续加油啊！");
							break;
						}
						dex[2]++;
					}
					if(dex[2] < 5){
						break;
					}else{
					System.out.println("游戏结束");

					if (sum >= 4) {
						System.out.println("恭喜你!通过一级");
						System.out.println("游戏体验次数用完！继续晋级请回主菜单充值游戏币");
					} else if (sum1 >= 3) {
						System.out.println("通过二级，继续努力啊！");
						System.out.println("游戏体验次数用完！继续晋级请回主菜单充值游戏币");
					} else {
						System.out.println("对不起，您未能晋级，继续加油啊！");
						System.out.println("游戏体验次数用完！继续晋级请回主菜单充值游戏币");
					}
					break;
					}
				case 4:
					System.out.println("您已进入连连看房间\n");
					System.out.println("************************************************\n");
					System.out.println("青鸟迷你游戏平台>游戏晋级\n");

					for (a = 1; a <= 5; a++) { 
						score = (int) (Math.random() *10 + 1);
						System.out.println("您正在玩第" + a + "局游戏,成绩为:"+ (score * 10));
						
						if (score > 80) {
							sum++;
						} else if (score > 60) {
							sum1++;
						}

						// 如果循环到第5局游戏 则不打印继续下一局
						if (a == 5) {

						} else {
							System.out.print("继续玩下一局吗？（Y/N）");
							p = sc.next();
						}
						if (p.equalsIgnoreCase("N")) {
							System.out.println("您已中途退出游戏。");
							System.out.println("对不起，您未能晋级，继续加油啊！");
							break;
						}
						dex[3]++;
					}
					if(dex[3] < 5){
						break;
					}else{
					System.out.println("游戏结束");

					if (sum >= 4) {
						System.out.println("恭喜你!通过一级");
						System.out.println("游戏体验次数用完！继续晋级请回主菜单充值游戏币");
					} else if (sum1 >= 3) {
						System.out.println("通过二级，继续努力啊！");
						System.out.println("游戏体验次数用完！继续晋级请回主菜单充值游戏币");
					} else {
						System.out.println("对不起，您未能晋级，继续加油啊！");
						System.out.println("游戏体验次数用完！继续晋级请回主菜单充值游戏币");
					}
					break;
					}
				}
				
			break;
			}
		
		System.out.println("返回上主菜单级请按#");
		hh2 = sc.next();
		}while(hh2.equals("#"));

	}

}
