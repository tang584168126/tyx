package work1;

/**
 * 父类：宠物类
 * @author Administrator
 *
 */
public abstract class Pet {

	private String name = "无名";	//昵称
	protected int health = 100;		//健康值
	private int love = 85;		//亲密度

	//有参构造方法
	public Pet(String name) {
		this.name = name;
	}

	//昵称
	public String getName() {
		return name;
	}
	
	//健康值
	public int getHealth() {
		return health;
	}

	//亲密度
	public int getLove() {
		return love;
	}

	//输出
	public void print(){
		System.out.println("昵称：" + name + "\t健康值：" + health + "\t亲密度：" + love);
	}
	
	//吃食
	public abstract void eat();
}
