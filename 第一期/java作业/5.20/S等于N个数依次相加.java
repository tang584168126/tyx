import java.util.Scanner;
/*
 * 
 */
public class S����N����������� {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int sum = 0;//��ʱװa��ֵ
		int cs = 0;//Ҫ��ӡ�Ĵ���
		int a = 0;//�������
		int z = 0;//ѭ������
		int p = 0;//��ʱװa��ֵ
		
		Scanner sc = new Scanner(System.in);
		System.out.println("������һ������");
		a = sc.nextInt();
		sum = a;
		System.out.println("��������Ӵ���1~9");
		cs = sc.nextInt();
		
		//ѭ������ ʹp(a) ��ֵ�ۼ�
		for (z = 0; z < cs; z++) {
			p = a;
			System.out.print(p);
			//����"+"�����
			if (z < (cs - 1)) {
				System.out.print("+");
			}
			a = a * 10 + sum;//���� a��ֵ�ۼ� 5=5*10+5 =55
		}
	}
}
