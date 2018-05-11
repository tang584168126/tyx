package class6;

/**
 * 描述： 1 ~ 100 之间 不能被 3 整除的数 之和
 * @author Administrator
 *
 */
public class Test4 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int i = 0 ;
		int sum = 0 ;
		
		for(i = 1 ; i <= 100 ; i++){
			
			if(i % 3 != 0){
				sum += i ;
			}
			
		}

		System.out.println("1 ~ 100 之间 不能被 3 整除的数 之和为：" + sum);
	}

}
