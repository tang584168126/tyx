package exm6;

/**
 * ������
 * @author Administrator
 *
 */
public abstract class Friend {
	private String name;	//����
	
	public String getName(){
		return name;
	}
	
	public Friend(String name){
		this.name = name;
	}
	
	public abstract void print();
}
