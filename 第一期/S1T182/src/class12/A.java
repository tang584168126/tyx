package class12;

public class A {

	public void a(){
		
		System.out.println("我是 a()方法");
		
		//调用本类中的 b()方法
		b();
		
		//要调用 B类的 bb()方法
		//1、创建 B类的对象 b
		B b = new B();
		
		//2、利用 B类的对象 b 打点调用 bb()方法
		b.bb();
	}
	
	public void b(){
		System.out.println("我是 b()方法");
	}
}
