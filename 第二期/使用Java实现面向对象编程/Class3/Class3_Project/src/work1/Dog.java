package work1;

/**
 * ����
 * @author Administrator
 *
 */
public class Dog extends Pet {

	private String strain;		//Ʒ��
	
	public String getStrain(){
		return strain;
	}
	
	public Dog(String name,String strain){
		super(name);
		this.strain = strain;
	}
	
	public void print(){
		super.print();
		System.out.println("Ʒ�֣�" + strain);
	}
	public void eat(){
		super.health += 3;
		System.out.println("����" + super.getName() +"�Ա��ˣ�����ֵ��3��");
	}
}
