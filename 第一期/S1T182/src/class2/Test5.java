package class2;

public class Test5 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// 格式化输出小数
		double price = 10.23434567;
		
		//System.out.println("您的金额为：" + price);
		
		System.out.printf("您的金额为：%-9.2f" , price);
	}

}
