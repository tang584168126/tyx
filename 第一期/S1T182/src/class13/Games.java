package class13;

import java.util.Scanner;

public class Games {

	Player player; // ���
	Computer cpu; // ����
	int count = 0; // ����������¼��Ϸ����

	int playerNum = 0; // ��ҳ�ȭ�Ľ��
	int cpuNum = 0; // ������ȭ�Ľ��

	// ��ʼ����Ϸ���ݵķ���
	public void init() {
		player = new Player(); // ˢ���������
		cpu = new Computer(); // ˢ�»�������
	}

	// ��ʾ��Ϸ����ķ���
	public void showGameView() {
		System.out.println("**********************************");
		System.out.println("*              �˻���ȭ           *");
		System.out.println("*                                *");
		System.out.println("*                  ���ߣ�fun     *");
		System.out.println("**********************************");
		System.out.println("�˻���ȭ���� ��Һͻ����ֱ��ȭ��ʯͷ������������");
		System.out.println(" ʯͷ Ӯ ���� �� ���� Ӯ �� �� �� Ӯ ʯͷ ");

	}

	// ��ʼ��Ϸ�ķ���
	public void startGame() {

		String answer = "";
		Scanner sc = new Scanner(System.in);
		
		// ��ʼ����Ϸ����
		init();

		//������Ϸ����
		this.showGameView();
		
		do {
			// ����ҳ�ȭ
			System.out.println("����ҳ�ȭ��(1��ʯͷ �� 2������ �� 3����)");

			// ������ҳ�ȭ�Ľ��
			playerNum = player.��ȭ();

			// �������ȭ
			System.out.println("�������ȭ��");

			// ���ջ�����ȭ�Ľ��
			cpuNum = cpu.��ȭ();

			// �ж��˻���ȭ�Ľ��
			getResult();
			
			System.out.println();
			
			System.out.println("�Ƿ��������Y/N��");
			answer = sc.next();
			
		} while (answer.equalsIgnoreCase("y"));

		// ��� ��ʾ ��Ӯ���
		showGameResult();
	}

	// �ж���Ӯ�ķ���
	public void getResult() {

		if (playerNum == 1 && cpuNum == 2 || playerNum == 2 && cpuNum == 3
				|| playerNum == 3 && cpuNum == 1) {
			System.out.println("��ϲ��һ�ʤ��");
			player.result++; // Ϊ������� 1 �Ļ���
		} else if (playerNum == cpuNum) {
			System.out.println(" ˫��սƽ�� ");
		} else {
			System.out.println("��ϲ������ʤ��");
			cpu.result++; // Ϊ�������� 1 �Ļ���
		}

		// ͳ����Ϸ����
		count++;

	}

	// ��ʾ��Ϸ���
	public void showGameResult() {

		System.out.println("��Ϸ�ܴ�����" + count);
		System.out.println("��һ�ʤ��" + player.result + " ��");
		System.out.println("������ʤ��" + cpu.result + " ��");
		System.out.println("ƽ�֣�" + (count - player.result - cpu.result));

		System.out.println("================================================");
		System.out.println("���ջ�ʤ��Ϊ��"
				+ (player.result > cpu.result ? "��һ�ʤ��"
						: player.result == cpu.result ? "ƽ��" : "����"));

	}
}
