package exam5;

/**
 * 企鹅类
 * @author Administrator
 *
 */
public class Penguin extends Pet implements Eatable,Swimmable {

	public Penguin(String name, int health, int love) {
		super(name, health, love);
	}

	@Override
	public void swim() {
		System.out.println("游泳中...");
	}

	@Override
	public void eat() {
		System.out.println("吃鱼...");
	}

	@Override
	public void print() {
		System.out.println("名称:" + super.getName() + "\t健康值:" + super.getHealth() + "\t亲密度:" + super.getLove());
	}
	
}
