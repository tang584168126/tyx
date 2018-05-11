package work1;

/**
 * 狗类
 * @author Administrator
 *
 */
public class Dog extends Pet {

	private String strain;		//品种
	
	public String getStrain(){
		return strain;
	}
	
	public Dog(String name,String strain){
		super(name);
		this.strain = strain;
	}
	
	public void print(){
		super.print();
		System.out.println("品种：" + strain);
	}
	public void eat(){
		super.health += 3;
		System.out.println("狗狗" + super.getName() +"吃饱了，健康值加3！");
	}
}
