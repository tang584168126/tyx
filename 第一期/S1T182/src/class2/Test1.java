package class2;

import java.util.Scanner;

public class Test1 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//���ý����û��������ݵ�׼��
		Scanner sc = new Scanner(System.in);
		
		//����һ��������������ʾ�û��浽���еĴ����
		int bankMoney = 0 ;
		
		//�ڽ����û���������֮ǰ һ��Ҫ�����û���ʾ
		System.out.println("���������");
		
		//�����û�����Ľ��
		bankMoney = sc.nextInt();
		

		System.out.print("���Ѵ��룺" + bankMoney + " Ԫ");
	}

}
