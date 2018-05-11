package exm5;

/**
 * 鸟类
 * @author Administrator
 *
 */
public class Bird extends Animal {

	String colour ;		//重量
	
	//构造方法
	public Bird(int age,String colour){
		super(age);
		this.colour = colour;
	}
	
	//重写父类方法
	public void info(){
		System.out.println("我是一只" + colour + "的鸟！\n今年" + age + "岁了！");
	}
}
