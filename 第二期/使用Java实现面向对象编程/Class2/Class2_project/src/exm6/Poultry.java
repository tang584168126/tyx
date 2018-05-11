package exm6;

/**
 * 家禽类
 * @author Administrator
 *
 */
public class Poultry {

	private String name;	//名字
	private String strain;	//品种
	private String food;	//食物
	private String motion;	//动作
	
	//构造方法
	public Poultry(String name,String strain,String food,String motion){
		this.name = name;
		this.strain =strain;
		this.food = food;
		this.motion = motion;
	}
	
	//名字
	public String getName(){
		return name;
	}
	
	//品种
	public String getStrain(){
		return strain;
	}
	
	//食物
	public String getFood(){
		return food;
	}
	
	//动作
	public String getMotion(){
		return motion;
	}
	
	//输出
	public void print(){
		System.out.println("我叫" + name + ",是一只" + strain + "！");
		System.out.println("我喜欢吃" + food + "！");
		System.out.println("我会" + motion + "！");
	}
	
}
