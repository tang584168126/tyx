package Pet;

/**
 * �����
 * @author Administrator
 *
 */
public class Penguin extends Pet {

	private String sex;		//�Ա�
	
	public Penguin(String name, String sex){
		super(name);
		this.sex = sex;
	}
	
	public String getSex(){
		return sex;
	}
	
	public void print(){
		super.print();
		System.out.println("�Ա�" + sex);
	}
}
