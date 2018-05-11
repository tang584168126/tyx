package work2;

/**
 * 父类：动物类
 * @author Administrator
 *
 */
public abstract class Pet {

	private String name = "无名";	//昵称
	private int health = 95;		//健康值
	private int love = 80;		//亲密度
	
	//父类构造方法
	public Pet(String name){
		this.name = name;
	}
	
	//昵称
	public String getName(){
		return name;
	}
	
	//健康值
	public int getHealth(){
		return health;
	}
	
	//亲密度
	public int getLove(){
		return love;
	}
	
	//输出
	public abstract void print();
}
