package work1;

/**
 * 猫类
 * @author Administrator
 *
 */
public class Cat extends Pet {
	
	private String colour;		//颜色
	
	public String getColour(){
		return colour;
	}
	
	public Cat(String name,String colour){
		super(name);
		this.colour = colour;
	}
	
	public void print(){
		super.print();
		System.out.println("颜色：" + colour);
	}
	public void eat(){
		super.health += 3;
		System.out.println("猫咪" + super.getName() +"吃饱了，健康值加5！");
	}
}
