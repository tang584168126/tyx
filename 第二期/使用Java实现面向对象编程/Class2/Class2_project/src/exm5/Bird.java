package exm5;

/**
 * ����
 * @author Administrator
 *
 */
public class Bird extends Animal {

	String colour ;		//����
	
	//���췽��
	public Bird(int age,String colour){
		super(age);
		this.colour = colour;
	}
	
	//��д���෽��
	public void info(){
		System.out.println("����һֻ" + colour + "����\n����" + age + "���ˣ�");
	}
}
