package class15;

public class Test7 {

	public static void main(String[] args) {
		
		String str = "abcdefg";
		String temp = "";
		
		//�趨 ץ �±� 4 �Ժ������(�� �±� 4 ������)
		//public String substring(int ��ʼ�±�);
		temp = str.substring(4);
				
		System.out.println("�±� 4 �Ժ������: " + temp);
		
		
		System.out.println("\n================================\n");
		
		//��ȡ �±� 2 , 4 ������
		temp = str.substring(2,4);
		
		System.out.println("�±� 2 , 4 ������: " + temp);
		
		
	}
}
