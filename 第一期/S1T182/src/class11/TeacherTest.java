package class11;

public class TeacherTest{
	
	Teacher teacher = new Teacher();
	
	
	public static void main(String[] args){
		//创建一个 教员类的对象 teacher
		Teacher teacher = new Teacher();
		
		//利用 对象 打点 调用属性和方法
		teacher.name = "王老师";
		teacher.profession = "计算机";
		teacher.course = "Java逻辑";
		teacher.age = 5 ;
		
		System.out.println(teacher);
	}
}
