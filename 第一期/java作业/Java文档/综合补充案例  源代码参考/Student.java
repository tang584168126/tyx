package info;
/**
ѧ���ࣺ
���ԣ�ѧ�ţ����������䣬��ѧϰ��רҵ 
������ѧϰ�ķ���������ѧϰ״̬���������ݰ���������ѧ�š����䡢��ѧϰ��רҵ��Ϣ
 */
public class Student {
	private String stuId;// ѧ��
	private String stuName;// ����
	private int stuAge;// ����
	private Subject mySubject;// ��ѧϰ��רҵ

	// ѧϰ�ķ���������ѧϰ״̬���������ݰ���������ѧ�š����䡢��ѧϰ��רҵ��Ϣ
	public void study() {
		String msg = "�ҽ�" + this.stuName + "������" + this.stuAge + "��\n���ھͶ���"+ this.mySubject.getSubjectName() + "רҵ���ҵ�ѧ����" + this.stuId;
		System.out.println(msg);
	}

	//ѧ���������18��
	public void setStuAge(int stuAge) {
		if(stuAge<18){
			System.out.println("����ѧֻ��ȡ18�����ϵ�ѧ��");
			this.stuAge=18;
		}else
			this.stuAge=stuAge;
	}
	//ÿ����һ��ѧԱ��רҵ������1
	public void setMySubject(Subject mySubject) {
		//��ȡ��רҵ����ѧ������
		int number1=mySubject.getNumber();
		//�޸�ѧ������
		number1++;
		mySubject.setNumber(number1);
		//����רҵ��Ϣ
		this.mySubject=mySubject;
	}
	public String getStuId() {
		return stuId;
	}

	public void setStuId(String stuId) {
		this.stuId = stuId;
	}

	public String getStuName() {
		return stuName;
	}

	public void setStuName(String stuName) {
		this.stuName = stuName;
	}

	public int getStuAge() {
		return stuAge;
	}

	public Subject getMySubject() {
		return mySubject;
	}
}
