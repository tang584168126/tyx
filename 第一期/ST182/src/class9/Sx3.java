package class9;

import java.util.Scanner;

public class Sx3 {
	public static void main(String[] args){
		int i = 0 ; 
		int j = 0;
		int k = 0;
		int high = 0 ; 
		Scanner sc = new Scanner(System.in);
		System.out.print("������߶ȣ�");
		high = sc.nextInt();
		for(i = 0 ; i < high ; i++){
			for(k = 0 ; k < high - 1 - i ; k ++){
				System.out.print("  ");
			}
			for(j = 0 ; j < 2 * i + 1 ; j++){
				System.out.print("* ");
			}
			System.out.println();
		}
	}

}
