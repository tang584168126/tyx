package class15_1;


/**
 * ���������� substring()
 * @author fun
 *
 */
public class Test1 {

	public static void main(String[] args) {
		
		//1��substring(int index)
		//���壺�� index ��ʼ��ȡ���������ַ�
		String str = "abcdefg123";
		
		//���±� 3 ��ʼ��ȡ���������ַ�
		str = str.substring(3);
		
		System.out.println(str);
		
		System.out.println("================");
		
		//2��substring(int beginIndex , int endIndex)
		//���壺�� beginIndex ��ʼ 
		//��ȡ�� endIndex ǰһ�� ֮��������ַ�
		str = "abcdefg";
		
		str = str.substring(2,6);
		
		System.out.println(str);
		
	}
	
}






