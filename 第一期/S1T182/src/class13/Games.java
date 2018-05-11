package class13;

import java.util.Scanner;

public class Games {

	Player player; // 玩家
	Computer cpu; // 机器
	int count = 0; // 计数器，记录游戏次数

	int playerNum = 0; // 玩家出拳的结果
	int cpuNum = 0; // 机器出拳的结果

	// 初始化游戏数据的方法
	public void init() {
		player = new Player(); // 刷新玩家数据
		cpu = new Computer(); // 刷新机器数据
	}

	// 显示游戏界面的方法
	public void showGameView() {
		System.out.println("**********************************");
		System.out.println("*              人机猜拳           *");
		System.out.println("*                                *");
		System.out.println("*                  作者：fun     *");
		System.out.println("**********************************");
		System.out.println("人机猜拳规则： 玩家和机器分别出拳（石头、剪刀、布）");
		System.out.println(" 石头 赢 剪刀 、 剪刀 赢 布 、 布 赢 石头 ");

	}

	// 开始游戏的方法
	public void startGame() {

		String answer = "";
		Scanner sc = new Scanner(System.in);
		
		// 初始化游戏数据
		init();

		//调用游戏界面
		this.showGameView();
		
		do {
			// 请玩家出拳
			System.out.println("请玩家出拳：(1、石头 ， 2、剪刀 ， 3、布)");

			// 接收玩家出拳的结果
			playerNum = player.出拳();

			// 请机器出拳
			System.out.println("请机器出拳：");

			// 接收机器出拳的结果
			cpuNum = cpu.出拳();

			// 判断人机猜拳的结果
			getResult();
			
			System.out.println();
			
			System.out.println("是否继续？（Y/N）");
			answer = sc.next();
			
		} while (answer.equalsIgnoreCase("y"));

		// 最后 显示 输赢结果
		showGameResult();
	}

	// 判断输赢的方法
	public void getResult() {

		if (playerNum == 1 && cpuNum == 2 || playerNum == 2 && cpuNum == 3
				|| playerNum == 3 && cpuNum == 1) {
			System.out.println("恭喜玩家获胜！");
			player.result++; // 为玩家增加 1 的积分
		} else if (playerNum == cpuNum) {
			System.out.println(" 双方战平！ ");
		} else {
			System.out.println("恭喜机器获胜！");
			cpu.result++; // 为机器增加 1 的积分
		}

		// 统计游戏次数
		count++;

	}

	// 显示游戏结果
	public void showGameResult() {

		System.out.println("游戏总次数：" + count);
		System.out.println("玩家获胜：" + player.result + " 次");
		System.out.println("机器获胜：" + cpu.result + " 次");
		System.out.println("平局：" + (count - player.result - cpu.result));

		System.out.println("================================================");
		System.out.println("最终获胜者为："
				+ (player.result > cpu.result ? "玩家获胜！"
						: player.result == cpu.result ? "平局" : "机器"));

	}
}
