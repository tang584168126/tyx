package class15_1;

import java.util.Scanner;

/**
 * �������û������ʣ�ÿ��ʹ�� �ո� �ָ�
 * ���ǽ��û�����ĸ��ʹ�� split()���в��
 * @author fun
 *
 */
public class Test3 {

	public static void main(String[] args) {
		//��ͤ�� �ŵ��� ���ݱ����� ������������ Ϧ��ɽ��ɽ
		String gc = "";
		String[] gcs ;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("�������ʣ��� ÿ���Կո������");
		
		//next() ��Ϊ���ո� �� �س�����ʾ�������
		//gc = sc.next(); 
		
		//nextLine() ��Ϊ���س� �ű�ʾ�������
		gc = sc.nextLine();
		
		System.out.println("===============================");
		
		System.out.println("ԭ���Ϊ��" + gc);
		
		System.out.println("===============================");		
		
		//�Ը�ʽ��в�֣�����ʲ��Ϊһ���ַ�������
		gcs = gc.split(" ");
		
		//��ӡ��ֺ�Ľ��
		System.out.println("��ֺ󣬸��Ϊ��");
		
		for(int i = 0 ; i < gcs.length ; i++){
			System.out.println(gcs[i]);
		}
		
		System.out.println("===========================");
		
		System.out.println("�� split()�и����ַ�������ƴ�ӻ� String : ");
		
		gc = "";
		
		//���ַ��������е�ÿһ��Ԫ������ ƴ�ӳ�һ�� �ַ���
		for(int i = 0 ; i < gcs.length ; i++){
			
			gc += gcs[i] + "_";
			
		}
		
		//ȥ�����һ��������ַ� _
		gc = gc.substring(0,gc.length() - 1);
		
		
		System.out.println(gc);
	}
}





