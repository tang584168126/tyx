package class11;

public class StudentTest {

	public static void main(String[] args) {
		
		//����һ��Student��Ķ��� stu
		Student stu = new Student();
		
		//ͨ�� Student��Ķ��� stu ��� ���� 
		//Student ������Ժͷ���
		stu.stuId = 1 ;
		stu.stuName = "����";
		stu.stuSex = "��";
		stu.stuAge = 18 ;
		stu.classId = 1 ;
		
		System.out.println(stu.toString());
		System.out.println("\n=======================\n");
		System.out.println(stu);
	}
}
