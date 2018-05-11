package post_class5;

/**
 * 学员类
 * @author Administrator
 *
 */
public class Student2 {

	String name = "张浩";
	int age = 18;
	char sex = '女';
	String major = "JAVA";
	
	
	public Student2(char sex,String major){
		this.sex = sex;
		this.major = major;
		
	}
	
	public Student2(String name, int age, char sex, String major) {
		super();
		this.name = name;
		this.age = age;
		this.sex = sex;
		this.major = major;
	}
	
	public void print(){
		System.out.println("姓名：" + name + "\t年龄：" + age +  "\t性别：" + sex + "\t专业：" + major);
	}
}
