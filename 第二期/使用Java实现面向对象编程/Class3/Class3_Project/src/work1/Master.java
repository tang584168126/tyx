package work1;

/**
 * ������
 * @author Administrator
 *
 */
public class Master {

	private String name = "";	//����
	private int money = 0;		//Ԫ����
	
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
	
	//ιʳ
	public void feed(Pet pet){
		pet.eat();
	}
}
