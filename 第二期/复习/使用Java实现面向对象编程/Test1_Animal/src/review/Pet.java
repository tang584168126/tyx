package review;
/**
 * ³èÎïÀà
 * @author Administrator
 *
 */
public abstract class Pet {
	private String name;	//³èÎïêÇ³Æ
	private int health;		//½¡¿µÖµ
	private int love;		//Ç×ÃÜ¶È
	
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
	
	//Êä³ö
	public void print(){
		System.out.println("êÇ³Æ£º" + name + "\t½¡¿µÖµ£º" + health + "\tÇ×ÃÜ¶È£º" + love);
	}
	
	public abstract void eat();
}
