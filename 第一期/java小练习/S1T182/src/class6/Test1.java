package class6;

public class Test1 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int val = 4321567 ;

		int detail = 0;


		while(val > 0){

			detail = val % 10 ;
			
			System.out.print(detail);

			val = val / 10 ;
		}

	}

}
