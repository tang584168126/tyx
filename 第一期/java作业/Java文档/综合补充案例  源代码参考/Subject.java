package info;
/**
רҵ�ࣺ 
���ԣ�רҵ��ţ�רҵ���� ��ѧϰ��רҵ������
��������������ķ���������רҵ��Ϣ���������ݰ���רҵ�����Լ�ѧϰ��רҵ������
 */
public class Subject {
	private String subjectId;//�༶���
	private String subjectName;//�༶����
	private int number;//�༶����

	//��������ķ���������רҵ��Ϣ���������ݰ���רҵ�����Լ�ѧϰ��רҵ������
	public void info(){
		System.out.println(this.subjectName+"רҵĿǰ��"+this.number+"��ѧ��");
	}
	public String getSubjectId() {
		return subjectId;
	}
	public void setSubjectId(String subjectId) {
		this.subjectId = subjectId;
	}
	public String getSubjectName() {
		return subjectName;
	}
	public void setSubjectName(String subjectName) {
		this.subjectName = subjectName;
	}
	public int getNumber() {
		return number;
	}
	public void setNumber(int number) {
		this.number = number;
	}
}
