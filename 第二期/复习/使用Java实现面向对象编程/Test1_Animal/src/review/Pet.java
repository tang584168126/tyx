package review;
/**
 * ������
 * @author Administrator
 *
 */
public abstract class Pet {
	private String name;	//�����ǳ�
	private int health;		//����ֵ
	private int love;		//���ܶ�
	
	public Pet(String name, int health, int love) {
		super();
		this.name = name;
		this.health = health;
		this.love = love;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getHealth() {
		return health;
	}
	public void setHealth(int health) {
		this.health = health;
	}
	public int getLove() {
		return love;
	}
	public void setLove(int love) {
		this.love = love;
	}
	
	//���
	public void print(){
		System.out.println("�ǳƣ�" + name + "\t����ֵ��" + health + "\t���ܶȣ�" + love);
	}
	
	public abstract void eat();
}
