package exm5;

/**
 * ������
 * @author Administrator
 *
 */
public abstract class Animal {

	int age = 0;	//����
	
	//���췽��
	public Animal(int age){
		this.age = age;
	}
	
	//���󷽷�
	public  void info(){
		System.out.println("----");
	}
		
}
