package exam5;

/**
 * �����
 * @author Administrator
 *
 */
public class Penguin extends Pet implements Eatable,Swimmable {

	public Penguin(String name, int health, int love) {
		super(name, health, love);
	}

	@Override
	public void swim() {
		System.out.println("��Ӿ��...");
	}

	@Override
	public void eat() {
		System.out.println("����...");
	}

	@Override
	public void print() {
		System.out.println("����:" + super.getName() + "\t����ֵ:" + super.getHealth() + "\t���ܶ�:" + super.getLove());
	}
	
}
