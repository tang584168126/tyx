package class14;

import java.util.Scanner;

public class Test5 {

	//��������
	Student[] stus = new Student[3];
	
	public void addStudent(Student stu){
		
		int i = 0 ;
		
		//���� stus �������Ƿ��пյ�λ��
		for(i = 0 ; i < stus.length ; i++){
			
			//�ж� �Ƿ��п�ֵ
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
		//����ѧԱ
		Student stu = new Student();
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("��������ѧ�������֣�");
		stu.stuName = sc.next();
		
		System.out.println("��������ѧ�������䣺");
		stu.stuAge = sc.nextInt() ;
		
		addStudent(stu);
	}

	public static void main(String[] args) {
		
		Test5 t = new Test5();
		
		//����ѧԱ
		t.regStudent();
		
		//��ӡ���
		t.showStudents();
		
	}
}
