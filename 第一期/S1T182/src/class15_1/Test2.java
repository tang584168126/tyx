package class15_1;

public class Test2 {

	public static void main(String[] args) {
		
		//trim()
		//ȥ�� �ַ��� ���� / ǰ�� �Ŀո��м�Ŀո񲻹�
		String str = "  1 2 3  ";
		
		//ȥ���ո�ǰ��ԭʼ���
		System.out.println("ȥ���ո�ǰ��ԭʼ���: ");
		System.out.println("**" + str + "**");
		
		System.out.println("===========================");
		
		str = str.trim();
		
		System.out.println("ʹ�� trim() ȥ���ո������½��: ");
		System.out.println("**" + str + "**");
		
		System.out.println("===========================");
		
		//���¸�Ϊ��ֵ :�ո�ո�123�ո�ո�  
		str = "  1 2 3  ";
		
		//Ҫ�����пո�ȫ��ȥ������ʹ�� replace()�滻
		str = str.replace(" ", "");
		
		System.out.println("ʹ��  replace()�滻 ȥ���ո������½��: ");
		System.out.println("**" + str + "**");
		
	}
}
