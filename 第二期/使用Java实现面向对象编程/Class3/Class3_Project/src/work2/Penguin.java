package work2;

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
	
	public void swimming(){
		super.love += 5;
		super.health -= 10;
		
		System.out.println("企鹅" + super.getName() + "健康值减少10，亲密度增加5");
	}
}
