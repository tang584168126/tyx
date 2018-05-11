package petShop.entity;
/**
 * 主人类
 * @author Administrator
 *
 */
public class Master {
	public Master(int id, String name, String password, double money) {
		super();
		this.id = id;
		this.name = name;
		this.password = password;
		this.money = money;
	}
	public Master() {
		super();
		// TODO Auto-generated constructor stub
	}
	//主人编号
	private int id;
	//主人名称
	private String name;
	//密码
	private String password;
	//元宝
	private double money;
	public int getId() {
		return id;
	}
	public void setId(int id) {
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
	public double getMoney() {
		return money;
	}
	public void setMoney(double money) {
		this.money = money;
	}


	
}
