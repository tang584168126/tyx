import java.util.Scanner;


public class �����������������ӡ {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int a = 0;//�����û��������ֵ  �����м���
		int b = 0;//�����a��λ��ȡĤ��ֵ
		int i = 0;//ѭ������  ��������һ����λ��
		int e = 0;
		int q = 0;
		int u = 0;
		Scanner sc = new Scanner(System.in);
		
		System.out.println("������һ����");
		a = sc.nextInt();
		e = a;
		for(u = 0;e!=0;u++){
			q = e%10;
			e = e/10;
	}
		System.out.println("����һ��" + u + "λ��");
		
		for(i = 0;a!=0;i++){
			b = a%10;
			System.out.print(b);//�����д�ӡ
			a = a/10;
	}
		
	}	

}
