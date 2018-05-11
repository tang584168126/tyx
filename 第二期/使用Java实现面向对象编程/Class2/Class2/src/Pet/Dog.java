package Pet;

/**
 * 狗类
 * @author Administrator
 *
 */
public class Dog extends Pet{

	private String strain;	//品种
	
	public Dog(String name,String Strain){
		super(name);
		this.strain = strain;
	}
	
	public String getStrain(){
		return strain;
	}
	
	public void print(){
		super.print();
		System.out.println("品种" + strain);
	}
}
