package class14;

import java.util.Scanner;

public class StudentTest {
	
	Scanner sc = new Scanner(System.in);
	int num = 0 ;

	public void changeStudent(Student stu){
		
			System.out.println("1、修改学生姓名");
			System.out.println("2、修改学生年龄");
			System.out.println("请选择：");
			num = sc.nextInt();
			
			switch(num){
			case 1:
				System.out.println("学生原名：" + stu.stuName);
				System.out.println("请输入修改后的名字：");
				stu.stuName = sc.next();
				break;
			case 2:
				System.out.println("学生原年龄：" + stu.stuAge);
				System.out.println("请输入修改后的年龄：");
				stu.stuAge = sc.nextInt();
				break;
			}
		
	}
	
	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		StudentTest st = new StudentTest();
		
		Student stu = new Student();
		
		stu.stuName = "张三";
		stu.stuAge = 19 ;
		

		String answer = "";
		
		do{
			st.changeStudent(stu);
			
			System.out.println("修改后的结果为：" + stu.stuName + "  " + stu.stuAge);
			System.out.println("是否继续？（Y/N）");
			answer = sc.next();
			
		}while(answer.equalsIgnoreCase("y"));
	}
}









