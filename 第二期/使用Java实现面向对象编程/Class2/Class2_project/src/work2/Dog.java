package work2;

/**
 * 狗类
 * @author Administrator
 *
 */
public class Dog extends Pet {

	private String strain;		//品种
	
	//构造方法
	public Dog(String name,String strain){
		super(name);
		this.strain = strain;
	}
	
	//品种
	public String getStrain(){
		return strain;
	}
	
	//重写父类方法
	public void print(){
		System.out.println("昵称：" + super.getName() + "\t健康值：" + super.getHealth() + "\t亲密度：" + super.getLove() + "\t品种：" + strain);
	}
}
