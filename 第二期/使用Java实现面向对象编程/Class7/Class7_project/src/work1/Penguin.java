package work1;
/**
 * 企鹅类
 * @author Administrator
 *
 */
public class Penguin {
	private String name;	//昵称
	private String sex;		//性别

	public String getName() {
		return name;
	}

	public Penguin(String name, String sex) {
		super();
		this.name = name;
		this.sex = sex;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getSex() {
		return sex;
	}

	public void setSex(String sex) {
		this.sex = sex;
	}
	
}
