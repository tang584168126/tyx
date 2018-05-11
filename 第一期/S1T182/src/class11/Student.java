package class11;

public class Student {

	//属性：
	int stuId ;		//学号
	String stuName;	//姓名
	String stuSex;	//性别
	int stuAge;		//年龄
	int classId;	//所属班级编号
	
	//方法：
	/**
	 * 显示学生信息的方法
	 */
	public String toString(){
		
		return stuId + " " + stuName + " " + stuSex + " " + stuAge + " " + classId ;
		
	}

}
