package work2;

/**
 * 宠物类
 * @author Administrator
 *
 */
public abstract class Pet {

	private String name = "无名";	//昵称
	protected int health = 100;		//健康值
	protected int love = 85;		//亲密度

	//有参构造方法
	public Pet(String name) {
		this.name = name;
	}

	//昵称
	public String getName() {
		return name;
	}

}
