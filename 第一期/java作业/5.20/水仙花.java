
public class ˮ�ɻ� {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int i = 0;
		int t  = 0;//��ת t�����i ȡĤ��ĸ�λ�� 
		int k = 0;//��ת k����Ը�λ���ĳ˻� �η���
		int b =0;  //��������i��ֵ ��ѭ�����ٻ���i
		int sum = 0; //����ѭ��������i��ÿλ���ֵĴη��ĺ�
		
		
		for(i = 2; i<=999;i++ ){   //i֮���Բ���0��1��ʼ��ӦΪˮ�ɻ��� ����λ��
			b = i;
		
		if(i!=0){   //��	iȡĤ
		t = i%10;
		k = t*t*t;
		sum  = sum+k;
			}
		i = i/10; //���ö�iʮλ��ȡĤ��׼��     ȡ��i�ĸ�λ��
		
		if(i!=0){
			t = i%10;
			k = t*t*t;
			sum  = sum+k;
		}
		i = i/10;
		
		if(i!=0){
			t = i%10;
			k = t*t*t;
			sum  = sum+k;
		}
		i = i/10;
		
		if(sum == b){
			System.out.println(b);
		}
		sum = 0;
		i = b;
		
		}
	}

}
