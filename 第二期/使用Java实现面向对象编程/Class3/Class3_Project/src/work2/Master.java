package work2;

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
	
	//����ѡ�����
	public Pet getPet(int index){
		Pet pet = null;
		if(index ==1){
			pet = new Dog("��ѩ","ʨ�ӹ�");
		}else if(index ==2){
			pet = new Penguin("С��","Q��");
		}
		return pet;
	}
	
	//��ˣ
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
