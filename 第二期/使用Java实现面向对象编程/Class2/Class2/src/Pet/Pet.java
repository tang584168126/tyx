package Pet;

/**
 * ����
 * @author Administrator
 *
 */
public class Pet {

	private String name;	//�ǳ�
	private int health = 100;		//����ֵ
	private int love = 0;		//���ܶ�
	
	//���๹�췽��
	public Pet(String name){
		this.name = name;
	}
	
	//�ǳ�
	public String getName(){
		return name;
	}
	
	//����ֵ
	public int getHealth(){
		return health;
	}
	
	//���ܶ�
	public int getLove(){
		return love;
	}
	
	//���
	public void print(){
		System.out.println("������" + name + "����ֵ" + health + "���ܶ�:" + love);
	}
}
