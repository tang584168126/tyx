package review;
/**
 * �����
 * @author Administrator
 *
 */
public class Penguin extends Pet {
	private String sex;		//�Ա�

	public Penguin(String name, int health, int love, String sex) {
		super(name, health, love);
		this.sex = sex;
	}

	public String getSex() {
		return sex;
	}

	public void setSex(String sex) {
		this.sex = sex;
	}
	
	public void print(){
		super.print();
		System.out.println("�ǳƣ�" + super.getName() + "\t����ֵ��" + super.getHealth() + "\t���ܶȣ�" + super.getLove() + "\t�Ա�" + sex);
	}
	
	public void eat(){
		System.out.println("���㡣����");
	}
	
	public void swimming(){
		System.out.println("��Ӿ�С�����");
	}
}
