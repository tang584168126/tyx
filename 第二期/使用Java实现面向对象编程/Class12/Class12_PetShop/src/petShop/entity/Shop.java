package petShop.entity;
/**
 * 商店类
 * @author Administrator
 *
 */
public class Shop {
	public Shop(long id, String name, String password, double balance) {
		super();
		this.id = id;
		this.name = name;
		this.password = password;
		this.balance = balance;
	}
	public Shop() {
		super();
		// TODO Auto-generated constructor stub
	}
	//宠物商店id
	private long id;
	//宠物商店名称 
	private String name;
	//宠物商店密码
	private String password;
	//宠物商店资金
	private double balance;
	public long getId() {
		return id;
	}
	public void setId(long id) {
		this.id = id;
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
	public void setBalance(double balance) {
		this.balance = balance;
	}


	

}
