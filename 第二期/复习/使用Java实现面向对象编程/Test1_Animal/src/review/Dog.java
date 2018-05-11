package review;

/**
 * 狗类
 * @author Administrator
 *
 */
public class Dog extends Pet {
	private String strain;		//品种

	public Dog(String name, int health, int love, String strain) {
		super(name, health, love);
		this.strain = strain;
	}

	public String getStrain() {
		return strain;
	}

	public void setStrain(String strain) {
		this.strain = strain;
	}
	
	public void print(){
		super.print();
		System.out.println("昵称：" + super.getName() + "\t健康值：" + super.getHealth() + "\t亲密度：" + super.getLove() + "\t品种：" + strain);
	}
	
	public void eat(){
		System.out.println("吃狗粮。。。");
	}
	
	public void catching(){
		System.out.println("玩接飞盘游戏。。。");
	}
}
