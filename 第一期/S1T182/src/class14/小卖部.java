package class14;

public class 小卖部 {

	public void 卖东西(double aaa){
		
		System.out.println("买了一瓶水，合计：5元，找零：" + (aaa - 5));
		
		
	}
	
	
	public static void main(String[] args) {
		
		小卖部 卖东西 = new 小卖部();
		
		卖东西.卖东西(20.5);
		
		
	}
	
}
