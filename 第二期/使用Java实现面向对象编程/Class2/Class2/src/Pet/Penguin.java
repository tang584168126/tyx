package Pet;

/**
 * 企鹅类
 * @author Administrator
 *
 */
public class Penguin extends Pet {

	private String sex;		//性别
	
	public Penguin(String name, String sex){
		super(name);
		this.sex = sex;
	}
	
	public String getSex(){
		return sex;
	}
	
	public void print(){
		super.print();
		System.out.println("性别" + sex);
	}
}
