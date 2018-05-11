package work1;

/**
 * 企鹅类
 * @author Administrator
 *
 */
public class Penguin extends Pet {
	
	private String sex;		//性别
	
	public String getSex(){
		return sex;
	}
	
	public Penguin(String name,String sex){
		super(name);
		this.sex = sex;
	}
	
	public void print(){
		super.print();
		System.out.println("性别：" + sex);
	}
	public void eat(){
		super.health += 3;
		System.out.println("企鹅" + super.getName() +"吃饱了，健康值加5！");
	}
}
