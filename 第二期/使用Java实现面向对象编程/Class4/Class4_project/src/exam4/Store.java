package exam4;

public class Store {
	public static Animal get(String choice){
		if(choice.equalsIgnoreCase("pig")){
			return new Pig();
		}else{
			return new Cat();
		}
	}
}
