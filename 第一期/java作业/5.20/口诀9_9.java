
public class �ھ�9_9 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int i,j = 1;//ѭ������
		int k = 0;//����ij  �Ļ� ����ռλ��������
		
		//�ۼ�i  j  ��ֵ �ﵽ�����������ֵ
		for(i = 1;i<=9;i++){
			for(j = 1;j<=9;j++){
				 if(j>i){   			//���Ʋ����2*1 = 2,3*1 = 3
					 break;		/*�˴���continue Ч����һ����  ����continue��Ҫ�ص������
					 			for���ж�*/
				 }
			k = i*j;
			System.out.printf("%2d*%-2d=%-2d   ",j,i,k);
			}
			System.out.println(" ");
		}
	}
}
