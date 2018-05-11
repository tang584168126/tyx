package class14;

public class 榨汁机Test {

	public static void main(String[] args) {
		
		榨汁机 九阳牌榨汁机 = new 榨汁机();
		
		九阳牌榨汁机.brand = "九阳";
		
		水果 某水果 = new 水果();
		
		某水果.name = "香蕉";
		
		
		九阳牌榨汁机.榨汁的方法(某水果);
		
	}
}
