package work1;

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
		System.out.println();
		super.print();
		System.out.println("品种：" + strain);
	}
}
