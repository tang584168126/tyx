/*�û��ࣺ
����:  �û��ǳƣ����룬�Ա����䣬ע��ʱ�䣬�ȼ�
������������Ϣչʾ
*/
public class User {
	public String name;//�ǳ�
	public String pass;//����
	public String gender;//�Ա�
	public int age;//����
	public String date;//ע������
	public String state;//�ȼ�

	//������Ϣչʾ����
	public void info(){
		System.out.println("��Һã�����"+this.name+"������"+this.age+"��\n����"+this.date+"ע��ģ�Ŀǰ�ĵȼ��ǣ�"+this.state);
	}
	/**
	 * ���Է���
	 */
	public static void main(String[] args) {
		//�������
		User lucy=new User();
		//��������ֵ
		lucy.name="Lucy";
		lucy.date="2011-01-08";
		lucy.state="�޵�С����";
		lucy.age=21;
		//���÷���
		lucy.info();
		
		//�������
		User mary=new User();
		//��������ֵ
		lucy.name="Mary";
		lucy.date="2000-01-01";
		lucy.state="�����Ƕ���";
		lucy.age=28;
		//���÷���
		mary.info();	
	}
}
