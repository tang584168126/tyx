package work1;

/**
 * �����
 * @author Administrator
 *
 */
public class Penguin extends Pet {
	
	private String sex;		//�Ա�
	
	public String getSex(){
		return sex;
	}
	
	public Penguin(String name,String sex){
		super(name);
		this.sex = sex;
	}
	
	public void print(){
		super.print();
		System.out.println("�Ա�" + sex);
	}
	public void eat(){
		super.health += 3;
		System.out.println("���" + super.getName() +"�Ա��ˣ�����ֵ��5��");
	}
}
