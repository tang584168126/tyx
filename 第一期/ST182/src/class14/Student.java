package class14;

public class Student {
	public void getStudent(String[] student){
		int i = 0;
		

		System.out.println("*******修改结果*****");
		System.out.println("找到并修改成功！");
		System.out.println("***************************\n");
		System.out.println("客户姓名列表：");
		System.out.println("***************************\n");
		for(i = 0 ; i < student.length ; i++){
			System.out.print(student[i] + "\t");
		}
	}
}
