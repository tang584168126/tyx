package exam5;

/**
 * 狗类
 * @author Administrator
 *
 */
public class Dog extends Pet implements Eatable,FlyingDiscCatchable {

	public Dog(String name, int health, int love) {
		super(name, health, love);
	}

	@Override
	public void catchingFlyDisc() {
		System.out.println("跳起来接飞盘...");
	}

	@Override
	public void eat() {
		System.out.println("吃狗粮...");
	}

	@Override
	public void print() {
		System.out.println("名称:" + super.getName() + "\t健康值:" + super.getHealth() + "\t亲密度:" + super.getLove());
	}
	
}
