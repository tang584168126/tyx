package exm5;

/**
 * 动物类
 * @author Administrator
 *
 */
public abstract class Animal {

	int age = 0;	//年龄
	
	//构造方法
	public Animal(int age){
		this.age = age;
	}
	
	//抽象方法
	public  void info(){
		System.out.println("----");
	}
		
}
