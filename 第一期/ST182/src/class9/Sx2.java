package class9;

public class Sx2 {
	public static void main(String[] args){
		int count = 0;
		int i = 3;
		int j = 0;
		do{
			j = 1;
			while(j < 3){
				count++;
				j++;
				
			}
			i--;
			
		}while(i > 0 );
		count += j;
		System.out.println(count);
	}

}
