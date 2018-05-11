package Pet;

/**
 * 父类
 * @author Administrator
 *
 */
public class Pet {

	private String name;	//昵称
	private int health = 100;		//健康值
	private int love = 0;		//亲密度
	
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
	public void print(){
		System.out.println("姓名：" + name + "健康值" + health + "亲密度:" + love);
	}
}
