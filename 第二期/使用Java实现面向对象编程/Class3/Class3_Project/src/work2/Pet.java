package work2;

/**
 * ������
 * @author Administrator
 *
 */
public abstract class Pet {

	private String name = "����";	//�ǳ�
	protected int health = 100;		//����ֵ
	protected int love = 85;		//���ܶ�

	//�вι��췽��
	public Pet(String name) {
		this.name = name;
	}

	//�ǳ�
	public String getName() {
		return name;
	}

}
