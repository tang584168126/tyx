package work2;

/**
 * ����
 * @author Administrator
 *
 */
public class Dog extends Pet{

	private String strain;		//Ʒ��
	
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
		
		System.out.println("����" + super.getName() + "����ֵ����10�����ܶ�����5");
	}
}
