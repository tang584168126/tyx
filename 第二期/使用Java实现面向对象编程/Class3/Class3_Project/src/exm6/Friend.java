package exm6;

/**
 * ÅóÓÑÀà
 * @author Administrator
 *
 */
public abstract class Friend {
	private String name;	//Ãû×Ö
	
	public String getName(){
		return name;
	}
	
	public Friend(String name){
		this.name = name;
	}
	
	public abstract void print();
}
