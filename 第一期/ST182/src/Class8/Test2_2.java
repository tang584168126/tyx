package Class8;

import java.util.Scanner;

public class Test2_2 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		int a = 0;
		String[] b = new String[5];
		
		System.out.println("萩補秘5鞘三");
		for(a = 0;a<b.length;a++){
			System.out.print("及" + (a+1) + "鞘三");
			b[a] = sc.next();
			
		}
		System.out.println("！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！");
		for(a = 0;a<b.length;a++){
			System.out.print(b[a]);
		}
		
		System.out.println("");
		System.out.println("剃會嬉咫竃5鞘三葎��");
		System.out.println("！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！");
		for(a = b.length-1;a>=0;a--){
			System.out.print(b[a]);
		}

	}

}
