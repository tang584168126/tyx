package class15_1;

import java.util.Date;

public class StringBufferTest {

	public static void main(String[] args) {
		
		int i = 0 ;
		StringBuffer sb = new StringBuffer("");
		
		Date date = new Date();
		
		System.out.println("使用 StringBuffer 拼接 5万次 123 开始时间：");
		System.out.println(date.toLocaleString());

		for(i = 0 ; i < 5000000 ; i++){
			
			sb.append("123");
			
		}
		
		date = new Date();
		System.out.println(sb.length());
		System.out.println("结束时间：");
		System.out.println(date.toLocaleString());
		
	}
}
