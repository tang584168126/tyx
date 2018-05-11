package bdqn2;

import java.util.Scanner;

public class Test {

	public static void main(String[] args)
	{
		int choice;	//选择
		String name;	//宠物名字
		String colour;	//宠物颜色
		String strain;	//品种
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入要领养宠物的类型：(1.狗狗 2.其他)");
		choice = sc.nextInt();
		
		switch(choice)
		{
			case 1:
				System.out.println("请输入品种：");
				strain = sc.next();
				System.out.println("请输入颜色：");
				colour = sc.next();
				System.out.println("请输入昵称：");
				name = sc.next();
				
				Dog dog = new Dog();
				dog.name = name;
				dog.colour = colour;
				dog.strain = strain;
				
				dog.print();
				break;
			case 2:
				System.out.println("该宠物已售完，请谅解！");
				break;
			default:
				System.out.println("没有该选项！");
				break;
		
		}
	}
}
