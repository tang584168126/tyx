package ²¹;
/**
 * 9 * 9 ³Ë·¨±í
 * @author Administrator
 *
 */
public class ShenFaBiao {
	public static void main(String[] args){
		int i = 0 ; 
		int j = 0 ;
		
		for(i = 1 ; i <= 9 ; i++){
			for(j = 1 ; j <= i ; j++){
				System.out.print(j + "*" + i + "=" + j * i + "\t");
			}
			System.out.println();
		}
	}

}
