package class14;

/**
 * ������ʹ����������������Ϊ�����Ĳ���
 * @author fun
 *
 */
public class Test4 {

	public void changeValue(int[] a){
		
		a[0] = 200 ;
		
		System.out.println("���÷����У�" + a[0]);
	}
	

	public static void main(String[] args) {
		
		Test4 t = new Test4();
		
		int [] a = {1,2,3};
		
		System.out.println("���÷���ǰ��" + a[0]);
		
		t.changeValue(a);
		
		System.out.println("���÷�����" + a[0]);
	}
}



