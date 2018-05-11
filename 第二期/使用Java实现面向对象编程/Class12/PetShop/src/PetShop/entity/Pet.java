package PetShop.entity;

/**
 * 宠物实体类
 * @author Administrator
 *
 */
public class Pet {
	//宠物编号
	private int id;
	//宠物昵称
	private String name;
	//宠物类型名称
	private String typeName;
	//宠物健康值
	private int health;
	//亲密度
	private int love;
	//价格
	private int price;
	// 主人编号
	private String masOrShopID;
	//是否新培育
	private int newOrOld;
	
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
	public String getTypeName() {
		return typeName;
	}
	public void setTypeName(String typeName) {
		this.typeName = typeName;
	}
	public int getHealth() {
		return health;
	}
	public void setHealth(int health) {
		this.health = health;
	}
	public int getLove() {
		return love;
	}
	public void setLove(int love) {
		this.love = love;
	}
	public int getPrice() {
		return price;
	}
	public void setPrice(int price) {
		this.price = price;
	}
	public void setMasOrShopID(String masOrShopID) {
		this.masOrShopID = masOrShopID;
	}
	public int getNewOrOld() {
		return newOrOld;
	}
	public String getMasOrShopID() {
		return masOrShopID;
	}
	public void setNewOrOld(int newOrOld) {
		this.newOrOld = newOrOld;
	}
	
	public Pet(int id, String name, String typeName, int health, int love,
			int price,String masOrShopID, int newOrOld) {
		super();
		this.id = id;
		this.name = name;
		this.typeName = typeName;
		this.health = health;
		this.love = love;
		this.masOrShopID = masOrShopID;
		this.price = price;
		this.newOrOld = newOrOld;
	}
	public Pet() {
		// TODO Auto-generated constructor stub
	}
}
