package PetShop.entity;

/**
 * ����ʵ����
 * @author Administrator
 *
 */
public class Master {
	//���˱�ţ���¼����
	private String id;
	//����
	private String passWord;
	//����
	private String name;
	//Ԫ����
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
