import java.util.Scanner;


public class Console5 {
	public static void main(String[] args){
		
		int a = 0;
		Scanner sc = new Scanner(System.in);
		while(a < 100 )
		{
			
			
			if(! sc.hasNextInt())
			{
				System.out.println("�������");
				
			}else{
				System.out.println("������a��ֵ��" );
				a = sc.nextInt();
			}
			
		}
	}
}
