package work1;

/**
 * ���ࣺ������
 * @author Administrator
 *
 */
public abstract class Pet {

	private String name = "����";	//�ǳ�
	protected int health = 100;		//����ֵ
	private int love = 85;		//���ܶ�

	//�вι��췽��
	public Pet(String name) {
		this.name = name;
	}

	//�ǳ�
	public String getName() {
		return name;
	}
	
	//����ֵ
	public int getHealth() {
		return health;
	}

	//���ܶ�
	public int getLove() {
		return love;
	}

	//���
	public void print(){
		System.out.println("�ǳƣ�" + name + "\t����ֵ��" + health + "\t���ܶȣ�" + love);
	}
	
	//��ʳ
	public abstract void eat();
}
