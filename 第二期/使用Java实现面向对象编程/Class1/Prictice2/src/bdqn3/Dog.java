package bdqn3;

/**
 * ����
 * @author Administrator
 *
 */
public class Dog {

	private String name = "����";	//����
	private String colour = "����";	//��ɫ
	private String strain = "����Ȯ";	//Ʒ��
	
	
	public Dog(String name, String colour, String strain) {
		this.name = name;
		this.colour = colour;
		this.strain = strain;
	}

	public String getName()
	{
		return name;
	}
	
	public String getColour()
	{
		return colour;
	}
	
	public String getStrain()
	{
		return strain;
	}
	
	//���
	public void print()
	{
		System.out.println("���֣�" + name + "\t��ɫ��" + colour + "\tƷ�֣�" + strain);
		
	}
}
