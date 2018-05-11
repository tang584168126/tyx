package exm6;

/**
 * 中国朋友
 * @author Administrator
 *
 */
public class Chinaf extends Friend {
	public Chinaf(String name){
		super(name);
	}
	
	public void print(){
		System.out.println(super.getName() +"喜欢吃四川菜，连太极拳");
	}
}
