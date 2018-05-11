package class11;

import java.util.Scanner;

public class Monster {

	String name ;
	String hp ;
	String type;
	public void show(){
		Scanner sc = new Scanner(System.in);
		System.out.println("我是怪物，我的基本信息如下：");
		System.out.print("姓名：");
		name =  sc.next();
		System.out.print("生命值：：");
		hp = sc.next();
		System.out.print("类型：：");
		type = sc.next();
		
	}
}
