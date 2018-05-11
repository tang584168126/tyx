package bdqn4;

/**
 * 企鹅类
 * @author Administrator
 *
 */
public class Penguin {

	String name1 = "无名1";
	String name2 = "无名2";
	public static final String SEX_MALE = "Q仔";
	public static final String SEX_FEMALE = "Q妹";
	
	public void print(String male,String female)
	{
		male = SEX_MALE;
		female = SEX_FEMALE;
		
		//第一只企鹅
		System.out.println("名字：" + name1 + "\t性别：" + male);
		
		//第二只企鹅
		System.out.println("名字：" + name2 + "\t性别：" + female);
	}
	
}
