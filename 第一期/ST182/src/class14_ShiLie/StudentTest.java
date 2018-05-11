package class14_ShiLie;

public class StudentTest {
	public static void main(String[] args){
		Student student1 = new Student();
		student1.id = 10;
		student1.name = "张三";
		student1.age = 18;
		student1.score = 89;
		Student student2 = new Student();
		student2.id = 11;
		student2.name = "李四";
		student2.age = 19;
		student2.score = 92;
		Student student3 = new Student();
		student3.id = 12;
		student3.name = "王五";
		student3.age = 17;
		student3.score = 78;
		Student_Admin addStudent = new Student_Admin();
		addStudent.addStu(student1);
		addStudent.addStu(student2);
		addStudent.addStu(student3);
		addStudent.showStu();
	}

}
