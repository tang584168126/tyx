package exm5;

/**
 * ����
 * @author Administrator
 *
 */
public class Fish extends Animal {

	String weight ;		//����
	
	//���췽��
	public Fish(int age,String weight){
		super(age);
		this.weight = weight;
	}
	
	//��д���෽��
	public void info(){
		System.out.println("����һֻ" + weight + "�ص��㣡\n����" + age + "���ˣ�");
	}
}
