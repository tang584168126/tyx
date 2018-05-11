package work1;

/**
 * 主人类
 * @author Administrator
 *
 */
public class Master {

	private String name = "";	//姓名
	private int money = 0;		//元宝数
	
	public String getName() {
		return name;
	}

	public int getMoney() {
		return money;
	}
	
	public Master(String name,int money){
		this.name = name;
		this.money = money;
	}
	
	//喂食
	public void feed(Pet pet){
		pet.eat();
	}
}
