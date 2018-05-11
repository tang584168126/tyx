package class8;

public class Test3 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		//声明案例：
		//1、正确的
		int [] a1 = {1,2,3,4,5};

		int [] aa = new int[]{1,2,3,4,5};

		int [] a2 = new int[5];
		a2 = new int[]{1,2,3,4,5};
		
		int [] ab ;
		ab = new int[]{1,2,3,4,5};
		
		//3、错误的
		//int [] a = new int[5];
		//a = {1,2,3,4,5} ;
		
		//4、错误的
		//int [] a3 = new int[5]{1,2,3,4,5};
		
		//5、错误的
		//int [] a4 ;
		//a4 = {1,2,3,4,5};
		
		
	}

}
