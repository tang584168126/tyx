package class9;

public class Test3 {

	public static void main(String[] args) {
		
		int i = 0 , j = 0 ;
		
		for(i = 1 ; i <= 9 ; i++){
			
			for(j = 1 ; j <= i ; j++){
				
				//System.out.print(i + "*" + j + "=" + i * j + "  ");
				System.out.printf("%d*%d=%-2d  " , i , j , i * j);
				
			}
			
			System.out.println();
		}
		
		
	}
}
