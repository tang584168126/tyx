package bdqn3;

/**
 * 狗类
 * @author Administrator
 *
 */
public class Dog {

	private String name = "无名";	//狗名
	private String colour = "纯白";	//颜色
	private String strain = "牧羊犬";	//品种
	
	
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
	
	//输出
	public void print()
	{
		System.out.println("名字：" + name + "\t颜色：" + colour + "\t品种：" + strain);
		
	}
}
