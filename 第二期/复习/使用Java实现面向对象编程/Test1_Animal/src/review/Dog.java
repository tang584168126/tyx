package review;

/**
 * ����
 * @author Administrator
 *
 */
public class Dog extends Pet {
	private String strain;		//Ʒ��

	public Dog(String name, int health, int love, String strain) {
		super(name, health, love);
		this.strain = strain;
	}

	public String getStrain() {
		return strain;
	}

	public void setStrain(String strain) {
		this.strain = strain;
	}
	
	public void print(){
		super.print();
		System.out.println("�ǳƣ�" + super.getName() + "\t����ֵ��" + super.getHealth() + "\t���ܶȣ�" + super.getLove() + "\tƷ�֣�" + strain);
	}
	
	public void eat(){
		System.out.println("�Թ���������");
	}
	
	public void catching(){
		System.out.println("��ӷ�����Ϸ������");
	}
}
