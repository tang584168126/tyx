package  GGG;
import java.util.Scanner;

import javax.sound.sampled.Line;

/*
 * ������      
 * */
public class BanZu {
	Scanner input = new Scanner(System.in);
	boolean isok = false; // ���忪��
	boolean isok1 = false; // ���忪��

	JieMian f = new JieMian(); // �����������
	User user = new User(); // �����û�����
	Choujiang chou = new Choujiang();// �����齱����

	/*
	 * �򵥴����߼�
	 */
	public void Show() {
		f.Show(); // ��ҳ��
		System.out.println("��������Ҫ��ѡ��");
		if (LongBiz() == true) {
			int a = input.nextInt();
			if (a == 1) { // ע��ҳ��
				f.ZuCe();
				System.out.println("�������˺�");
				user.name1 = input.next(); // ע���˺Ž���
				System.out.println("����������");
				user.Pwd1 = input.next(); // ע���������
				if (user.ZeCe()) {// ��֤��½�Ƿ�ɹ�
					System.out.println("ע��ɹ�");
					isok = true;
					Show();
				} else {
					System.out.println("ע��ʧ��");
					Show();
				}
			} else if (a == 2) {// ��½ҳ��
				if (isok) {// �ж����Ƿ�ע��
					f.DenglU();
					System.out.print("�������˺�");
					user.name = input.next();
					System.out.println("����������");
					user.pwd = input.next();
					if (user.Long()) {// ��֤�Ƿ��½�ɹ�
						System.out.println("��½�ɹ�");
						isok1 = true;
						int Sui = chou.LonOne();
						user.Sui = Sui;// ����������浽�û��������
						System.out.print("��ӭ��" + user.name);
						System.out.print("\t��������Ϊ:" + Sui);
						System.out.println("");
						Show();
					} else {
						System.out.println("��½ʧ��");
						Show();
					}
				} else {
					System.out.println("����ע��");
					Show();
				}
			} else if (a == 3) { // �齱ҳ��
				if (isok1 && isok) {
					f.ChouJiang();
					System.out.println("������˺�Ϊ" + user.Sui);
					int[] ac = chou.LongTwo();
					System.out.println("�����Ϊ:");
					for (int i = 0; i < ac.length; i++) {
						System.out.print("\t" + ac[i] + "\t");
					}
					System.out.println("");
					// ��֤���Ƿ���������
					for (int i = 0; i < ac.length; i++) {
						if (ac[i] == user.Sui) {
							System.out.println("��ϲ���н���");
						} else {
							System.out.println("�Բ����㲻�ǽ����������     лл");
						}
						System.out.println("ϵͳ������������");
						System.out.println("��ӭ����´ι���");
						System.exit(1);
					}
				} else {
					System.out.println("��ѡ��½����ע��");
					Show();
				}
			} else {

				Show();
			}
		} else {
			System.out.println("����������ֲ��Ϸ�,����������");
			Show();
		}

	}

	/*
	 * ��֤�û�������Ƿ�������
	 */
	public boolean LongBiz() {
		System.out.println("����enter������");
		input.nextLine();
		if (!input.hasNextInt()) { // ��֤������Ƿ�������
			return false;
		} else {
			return true;
		}
	}
}
