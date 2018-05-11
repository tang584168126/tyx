package class11;

public class StudentTest {

	public static void main(String[] args) {
		
		//创建一个Student类的对象 stu
		Student stu = new Student();
		
		//通过 Student类的对象 stu 打点 调用 
		//Student 类的属性和方法
		stu.stuId = 1 ;
		stu.stuName = "张三";
		stu.stuSex = "男";
		stu.stuAge = 18 ;
		stu.classId = 1 ;
		
		System.out.println(stu.toString());
		System.out.println("\n=======================\n");
		System.out.println(stu);
	}
}
