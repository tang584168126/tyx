package info;
/**
学生类：
属性：学号，姓名，年龄，所学习的专业 
方法：学习的方法，描述学习状态。描述内容包括姓名、学号、年龄、所学习的专业信息
 */
public class Student {
	private String stuId;// 学号
	private String stuName;// 姓名
	private int stuAge;// 年龄
	private Subject mySubject;// 所学习的专业

	// 学习的方法，描述学习状态。描述内容包括姓名、学号、年龄、所学习的专业信息
	public void study() {
		String msg = "我叫" + this.stuName + "，今年" + this.stuAge + "岁\n现在就读于"+ this.mySubject.getSubjectName() + "专业，我的学号是" + this.stuId;
		System.out.println(msg);
	}

	//学生年龄大于18岁
	public void setStuAge(int stuAge) {
		if(stuAge<18){
			System.out.println("本大学只收取18岁以上的学生");
			this.stuAge=18;
		}else
			this.stuAge=stuAge;
	}
	//每产生一名学员，专业人数加1
	public void setMySubject(Subject mySubject) {
		//获取该专业已有学生人数
		int number1=mySubject.getNumber();
		//修改学生人数
		number1++;
		mySubject.setNumber(number1);
		//设置专业信息
		this.mySubject=mySubject;
	}
	public String getStuId() {
		return stuId;
	}

	public void setStuId(String stuId) {
		this.stuId = stuId;
	}

	public String getStuName() {
		return stuName;
	}

	public void setStuName(String stuName) {
		this.stuName = stuName;
	}

	public int getStuAge() {
		return stuAge;
	}

	public Subject getMySubject() {
		return mySubject;
	}
}
