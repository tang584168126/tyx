package class2;

import java.util.*;

public class BooleanTest {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//������������Ҫ�洢ֵ���š��� �ĳɼ�
		double zhangScore = 0 , liScore = 80 ;
		
		boolean isOk = true;
		
		//���ý����û������׼��
		Scanner sc = new Scanner(System.in);

		//�����û���ʾ
		System.out.println("�����������ķ�����");
		zhangScore = sc.nextDouble();
		
		//��� �ȽϵĽ��
		isOk = zhangScore > liScore ;
		
		System.out.println("�����ķ��������ĵķ�������");
		System.out.println(isOk);
	}
}


