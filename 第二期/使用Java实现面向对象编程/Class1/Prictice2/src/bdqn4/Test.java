package bdqn4;

/**
 * ������
 * @author Administrator
 *
 */
public class Test {

	public static void main(String[] args)
	{
		String name1 = "С��";
		String name2 = "С��";
		String male = "��";
		String female = "��";
		
		Penguin penguin = new Penguin();
		
		penguin.name1 = name1;
		penguin.name2 = name2;
		
		penguin.print(male,female);
	}
}
