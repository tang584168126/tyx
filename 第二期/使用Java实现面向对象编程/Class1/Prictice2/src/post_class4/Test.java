package post_class4;

public class Test {

	public static void main(String[] args)
	{
		Student1 stu1 = new Student1();
		
		stu1.setAge();
		
		if(stu1.age >= 16)
		{
			stu1.print();
		}
		else
		{
			System.out.println("请输入正确的年龄！");
		}
	}
}
