package exam5;

/**
 * ����
 * @author Administrator
 *
 */
public class Dog extends Pet implements Eatable,FlyingDiscCatchable {

	public Dog(String name, int health, int love) {
		super(name, health, love);
	}

	@Override
	public void catchingFlyDisc() {
		System.out.println("�������ӷ���...");
	}

	@Override
	public void eat() {
		System.out.println("�Թ���...");
	}

	@Override
	public void print() {
		System.out.println("����:" + super.getName() + "\t����ֵ:" + super.getHealth() + "\t���ܶ�:" + super.getLove());
	}
	
}
