
public class ��ȫƽ���� {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//��ȫƽ������3*3 =9   ��ô9��3����ȫƽ��������
		int a ;
		int b ;
		int c;
		int d;
		int e;
		
		for(a = 1;a<10000;a++){
			for(b = 1;b<10000;b++){
				for(e = 0; e<10000;e++){
			c = a*a;
			d = b*b;
			if(e+100 == c && e+100+168 == d){
				System.out.println("�������:"+e);
				
			}
		}
		}
		}

	}

}
