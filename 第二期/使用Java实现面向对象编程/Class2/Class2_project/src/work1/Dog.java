package work1;

/**
 * ����
 * @author Administrator
 *
 */
public class Dog extends Pet {

	private String strain;		//Ʒ��
	
	//���췽��
	public Dog(String name,String strain){
		super(name);
		this.strain = strain;
	}
	
	//Ʒ��
	public String getStrain(){
		return strain;
	}
	
	//��д���෽��
	public void print(){
		System.out.println();
		super.print();
		System.out.println("Ʒ�֣�" + strain);
	}
}
