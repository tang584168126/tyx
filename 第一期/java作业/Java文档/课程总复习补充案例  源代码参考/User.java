package info;

/**
 * �����ࣺ 
 * ����: �û����������롢���֤�š��˺š��ʻ���>0�� 
 * ������
 * 1������֤�˺��Ƿ���Ч��������Ƿ���Ч�������Ч�޸��˻����
 * 2��ȡ���֤�˺��Ƿ���Ч��ȡ�����Ƿ���Ч������Ƿ��ã������Ч�޸����
 * 
 * */
public class User {
	// ��������
	private String name;
	// ����
	private String password;
	// ������
	private double balance;
	// �ʺ�
	private String account;

	// ���ķ�������֤�˺��Ƿ���Ч��������Ƿ���Ч�������Ч�޸��˻����
	public void saving(String acc, double money) {
		if (!this.account.equals(acc)) {
			System.out.println("�˺Ŵ���");
			return;
		}
		if (money < 0) {
			System.out.println("�������Ч");
			return;
		}
		this.balance += money;
		System.out.println("���ɹ���\n��������:" + this.name + "\n�ʺ�:" + this.account
				+ "\n���ý�" + this.balance);
	}

	// ȡ��ķ�������֤�˺��Ƿ���Ч��ȡ�����Ƿ���Ч������Ƿ��ã������Ч�޸����
	public void getting(String acc, double money) {
		if (!this.account.equals(acc)) {
			System.out.println("�˺Ŵ���");
			return;
		}
		if (money < 0) {
			System.out.println("ȡ������Ч");
			return;
		}
		if (balance-money < 0) {
			System.out.println("��ǰ�˻�����");
			return;
		}
		this.balance -= money;
		System.out.println("ȡ��ɹ���\n��������:" + this.name + "\n�ʺ�:" + this.account
				+ "\n���ý�" + this.balance);
	}
	//�˻�������0
	public void setBalance(double balance) {
		if(balance<0)
			System.out.println("��Ч���");
		else
			this.balance = balance;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	public double getBalance() {
		return balance;
	}

	public String getAccount() {
		return account;
	}

	public void setAccount(String account) {
		this.account = account;
	}
}
