package Class6;

public class Test2_3 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int chookNum = 0;
		int rabbitNum = 0;
		
		
		for(chookNum = 0;chookNum<=34;chookNum++){
			rabbitNum = 35-chookNum;
			if((2*chookNum) + (4*rabbitNum) == 94){
				System.out.println("ผฆ"+ chookNum + "อร" + rabbitNum);

				break;
				
			}
			
			
		}
		
		
	}

}
