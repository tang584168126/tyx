package class15;

public class Test1 {

	public static void main(String[] args) {
			
			String str1 = "abcdefg";
			String str2 = "abcdefg";
			
			if(str1.equals(str2)){
				System.out.println("str1.equals(str2) ��");
			}
			else {
				System.out.println("str1.equals(str2) ��");
			}
			
			System.out.println("========================");
			
			if(str1.equalsIgnoreCase(str2)){
				System.out.println("str1.equalsIgnoreCase(str2) ��");
			}
			else {
				System.out.println("str1.equalsIgnoreCase(str2) ��");
			}
			
			System.out.println("========================");
			
			if(str1.toLowerCase().equals(str2.toLowerCase())){
				System.out.println("str1.toLowerCase().equals(str2.toLowerCase()) ��");
			}
			else {
				System.out.println("str1.toLowerCase().equals(str2.toLowerCase()) ��");
			}
		}
}
