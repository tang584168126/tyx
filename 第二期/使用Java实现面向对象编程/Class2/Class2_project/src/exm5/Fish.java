package exm5;

/**
 * 鱼类
 * @author Administrator
 *
 */
public class Fish extends Animal {

	String weight ;		//重量
	
	//构造方法
	public Fish(int age,String weight){
		super(age);
		this.weight = weight;
	}
	
	//重写父类方法
	public void info(){
		System.out.println("我是一只" + weight + "重的鱼！\n今年" + age + "岁了！");
	}
}
