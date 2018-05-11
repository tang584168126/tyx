package info;

/**
 * 储户类： 
 * 属性: 用户姓名、密码、身份证号、账号、帐户余额（>0） 
 * 方法：
 * 1、存款：验证账号是否有效，存款金额是否有效，如果有效修改账户余额
 * 2、取款：验证账号是否有效，取款金额是否有效，余额是否够用，如果有效修改余额
 * 
 * */
public class User {
	// 储户姓名
	private String name;
	// 密码
	private String password;
	// 存款余额
	private double balance;
	// 帐号
	private String account;

	// 存款的方法，验证账号是否有效，存款金额是否有效，如果有效修改账户余额
	public void saving(String acc, double money) {
		if (!this.account.equals(acc)) {
			System.out.println("账号错误");
			return;
		}
		if (money < 0) {
			System.out.println("存款金额无效");
			return;
		}
		this.balance += money;
		System.out.println("存款成功！\n储户姓名:" + this.name + "\n帐号:" + this.account
				+ "\n可用金额：" + this.balance);
	}

	// 取款的方法，验证账号是否有效，取款金额是否有效，余额是否够用，如果有效修改余额
	public void getting(String acc, double money) {
		if (!this.account.equals(acc)) {
			System.out.println("账号错误");
			return;
		}
		if (money < 0) {
			System.out.println("取款金额无效");
			return;
		}
		if (balance-money < 0) {
			System.out.println("当前账户余额不足");
			return;
		}
		this.balance -= money;
		System.out.println("取款成功！\n储户姓名:" + this.name + "\n帐号:" + this.account
				+ "\n可用金额：" + this.balance);
	}
	//账户余额大于0
	public void setBalance(double balance) {
		if(balance<0)
			System.out.println("无效金额");
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
