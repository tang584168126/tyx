package class14;

import java.util.Scanner;

public class Test5 {

	//对象数组
	Student[] stus = new Student[3];
	
	public void addStudent(Student stu){
		
		int i = 0 ;
		
		//遍历 stus 数组中是否有空的位置
		for(i = 0 ; i < stus.length ; i++){
			
			//判断 是否有空值
			if(stus[i] == null){
				stus[i] = stu ;
				break;
			}
			
		}
		
	}

	public void showStudents(){
		
		int i = 0 ;
		
		for(i = 0 ; i < stus.length ; i++){
			if(stus[i] != null){
				System.out.println(stus[i].stuName);
				System.out.println(stus[i].stuAge);
			}
		}
	}

	
	public void regStudent(){
		//新增学员
		Student stu = new Student();
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入新学生的名字：");
		stu.stuName = sc.next();
		
		System.out.println("请输入新学生的年龄：");
		stu.stuAge = sc.nextInt() ;
		
		addStudent(stu);
	}

	public static void main(String[] args) {
		
		Test5 t = new Test5();
		
		//新增学员
		t.regStudent();
		
		//打印结果
		t.showStudents();
		
	}
}
