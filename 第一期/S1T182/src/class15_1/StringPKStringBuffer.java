package class15_1;

import java.util.Date;

public class StringPKStringBuffer {

	public static void main(String[] args) {
		
		String str = "";
		StringBuffer sb = new StringBuffer("");
		int i = 0 ;
		
		//获得系统时间：
		Date date = new Date();
		
		System.out.println("使用 String 拼接 5万次 123 开始时间：");
		System.out.println(date.toLocaleString());
		
		for(i = 0 ; i < 50000 ; i++){
			
			str += "123";
			
		}
		
		date = new Date();
		System.out.println(str.length());
		System.out.println("结束时间：");
		System.out.println(date.toLocaleString());
	
		System.out.println("=========================================");
		
		date = new Date();
		
		System.out.println("使用 StringBuffer 拼接 5万次 123 开始时间：");
		System.out.println(date.toLocaleString());

		for(i = 0 ; i < 50000 ; i++){
			
			sb.append("123");
			
		}
		
		date = new Date();
		System.out.println(sb.length());
		System.out.println("结束时间：");
		System.out.println(date.toLocaleString());
	}
	
}
