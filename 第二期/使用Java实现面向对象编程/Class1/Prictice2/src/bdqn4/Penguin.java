package bdqn4;

/**
 * �����
 * @author Administrator
 *
 */
public class Penguin {

	String name1 = "����1";
	String name2 = "����2";
	public static final String SEX_MALE = "Q��";
	public static final String SEX_FEMALE = "Q��";
	
	public void print(String male,String female)
	{
		male = SEX_MALE;
		female = SEX_FEMALE;
		
		//��һֻ���
		System.out.println("���֣�" + name1 + "\t�Ա�" + male);
		
		//�ڶ�ֻ���
		System.out.println("���֣�" + name2 + "\t�Ա�" + female);
	}
	
}
