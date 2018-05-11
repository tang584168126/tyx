package class14;

import java.util.Scanner;

public class StudentTest {
	public static void main(String[] args){
		Student stu = new Student();
		String[] student = new String[5];
		int i = 0 ;
		
		String studentName;
		String oldStudentName;
		Scanner sc = new Scanner(System.in);
		
		for(i = 0 ; i < student.length ; i++){
			System.out.print("请输入客户姓名：");
			student[i] = sc.next();
		}
		System.out.println("***************************\n");
		System.out.println("客户姓名列表：");
		System.out.println("***************************\n");
		for(i = 0 ; i < student.length ; i++){
			System.out.print(student[i] + "   ");
		}
		do{
			System.out.println();
			System.out.println("请输入要修改的客户姓名：");
			oldStudentName = sc.next();
			System.out.println("请输入新的客户姓名：");
			studentName = sc.next();
			
			for(i = 0 ; i < student.length ; i++){
				if(oldStudentName == student[i]){
					student[i] = studentName;
					break;
				}else{
					System.out.println("没有找到这个学生！");
					System.out.println("请重新输入！");
				}
				
			}
					
		}while(true);

		//stu.getStudent(student);
	}

}
