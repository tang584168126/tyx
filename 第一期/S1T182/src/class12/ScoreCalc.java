package class12;

public class ScoreCalc{
//���ԣ�
	//���Ź��εĳɼ�
	double [] scores = new double[3];
		
	//�ܳɼ�
	double sum = 0 ;
	
	//ƽ����
	double avg = 0 ;
	
//������
	/**
	 * ����ƽ����
	 */
	public void getAvg(){
		
		avg = sum / scores.length;
		
	}
	
	
	
	/**
	 *	�����ܳɼ� 
	 */
	public void getSum(){
		
		sum = scores[0] + scores[1] + scores[2];   
		
	}
	
	/**
	 * ��ʾ�ֵܷķ���
	 */
	public void showSum(){
		System.out.println("���Ź����ܷ�Ϊ��" + sum);
	}
	
	/**
	 * ��ʾƽ���ֵķ���
	 */
	public void showAvg(){
		System.out.println("���Ź���ƽ����Ϊ��" + avg);
	}
}



