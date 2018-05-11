package review;
/**
 * 企鹅类
 * @author Administrator
 *
 */
public class Penguin extends Pet {
	private String sex;		//性别

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
		System.out.println("昵称：" + super.getName() + "\t健康值：" + super.getHealth() + "\t亲密度：" + super.getLove() + "\t性别：" + sex);
	}
	
	public void eat(){
		System.out.println("吃鱼。。。");
	}
	
	public void swimming(){
		System.out.println("游泳中。。。");
	}
}
