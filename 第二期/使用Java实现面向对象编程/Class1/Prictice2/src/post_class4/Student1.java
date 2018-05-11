package post_class4;

import java.util.Scanner;
/**
 * 学员类
 * @author Administrator
 *
 */
public class Student1 {

	String name = "无名";	//姓名
	int age;		//年龄
	
	Scanner sc = new Scanner(System.in);
	
	//年龄验证
	public void setAge()
	{
		System.out.println("请输入该学员年龄：");
		age = sc.nextInt();
	}
	
	//输出
	public void print()
	{
		System.out.println("姓名：" + name + "\t年龄：" + age);
	}
}
