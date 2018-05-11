package class3;

public class Test8 {

	public static void main(String[] args) {
		
		int a = 5 , b = 10 , c = 0 ;
		
		if(a > 5 && ++b <= 10){
			c = 100 ;
		}
		else{
			c = 200 ;
		}
		
		System.out.println("a = " + a);
		System.out.println("b = " + b);
		System.out.println("c = " + c);
		
		
	}
}
