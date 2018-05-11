package class14_ShiLie;

public class Student_Admin {
	Student[] student = new Student[30];
	int i = 0;
	public void addStu(Student stu){
		for(i = 0 ; i < student.length ; i++){
			if(student[i] == null){
				student[i] = stu;
				break;
			}
		}
	}
	public void showStu(){
		for(i = 0 ; i < student.length; i++){
			if(student[i] != null){
				student[i].show();
			}
		}
	}

}
