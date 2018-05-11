package class15;

public class Test6 {

	public static void main(String[] args) {
		
		String str = "120345678920";
		
		int index = -1 ;
		
		//第一次出现的下标
		//index = str.indexOf("20") ;
	
		//最后一次出现的下标
		index = str.lastIndexOf("20") ;
		
		
		if(index != -1){
			System.out.println(str + "中包含 20 ");
			System.out.println("在下标：" + index);
		}
		else{
			System.out.println(str + "中不包含 20 ");
		}
		
		System.out.println("====================");
		
	}
	
}
