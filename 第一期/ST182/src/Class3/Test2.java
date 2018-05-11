package Class3;

import java.util.Scanner;

public class Test2 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		
		int year = 0;
		String sex = "";
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("请输入孩子年龄：");
		year = sc.nextInt();
		System.out.print("请输入孩子性别：");
		sex = sc.next();
		
		
		if(year <5){
			System.out.println("你的孩子还太小");
			
		}else if(sex.equals("男")){
			System.out.println("你的孩子能搬动桌子");
		}else{
			System.out.println("女孩子不适合搬桌子");
		}
	}	
}
	


