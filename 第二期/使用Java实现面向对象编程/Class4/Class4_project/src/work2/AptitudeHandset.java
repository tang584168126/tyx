package work2;

/**
 * �����ֻ���
 * @author Administrator
 *
 */
public class AptitudeHandset extends Handset implements SendNote,Call,NetWork,PlayWiring,TheakePicture {
	public AptitudeHandset(String brand,String type){
		super(brand,type);
	}

	@Override
	public void takePicuter() {
		System.out.println("����......���ճɹ�");
	}

	@Override
	public void playWiring() {
		System.out.println("��ʼ������Ƶ<<Сʱ��>>......");
	}

	@Override
	public void netPlay() {
		System.out.println("�Ѿ������ƶ�����......");
	}

	@Override
	public void call() {
		System.out.println("��ʼ��Ƶͨ��......");
	}

	@Override
	public void sendNote() {
		System.out.println("���ʹ�ͼƬ�����ֵ���Ϣ......");
	}

	@Override
	public void print() {
		System.out.println("����һ���ͺ�Ϊ" + super.type + "��" + super.brand+ "�ֻ���");
	}
}
