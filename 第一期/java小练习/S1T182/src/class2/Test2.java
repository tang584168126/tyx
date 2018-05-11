package class2;

import java.util.*;

public class Test2 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		//需要保存 成绩、姓名、性别
		double score = 0 ;
		String name = "" ;
		//String sex = "";
		char sex = ' ';
		
		//做接收准备，创建一个扫描器对象
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入Java课程分数：");
		score = sc.nextDouble();
		
		System.out.println("请输入学生姓名：");
		name = sc.next();
		
		System.out.println("请输入学生性别：");
		sex = sc.next().charAt(0);
		
		System.out.println("Java分数为：" + score);
		System.out.println("学生姓名为：" + name);
		System.out.println("学生性别为：" + sex);
		
	}

}

