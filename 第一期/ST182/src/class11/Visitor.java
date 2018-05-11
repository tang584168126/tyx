package class11;

import java.util.Scanner;

public class Visitor {
	String name;
	int year ;
	int price;
	//你分调用我，，我就可以完成  让用户输入年纪并且判断价格
	public void show(){
		Scanner sc = new Scanner(System.in);
		System.out.println("请输入姓名：");
		name = sc.next();
		System.out.println("请输入年龄：");
		year = sc.nextInt();
		if(year > 60 || year < 18){
			price = 20;
			System.out.println("票价为：" + price);
		}
		while(name.equals("n")){
		System.out.println("退出程序！");
		System.exit(1);
		}
	}

}
