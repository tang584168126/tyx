package class14;

/**
 * 描述：使用基本数据类型作为方法的参数
 * @author fun
 *
 */
public class Test3 {

	//change 更改 ； Value 值
	public void changeValue(double a){
		a = 200 ;
		System.out.println("调用方法中：" + a);
	}
	
	public static void main(String[] args) {
		
		Test3 t = new Test3();
		
		double a = 10 ;
		
		System.out.println("调用方法前：" + a);
		
		t.changeValue(a);
		
		System.out.println("调用方法后：" + a);
		
	}
}
