package PetShop.entity;

/**
 * ����ʵ����
 * @author Administrator
 *
 */
public class Pet {
	//������
	private int id;
	//�����ǳ�
	private String name;
	//������������
	private String typeName;
	//���｡��ֵ
	private int health;
	//���ܶ�
	private int love;
	//�۸�
	private int price;
	// ���˱��
	private String masOrShopID;
	//�Ƿ�������
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
