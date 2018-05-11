package class14;

/**
 * 描述：使用引用数据类型作为方法的参数
 * @author fun
 *
 */
public class Test4 {

	public void changeValue(int[] a){
		
		a[0] = 200 ;
		
		System.out.println("调用方法中：" + a[0]);
	}
	

	public static void main(String[] args) {
		
		Test4 t = new Test4();
		
		int [] a = {1,2,3};
		
		System.out.println("调用方法前：" + a[0]);
		
		t.changeValue(a);
		
		System.out.println("调用方法后：" + a[0]);
	}
}



