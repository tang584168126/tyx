package class11;

public class TeacherTest{
	
	Teacher teacher = new Teacher();
	
	
	public static void main(String[] args){
		//����һ�� ��Ա��Ķ��� teacher
		Teacher teacher = new Teacher();
		
		//���� ���� ��� �������Ժͷ���
		teacher.name = "����ʦ";
		teacher.profession = "�����";
		teacher.course = "Java�߼�";
		teacher.age = 5 ;
		
		System.out.println(teacher);
	}
}
