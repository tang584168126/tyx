package work2;

/**
 * �����
 * @author Administrator
 *
 */
public class Penguin extends Pet {

	private String sex;		//�Ա�
	
	//�Ա�
	public String getSex(){
		return sex;
	}
	
	//���췽��
	public Penguin(String name,String sex){
		super(name);
		this.sex = sex;
	}
	
	//��д�������
	public void print(){
		System.out.println("�ǳƣ�" + super.getName() + "\t����ֵ��" + super.getHealth() + "\t���ܶȣ�" + super.getLove() + "\t�Ա�" + sex);
	}
}
