/**
 * �������� 
 * ���ԣ������ұ�ţ����������ƣ�ʹ��״̬��Ԥ�������У�
 * ������Ԥ�� 
 * 
 */
public class Boardroom {
	public String id;// ���
	public String name;// ����
	public boolean used;// ʹ��״̬��true:Ԥ��  false:���У�

	//Ԥ���ķ���,��������ʹ��״̬��������������Ԥ������
	public boolean bespeak() {
		if(this.used==false){
			System.out.println("�ɹ�����"+this.name);
			return true;
		}else{
			System.out.println(this.name+"�Ѿ���Ԥ����");
			return false;
		}
	}
}
