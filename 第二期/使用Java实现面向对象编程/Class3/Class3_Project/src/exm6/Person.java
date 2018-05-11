package exm6;

/**
 * 人
 * @author Administrator
 *
 */
public class Person {
	private String name;	//名字
	
	public String getName(){
		return name;
	}
	
	public Person(String name){
		this.name = name;
	}
	//拜访的朋友
	public Friend getFriend(int index){
		Friend friend = null;
		
		if(index == 1){
			friend = new Chinaf("王强");
		}else if(index == 2){
			friend = new Americaf("约翰");
		}
		return friend;
	}
}
