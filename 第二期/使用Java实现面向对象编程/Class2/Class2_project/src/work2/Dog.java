package work2;

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
		System.out.println("�ǳƣ�" + super.getName() + "\t����ֵ��" + super.getHealth() + "\t���ܶȣ�" + super.getLove() + "\tƷ�֣�" + strain);
	}
}
