package work1;

/**
 * ���ࣺ������
 * @author Administrator
 *
 */
public class Pet {

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
	public void print(){
		System.out.print("�ǳƣ�" + name + "\t����ֵ��" + health + "\t���ܶ�" + love);
	}
}
