package class15_1;

import java.util.Date;

public class StringPKStringBuffer {

	public static void main(String[] args) {
		
		String str = "";
		StringBuffer sb = new StringBuffer("");
		int i = 0 ;
		
		//���ϵͳʱ�䣺
		Date date = new Date();
		
		System.out.println("ʹ�� String ƴ�� 5��� 123 ��ʼʱ�䣺");
		System.out.println(date.toLocaleString());
		
		for(i = 0 ; i < 50000 ; i++){
			
			str += "123";
			
		}
		
		date = new Date();
		System.out.println(str.length());
		System.out.println("����ʱ�䣺");
		System.out.println(date.toLocaleString());
	
		System.out.println("=========================================");
		
		date = new Date();
		
		System.out.println("ʹ�� StringBuffer ƴ�� 5��� 123 ��ʼʱ�䣺");
		System.out.println(date.toLocaleString());

		for(i = 0 ; i < 50000 ; i++){
			
			sb.append("123");
			
		}
		
		date = new Date();
		System.out.println(sb.length());
		System.out.println("����ʱ�䣺");
		System.out.println(date.toLocaleString());
	}
	
}
