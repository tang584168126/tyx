package exam5;

/**
 * 宠物类
 * @author Administrator
 *
 */
public abstract class Pet {
	private String name;	//宠物名称
	private int health;		//健康值
	private int love;		//亲密度
	
	public String getName() {
		return name;
	}

	public int getHealth() {
		return health;
	}
	
	public int getLove() {
		return love;
	}

	//有参构造方法
	public Pet(String name, int health, int love) {
		super();
		this.name = name;
		this.health = health;
		this.love = love;
	}

	public abstract void print();
}
