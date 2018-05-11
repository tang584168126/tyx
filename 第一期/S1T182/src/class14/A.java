package class14;

public class A{
	public void a(){
	
	}
	
	public void aa(){
		//在 aa()方法中 调用 本类的 a()方法
		a();
		
		//在 aa()方法中 调用 B类的 bb()方法
		//1、要实例化被调用的方法所在类的对象
		B b = new B();
		
		//2、使用 上面的对象 打点调用
		b.bb();
	}
	
	public static void aaa(){
		
	}
	
	
	public static void show(){
		//静态方法内部不允许直接调用 
		//非静态的属性和方法
		
		//此处调用 A类 的 a() 方法
		//a();	//此种方式调用，会要报错
		
		//必须用第二种调用方式
		A a = new A();
		
		a.a();
		
		
		//此处调用 aaa()方法
		aaa();
	}
}