package work2;

/**
 * 狗类
 * @author Administrator
 *
 */
public class Dog extends Pet{

	private String strain;		//品种
	
	public String getStrain(){
		return strain;
	}
	
	public Dog(String name,String strain){
		super(name);
		this.strain = strain;
	}
	
	public void exercise(){
		super.love += 5;
		super.health -= 10;
		
		System.out.println("狗狗" + super.getName() + "健康值减少10，亲密度增加5");
	}
}
