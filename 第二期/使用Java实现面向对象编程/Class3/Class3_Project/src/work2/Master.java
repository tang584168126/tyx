package work2;

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
	
	//主人选择宠物
	public Pet getPet(int index){
		Pet pet = null;
		if(index ==1){
			pet = new Dog("白雪","狮子狗");
		}else if(index ==2){
			pet = new Penguin("小琪","Q仔");
		}
		return pet;
	}
	
	//玩耍
	public void play(Pet pet){
		if(pet instanceof Dog){
			Dog dog = (Dog)pet;
			dog.exercise();
		}else if(pet instanceof Penguin){
			Penguin pen = (Penguin)pet;
			pen.swimming();
		}
		
	}
}
