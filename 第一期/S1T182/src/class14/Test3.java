package class14;

/**
 * ������ʹ�û�������������Ϊ�����Ĳ���
 * @author fun
 *
 */
public class Test3 {

	//change ���� �� Value ֵ
	public void changeValue(double a){
		a = 200 ;
		System.out.println("���÷����У�" + a);
	}
	
	public static void main(String[] args) {
		
		Test3 t = new Test3();
		
		double a = 10 ;
		
		System.out.println("���÷���ǰ��" + a);
		
		t.changeValue(a);
		
		System.out.println("���÷�����" + a);
		
	}
}
