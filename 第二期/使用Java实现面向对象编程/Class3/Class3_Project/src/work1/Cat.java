package work1;

/**
 * è��
 * @author Administrator
 *
 */
public class Cat extends Pet {
	
	private String colour;		//��ɫ
	
	public String getColour(){
		return colour;
	}
	
	public Cat(String name,String colour){
		super(name);
		this.colour = colour;
	}
	
	public void print(){
		super.print();
		System.out.println("��ɫ��" + colour);
	}
	public void eat(){
		super.health += 3;
		System.out.println("è��" + super.getName() +"�Ա��ˣ�����ֵ��5��");
	}
}
