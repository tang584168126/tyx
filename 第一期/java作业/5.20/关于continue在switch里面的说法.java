
public class 关于continue在switch里面的说法 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int sum = 0;
		int i = 0;
		for(i = 1; i<=4;i++){
			switch(i){
			case 1:
				sum = sum+2;
			case 2:
				sum = sum+4;
				continue;
			case 3:
				sum = sum+16;
				break;
			
			}
			System.out.println(sum);
		}

	}

}
