package School;

public class Student extends Person{
	String school;
	
	public Student(){
		System.out.println("execute Student()");
	}
	
	public Student(String name,String school){
		super(name);
		this.school = school;
		System.out.println("execute Student(name,school)");
	}
}
