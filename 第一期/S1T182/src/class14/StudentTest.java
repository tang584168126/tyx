package class14;

import java.util.Scanner;

public class StudentTest {
	
	Scanner sc = new Scanner(System.in);
	int num = 0 ;

	public void changeStudent(Student stu){
		
			System.out.println("1���޸�ѧ������");
			System.out.println("2���޸�ѧ������");
			System.out.println("��ѡ��");
			num = sc.nextInt();
			
			switch(num){
			case 1:
				System.out.println("ѧ��ԭ����" + stu.stuName);
				System.out.println("�������޸ĺ�����֣�");
				stu.stuName = sc.next();
				break;
			case 2:
				System.out.println("ѧ��ԭ���䣺" + stu.stuAge);
				System.out.println("�������޸ĺ�����䣺");
				stu.stuAge = sc.nextInt();
				break;
			}
		
	}
	
	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		StudentTest st = new StudentTest();
		
		Student stu = new Student();
		
		stu.stuName = "����";
		stu.stuAge = 19 ;
		

		String answer = "";
		
		do{
			st.changeStudent(stu);
			
			System.out.println("�޸ĺ�Ľ��Ϊ��" + stu.stuName + "  " + stu.stuAge);
			System.out.println("�Ƿ��������Y/N��");
			answer = sc.next();
			
		}while(answer.equalsIgnoreCase("y"));
	}
}









