package exam5;

/**
 * ������
 * @author Administrator
 *
 */
public abstract class Pet {
	private String name;	//��������
	private int health;		//����ֵ
	private int love;		//���ܶ�
	
	public String getName() {
		return name;
	}

	public int getHealth() {
		return health;
	}
	
	public int getLove() {
		return love;
	}

	//�вι��췽��
	public Pet(String name, int health, int love) {
		super();
		this.name = name;
		this.health = health;
		this.love = love;
	}

	public abstract void print();
}
