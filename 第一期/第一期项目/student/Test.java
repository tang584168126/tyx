package fu;

import java.util.Scanner;

public class Test {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		// 界面类
		Menu me = new Menu();

		// 学生帮助类
		Manager msn = new Manager();
		do {
			me.showMainMenu();
			System.out.println("請輸入你要選擇的功能  0退出");
			int a = input.nextInt();
			switch (a) {
			case 1:
				msn.addStudent();
				break;
			case 2:
				msn.deleteStudent();
				break;
			case 3:
				msn.updateStudent();
				break;
			case 4:
				msn.searchStudent();
				break;
			default:
				System.out.println("退出系统");
				System.exit(0);
				break;
			}
		} while (true);
	}

}
