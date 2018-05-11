package class5;

public class Test5 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int year = 2012;
		double num = 25 ;
		
		do{
			
			//num = num * (1 + 0.25);
			num = num + num * 0.25 ;
			
			year++;
			
			System.out.println("到 " + year + " 年培养人数达到 " + num + " 万");
			
		}while(num < 100);
		
		//System.out.println("到 " + year + " 年培养人数达到 100万");
	}

}



