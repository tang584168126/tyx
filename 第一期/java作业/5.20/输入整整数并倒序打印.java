import java.util.Scanner;


public class 输入整整数并倒序打印 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int a = 0;//储存用户输入的数值  并进行计算
		int b = 0;//储存对a各位数取膜的值
		int i = 0;//循环条件  计数这是一个几位数
		int e = 0;
		int q = 0;
		int u = 0;
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入一个数");
		a = sc.nextInt();
		e = a;
		for(u = 0;e!=0;u++){
			q = e%10;
			e = e/10;
	}
		System.out.println("这是一个" + u + "位数");
		
		for(i = 0;a!=0;i++){
			b = a%10;
			System.out.print(b);//不换行打印
			a = a/10;
	}
		
	}	

}
