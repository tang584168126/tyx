package PetShop.entity;

/**
 * 宠物商店实体类
 * @author Administrator
 *
 */
public class Shop {
	//宠物商店编号
	private String id;
	//密码
	private String passWord;
	//宠物商店名称
	private String name;
	//宠物商店结余
	private int balance;
	
	public String getId() {
		return id;
	}
	public void setId(String id) {
		this.id = id;
	}
	public String getPassWord() {
		return passWord;
	}
	public void setPassWord(String passWord) {
		this.passWord = passWord;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getBalance() {
		return balance;
	}
	public void setBalance(int balance) {
		this.balance = balance;
	}
	public Shop(){
		
	}
	public Shop(String id, String passWord, String name, int balance) {
		super();
		this.id = id;
		this.passWord = passWord;
		this.name = name;
		this.balance = balance;
	}
}
