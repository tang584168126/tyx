package work2;

/**
 * ������
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args){
		//ԭʼ�ֻ�
		CommonHandset cmset = new CommonHandset("G502c","���ᰮ����");
		cmset.print();
		cmset.playWiring();		//����
		cmset.sendNote();		//����Ϣ
		cmset.call();			//ͨ��
		
		System.out.println("\n");
		
		//�����ֻ�
		AptitudeHandset adset = new AptitudeHandset("HTC","I9100");
		adset.print();
		adset.netPlay();		//����
		adset.playWiring();		//����
		adset.takePicuter();	//����
		adset.sendNote();		//����Ϣ
		adset.call();			//ͨ��
	}
}
