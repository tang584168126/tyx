package class12;

public class A {

	public void a(){
		
		System.out.println("���� a()����");
		
		//���ñ����е� b()����
		b();
		
		//Ҫ���� B��� bb()����
		//1������ B��Ķ��� b
		B b = new B();
		
		//2������ B��Ķ��� b ������ bb()����
		b.bb();
	}
	
	public void b(){
		System.out.println("���� b()����");
	}
}
