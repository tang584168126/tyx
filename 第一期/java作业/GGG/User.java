package GGG;

/*
 * �û���
 * */
public class User {
	// �˺� ���� ���˺�
	String name = "";
	String pwd = "";
	int Sui = 0;
	// ���� �˺� ����
	String name1 = "";
	String Pwd1 = "";

	// ��½���� (�˺���������ע����˺�����һ�� �ɹ�����true ʧ�ܷ���false)
	public boolean Long() {
		if (name.equalsIgnoreCase(name1) && pwd.equalsIgnoreCase(Pwd1)) {
			return true;
		} else {
			return false;
		}
	}

	// ע�᷽�����˺����벻��Ϊ�� �ɹ�����true ʧ�ܷ���false��
	public boolean ZeCe() {
		if (!(name1.equals("") && Pwd1.equals(""))) {
			return true;
		} else {
			return false;
		}
	}
}
