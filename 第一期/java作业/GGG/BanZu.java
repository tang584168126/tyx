package  GGG;
import java.util.Scanner;

import javax.sound.sampled.Line;

/*
 * 帮助类      
 * */
public class BanZu {
	Scanner input = new Scanner(System.in);
	boolean isok = false; // 定义开关
	boolean isok1 = false; // 定义开关

	JieMian f = new JieMian(); // 创建界面对象
	User user = new User(); // 创建用户对象
	Choujiang chou = new Choujiang();// 创建抽奖对象

	/*
	 * 简单处理逻辑
	 */
	public void Show() {
		f.Show(); // 主页面
		System.out.println("请输入你要的选择");
		if (LongBiz() == true) {
			int a = input.nextInt();
			if (a == 1) { // 注册页面
				f.ZuCe();
				System.out.println("请输入账号");
				user.name1 = input.next(); // 注册账号接收
				System.out.println("请输入密码");
				user.Pwd1 = input.next(); // 注册密码接受
				if (user.ZeCe()) {// 验证登陆是否成功
					System.out.println("注册成功");
					isok = true;
					Show();
				} else {
					System.out.println("注册失败");
					Show();
				}
			} else if (a == 2) {// 登陆页面
				if (isok) {// 判断他是否注册
					f.DenglU();
					System.out.print("请输入账号");
					user.name = input.next();
					System.out.println("请输入密码");
					user.pwd = input.next();
					if (user.Long()) {// 验证是否登陆成功
						System.out.println("登陆成功");
						isok1 = true;
						int Sui = chou.LonOne();
						user.Sui = Sui;// 将随机数保存到用户随机数中
						System.out.print("欢迎你" + user.name);
						System.out.print("\t你的随机数为:" + Sui);
						System.out.println("");
						Show();
					} else {
						System.out.println("登陆失败");
						Show();
					}
				} else {
					System.out.println("请先注册");
					Show();
				}
			} else if (a == 3) { // 抽奖页面
				if (isok1 && isok) {
					f.ChouJiang();
					System.out.println("你的幸运号为" + user.Sui);
					int[] ac = chou.LongTwo();
					System.out.println("随机数为:");
					for (int i = 0; i < ac.length; i++) {
						System.out.print("\t" + ac[i] + "\t");
					}
					System.out.println("");
					// 验证你是否是幸运者
					for (int i = 0; i < ac.length; i++) {
						if (ac[i] == user.Sui) {
							System.out.println("恭喜你中奖了");
						} else {
							System.out.println("对不起你不是今天的幸运日     谢谢");
						}
						System.out.println("系统结束。。。。");
						System.out.println("欢迎大家下次光临");
						System.exit(1);
					}
				} else {
					System.out.println("请选登陆或者注册");
					Show();
				}
			} else {

				Show();
			}
		} else {
			System.out.println("你输入的数字不合法,请重新输入");
			Show();
		}

	}

	/*
	 * 验证用户输入的是否是数字
	 */
	public boolean LongBiz() {
		System.out.println("输入enter键继续");
		input.nextLine();
		if (!input.hasNextInt()) { // 验证输入的是否是数字
			return false;
		} else {
			return true;
		}
	}
}
