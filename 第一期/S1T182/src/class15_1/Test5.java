package class15_1;

public class Test5 {

	public static void main(String[] args) {
		
		StringBuffer sb = new StringBuffer("�ഺ�޻ڣ�"); 
		
		System.out.println(sb);
		
		int num = 110; 
		
		StringBuffer sb1 = sb.append("�������㡣");
		
		System.out.println(sb1);
		
		StringBuffer sb2 = sb1.append("����");
		
		System.out.println(sb2);
		
		StringBuffer sb3 = sb2.append(num);
		
		System.out.println(sb3);
		
		System.out.println("==================================");
		
		System.out.println("sb:" + sb);
		System.out.println("sb1:" + sb1);
		System.out.println("sb2:" + sb2);
		System.out.println("sb3:" + sb3);
	}
}
