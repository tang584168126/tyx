package class15;

public class Test7 {

	public static void main(String[] args) {
		
		String str = "abcdefg";
		String temp = "";
		
		//设定 抓 下标 4 以后的数据(含 下标 4 的数据)
		//public String substring(int 起始下标);
		temp = str.substring(4);
				
		System.out.println("下标 4 以后的数据: " + temp);
		
		
		System.out.println("\n================================\n");
		
		//获取 下标 2 , 4 的数据
		temp = str.substring(2,4);
		
		System.out.println("下标 2 , 4 的数据: " + temp);
		
		
	}
}
