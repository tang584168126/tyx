/**
 * ����������˼�룬��д�Զ���������IT��ҵ�� 
 * �趨���԰��������������䣬�������򣬹������� 
 * �������������� 
*/
public class ITWorker {
	private String name;// ����
	private int age;// ����
	private String teachic;// ��������
	private int year;// ��������

	// ��������ͨ��������������չ�����λ��ְ�����������Ϣ
	public String work(String company, String duty) {
		String content = "������" + this.name + "\n���䣺" + this.age + "\n��������:"+ this.teachic + "\n�������ޣ�" + this.year + "\nĿǰ��ְ�ڣ�" + company+ "\nְ���ǣ�" + duty;
		return content;
	}

	// �޶�IT��ҵ��Ա��������15�꣬��Ч��Ϣ����ʾ��������Ĭ������15
	public void setAge(int age) {
		if (age < 15) {
			System.out.println("������Ϣ��Ч!���޸�Ĭ������Ϊ15");
			this.age = 15;
		} else
			this.age = age;
	}

	public String getTeachic() {
		return teachic;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}
	public void setTeachic(String teachic) {
		this.teachic = teachic;
	}
	public int getAge() {
		return age;
	}

	public int getYear() {
		return year;
	}

	public void setYear(int year) {
		this.year = year;
	}
}
