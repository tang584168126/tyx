package work1;
/**
 * �����
 * @author Administrator
 *
 */
public class Penguin {
	private String name;	//�ǳ�
	private String sex;		//�Ա�

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
