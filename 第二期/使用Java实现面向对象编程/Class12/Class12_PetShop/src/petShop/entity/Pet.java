package petShop.entity;


/**
 * 宠物类
 * @author Administrator
 *
 */
public class Pet {
	public Pet(long id, String name, String typeName, int health, int love,
			int ownerId, long storeId) {
		super();
		this.id = id;
		this.name = name;
		this.typeName = typeName;
		this.health = health;
		this.love = love;
		this.ownerId = ownerId;
		this.storeId = storeId;
	}
	public Pet() {
		super();
		// TODO Auto-generated constructor stub
	}
	//宠物编号
	private long id;
	//宠物名称
	private String name;
	//宠物类型
	private String typeName;
	//宠物健康指数
	private int health;
	//宠物亲密度
	private int love;
	//宠物所属宠物主人编号
	private int ownerId;
	//宠物所属宠物商店编号
	private long storeId;
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
	public int getOwnerId() {
		return ownerId;
	}
	public void setOwnerId(int ownerId) {
		this.ownerId = ownerId;
	}
	public long getStoreId() {
		return storeId;
	}
	public void setStoreId(long storeId) {
		this.storeId = storeId;
	}
	
	
}
