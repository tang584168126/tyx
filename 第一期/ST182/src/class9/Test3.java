package class9;

public class Test3 {
	public static void main(String[] args){
		int i = 0 ; 		//¹«¼¦
		int j = 0 ; 		//Ä¸¼¦
		int k = 0 ; 		//³û¼¦
		for(i = 0 ; i <= 20 ; i++){
			for(j = 0 ; j < 34 ; j++){
				k = 100 - i - j ;
				if(5 * i + 3 * j + 1 * k / 3 == 100){
					System.out.println("¹«¼¦£º" + i + "Ä¸¼¦£º" + j + "³û¼¦£º" + k);
				}
			
			}
		}
	}

}
