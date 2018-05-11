package review;
/**
 * 主人类
 * @author Administrator
 *
 */
public class Master {
	private String name;	//姓名
	private int money;		//元宝数
	
	public Master(String name, int money) {
		super();
		this.name = name;
		this.money = money;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getMoney() {
		return money;
	}
	public void setMoney(int money) {
		this.money = money;
	}
	
	/*
	 * 喂宠物
	 */
	public void feed(Pet pet){
		pet.eat();
	}
	
	/*
	 *和宠物玩 
	 */
	public void play(Pet pet){
		if(pet instanceof Dog){
			Dog dog = (Dog)pet;
			dog.catching();
		}else if(pet instanceof Penguin){
			Penguin penguin = (Penguin)pet;
			penguin.swimming();
		}
	}
}
