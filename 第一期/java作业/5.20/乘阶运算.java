
public class �˽����� {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int i = 0;//ѭ������
		int j = 10;//10���ڵĳ˽�����
		int cheng = 1;//����ÿ�λ���ֵ
		int sum = 0;//�����ۼӵ��ܺ�
		
		//�ۼ�1��10 sum��ֵ
		for(i = 1;i<=j;i++){
			cheng = cheng*i;
			sum = sum+cheng;
		}
		System.out.println("1!+2!+...10!="+sum);
		/*
		 *1! = 1*1
		 *2! = 1*2= 2
		 *3! = 1*2*3=6
		 *4! = 1*2*3*4=24  �˽�����
		 */

	}

}
