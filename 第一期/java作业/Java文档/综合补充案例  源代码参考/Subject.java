package info;
/**
专业类： 
属性：专业编号，专业名称 、学习该专业的人数
方法：介绍情况的方法，描述专业信息。描述内容包括专业名称以及学习该专业的人数
 */
public class Subject {
	private String subjectId;//班级编号
	private String subjectName;//班级名称
	private int number;//班级人数

	//介绍情况的方法，描述专业信息。描述内容包括专业名称以及学习该专业的人数
	public void info(){
		System.out.println(this.subjectName+"专业目前有"+this.number+"名学生");
	}
	public String getSubjectId() {
		return subjectId;
	}
	public void setSubjectId(String subjectId) {
		this.subjectId = subjectId;
	}
	public String getSubjectName() {
		return subjectName;
	}
	public void setSubjectName(String subjectName) {
		this.subjectName = subjectName;
	}
	public int getNumber() {
		return number;
	}
	public void setNumber(int number) {
		this.number = number;
	}
}
