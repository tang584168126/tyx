package 补;

public class Test3 {

	public static void main(String[] args){
		int i = 0 ;
		int j = 0 ;
		int sum = 0;			//阶乘之和
		int ji = 1 ; 			//阶乘之值
		for(i = 1 ; i <= 10 ; i++){
			for(j = 1 ; j <= i ; j++){
				ji *= j ;
			}
			sum += ji ;
		}
		System.out.println("1-10的阶乘之和为：" + sum);
	}
}
