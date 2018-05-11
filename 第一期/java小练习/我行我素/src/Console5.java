import java.util.Scanner;


public class Console5 {
	public static void main(String[] args){
		
		int a = 0;
		Scanner sc = new Scanner(System.in);
		while(a < 100 )
		{
			
			
			if(! sc.hasNextInt())
			{
				System.out.println("输入错误");
				
			}else{
				System.out.println("请输入a的值：" );
				a = sc.nextInt();
			}
			
		}
	}
}
