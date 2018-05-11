package Class6;

public class Test2_4 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		for(int i = 1;i<=100;i++){
			if(i%3 == 0 && i%5 == 0){
				System.out.println("3和5的倍数");
			}else if(i%5 == 0){
				System.out.println("5的倍数");
			}else if(i%3 == 0){
				System.out.println("3的倍数");
			}else{
				System.out.println(i);
			}
			
			
		}

	}

}
