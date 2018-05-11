package class12;

public class Lion {

	String color ;
	
	/**
	 * 狮子 跑 的 方法
	 */
	public void run(){
		System.out.println("玩具狮子以 0.1米/秒 的速度奔跑！");
	}
	
	/**
	 * 狮子 叫 的 方法
	 */
	public String bark(){
		//System.out.println("狮子吼！");
		String sound = "狮子吼吼吼吼吼吼吼吼吼！";
		return sound;
	}
	

	public String toString(){
		return color ;
	}
	
}




