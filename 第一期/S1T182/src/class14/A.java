package class14;

public class A{
	public void a(){
	
	}
	
	public void aa(){
		//�� aa()������ ���� ����� a()����
		a();
		
		//�� aa()������ ���� B��� bb()����
		//1��Ҫʵ���������õķ���������Ķ���
		B b = new B();
		
		//2��ʹ�� ����Ķ��� ������
		b.bb();
	}
	
	public static void aaa(){
		
	}
	
	
	public static void show(){
		//��̬�����ڲ�������ֱ�ӵ��� 
		//�Ǿ�̬�����Ժͷ���
		
		//�˴����� A�� �� a() ����
		//a();	//���ַ�ʽ���ã���Ҫ����
		
		//�����õڶ��ֵ��÷�ʽ
		A a = new A();
		
		a.a();
		
		
		//�˴����� aaa()����
		aaa();
	}
}