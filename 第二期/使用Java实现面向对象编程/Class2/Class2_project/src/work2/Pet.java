package work2;

/**
 * ���ࣺ������
 * @author Administrator
 *
 */
public abstract class Pet {

	private String name = "����";	//�ǳ�
	private int health = 95;		//����ֵ
	private int love = 80;		//���ܶ�
	
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
	public abstract void print();
}
