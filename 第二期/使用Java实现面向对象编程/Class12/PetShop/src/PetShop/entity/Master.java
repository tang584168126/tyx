package PetShop.entity;

/**
 * 主人实体类
 * @author Administrator
 *
 */
public class Master {
	//主人编号（登录名）
	private String id;
	//密码
	private String passWord;
	//姓名
	private String name;
	//元宝数
	private int money;
	
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
	public int getMoney() {
		return money;
	}
	public void setMoney(int money) {
		this.money = money;
	}
	
	public Master(){
		
	}
	
	public Master(String id, String passWord, String name, int money) {
		super();
		this.id = id;
		this.passWord = passWord;
		this.name = name;
		this.money = money;
	}
}
