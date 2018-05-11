package class11;

import java.util.Scanner;

public class Arms {

	String name ;
	String ad ;
	public void show(){
		Scanner sc = new Scanner(System.in);
		System.out.println("我是武器，我的基本信息如下：");
		System.out.print("姓名：");
		name =  sc.next();
		System.out.print("攻击力：：");
		ad = sc.next();
		
	}
}
