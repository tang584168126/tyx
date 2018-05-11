import java.util.Scanner;


public class 利用循环求任意数的乘阶 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int a = 1;//用来储存乘积                 怎么输入14乘阶 还跑出个100e  不是上限21e?
		int c = 0;//循环条件 储存次数
		int d = 1;//循环次数  
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入你想求乘阶的值");
		d = sc.nextInt();
		while(d>9){
			System.out.println("请重新输入");
			d= sc.nextInt();
		}
		System.out.print(d+"!=");//打印 不换行
		
		for(c = 1;c<=d;c++){//了解d的值 判断循环次数
			
			a = a*c;
			System.out.print(c);//打印c每次循环的值 因数
			
			if(c == d){
			break;	//最后一次不用打印*
			}else{
			System.out.print("*");//打印 不换行
			}
		}
			System.out.print("=");//打印 不换行
			System.out.print(a);
	}

}
