package work2;

/**
 * ԭʼ�ֻ���
 * @author Administrator
 *
 */
public class CommonHandset extends Handset implements PlayWiring,SendNote,Call {
	public CommonHandset(String brand,String type){
		super(brand,type);
	}

	@Override
	public void call() {
		System.out.println("��ʼ����ͨ��......");
	}

	@Override
	public void sendNote() {
		System.out.println("����������Ϣ......");
	}

	@Override
	public void playWiring() {
		System.out.println("��ʼ��������<<��ѩ>>......");	
	}

	@Override
	public void print() {
		System.out.println("����һ���ͺ�Ϊ" + super.type + "��" + super.brand+ "�ֻ���");
	}
}
