
public class ��������� {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		double a = 2.0;		//��������a�ĳ�ʼֵ  ���Ժ󴢴�a���ۼ�ֵ
		double a1 = 1;		//������ʱ����a���ۼ�ֵ ֮��������ֵ��B
		double b = 1.0;		//��������b�ĳ�ʼֵ  ���Ժ󴢴�b���ۼ�ֵ
		double c = 0;		//��������a/b�ۼ�ֵ����
		double d = 0;		//ѭ������
		double sum = 0;		//����a/b�ۼӵĺ�
		for(d = 0; d<20;d++){//ѭ���Ƴ�������20���ڵ���
			c = a/b;
			sum = sum + c;
			System.out.printf("%5.0f/%-5.0f=%.5f\n",a,b,sum);//ռλ���������
			a1 = a;			//ʵ��a/b ���¸�����ֵ��ת��
			a = a+b;
			b = a1;				
		}
		
	}

}
