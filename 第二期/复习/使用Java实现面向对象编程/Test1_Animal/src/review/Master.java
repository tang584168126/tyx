package review;
/**
 * ������
 * @author Administrator
 *
 */
public class Master {
	private String name;	//����
	private int money;		//Ԫ����
	
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
	 * ι����
	 */
	public void feed(Pet pet){
		pet.eat();
	}
	
	/*
	 *�ͳ����� 
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
