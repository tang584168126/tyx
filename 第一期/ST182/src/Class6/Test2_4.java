package Class6;

public class Test2_4 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		for(int i = 1;i<=100;i++){
			if(i%3 == 0 && i%5 == 0){
				System.out.println("3��5�ı���");
			}else if(i%5 == 0){
				System.out.println("5�ı���");
			}else if(i%3 == 0){
				System.out.println("3�ı���");
			}else{
				System.out.println(i);
			}
			
			
		}

	}

}
