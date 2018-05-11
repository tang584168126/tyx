package class11;

import java.util.Scanner;

public class Hero {
	String name ;
	String hp ;
	public void show(){
		Scanner sc = new Scanner(System.in);
		System.out.println("我是英雄，我的基本信息如下：");
		System.out.print("姓名：");
		name =  sc.next();
		System.out.print("生命值：：");
		hp = sc.next();
		
	}

}
