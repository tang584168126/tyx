package Pet;

/**
 * ����
 * @author Administrator
 *
 */
public class Dog extends Pet{

	private String strain;	//Ʒ��
	
	public Dog(String name,String Strain){
		super(name);
		this.strain = strain;
	}
	
	public String getStrain(){
		return strain;
	}
	
	public void print(){
		super.print();
		System.out.println("Ʒ��" + strain);
	}
}
