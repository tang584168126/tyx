import java.util.Scanner;
/*
 * 
 */
public class S等于N个数依次相加 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int sum = 0;//暂时装a的值
		int cs = 0;//要打印的次数
		int a = 0;//输入的数
		int z = 0;//循环条件
		int p = 0;//暂时装a的值
		
		Scanner sc = new Scanner(System.in);
		System.out.println("请输入一个数：");
		a = sc.nextInt();
		sum = a;
		System.out.println("请输入相加次数1~9");
		cs = sc.nextInt();
		
		//循环次数 使p(a) 的值累加
		for (z = 0; z < cs; z++) {
			p = a;
			System.out.print(p);
			//控制"+"的输出
			if (z < (cs - 1)) {
				System.out.print("+");
			}
			a = a * 10 + sum;//满足 a的值累加 5=5*10+5 =55
		}
	}
}
