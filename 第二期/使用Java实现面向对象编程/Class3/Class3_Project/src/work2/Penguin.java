package work2;

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
	
	public void swimming(){
		super.love += 5;
		super.health -= 10;
		
		System.out.println("���" + super.getName() + "����ֵ����10�����ܶ�����5");
	}
}
