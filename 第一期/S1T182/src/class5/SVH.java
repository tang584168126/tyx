package class5;

/**
 * ��������� ���϶Ⱥͻ��϶ȵĶ��ձ�
 * Ҫ�� ���϶� �� 0 - 250 �� ÿ�� 20��Ϊһ��
 * �����Ŀ������ 10��
 * ת����ʽΪ�����϶� = ���϶� * 9 / 5.0 + 32
 * @author fun
 *
 */
public class SVH {

	/**
	 * @param args
	 */
	public static void main(String[] args) {

		double ss = 0 ;	//���϶�
		double hs = 0 ;	//���϶�
		int count = 0 ;	//������
		
		do{			
			//���ݹ�ʽ���� ���϶ȵ��¶�
			hs = ss * 9 / 5.0 + 32 ;
			
			//������ձ�
			System.out.println(hs + "���϶� VS " + ss + "���϶ȣ�"); 
			
			ss += 20 ;
			
			count++;
			
		}while(ss <= 250 && count < 10);

	}

}





