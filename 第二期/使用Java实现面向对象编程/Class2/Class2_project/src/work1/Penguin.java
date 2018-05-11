package work1;

/**
 * 企鹅类
 * @author Administrator
 *
 */
public class Penguin extends Pet {

	private String sex;		//性别
	
	//性别
	public String getSex(){
		return sex;
	}
	
	//构造方法
	public Penguin(String name,String sex){
		super(name);
		this.sex = sex;
	}
	
	//重写输出方法
	public void print(){
		System.out.println();
		super.print();
		System.out.println("性别：" + sex);
	}
}
