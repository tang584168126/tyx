package post_class5;

/**
 * ѧԱ��
 * @author Administrator
 *
 */
public class Student2 {

	String name = "�ź�";
	int age = 18;
	char sex = 'Ů';
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
		System.out.println("������" + name + "\t���䣺" + age +  "\t�Ա�" + sex + "\tרҵ��" + major);
	}
}
