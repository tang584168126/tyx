package class5;

public class Test2_3 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int i = 0;
		int sum = 0;
		 do{
			 i = i+7;
			 System.out.println("i的值：" + i);
			 sum = sum+i;
			 
		 }while(i <= 48);
		 System.out.println("1到50中7的倍数之和是：" + sum);

	}

}
