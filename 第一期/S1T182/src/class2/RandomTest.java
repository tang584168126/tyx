package class2;

public class RandomTest {

	
	public static void main(String[] args) {
		
		int num = 0 ;
		int i = 0 ;
		
		//随机出 98 ~ 1000
		//1、大 - 小 + 1 ==> 1000 - 98 + 1 = 903
		//2、Math.random() * 903 + 98
		//3、将 Math.random() * 903 + 98 取整
		//==> (int)(Math.random() * 903 + 98)
		
		for(i = 0 ; i < 100 ; i++){
			
			//随机出所需结果
			num = (int)(Math.random() * 903 + 98);
			
			//打印结果
			System.out.println(num);
		}
		System.out.println("程序结束！");
	}
}
