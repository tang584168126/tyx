package fu;

import java.util.Scanner;

public class Test {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		// ������
		Menu me = new Menu();

		// ѧ��������
		Manager msn = new Manager();
		do {
			me.showMainMenu();
			System.out.println("Ոݔ����Ҫ�x��Ĺ���  0�˳�");
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
				System.out.println("�˳�ϵͳ");
				System.exit(0);
				break;
			}
		} while (true);
	}

}
