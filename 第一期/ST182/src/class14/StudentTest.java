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
			System.out.print("������ͻ�������");
			student[i] = sc.next();
		}
		System.out.println("***************************\n");
		System.out.println("�ͻ������б�");
		System.out.println("***************************\n");
		for(i = 0 ; i < student.length ; i++){
			System.out.print(student[i] + "   ");
		}
		do{
			System.out.println();
			System.out.println("������Ҫ�޸ĵĿͻ�������");
			oldStudentName = sc.next();
			System.out.println("�������µĿͻ�������");
			studentName = sc.next();
			
			for(i = 0 ; i < student.length ; i++){
				if(oldStudentName == student[i]){
					student[i] = studentName;
					break;
				}else{
					System.out.println("û���ҵ����ѧ����");
					System.out.println("���������룡");
				}
				
			}
					
		}while(true);

		//stu.getStudent(student);
	}

}
