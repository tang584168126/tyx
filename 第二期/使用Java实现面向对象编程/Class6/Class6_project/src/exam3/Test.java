package exam3;

import java.util.Scanner;

/**
 * ���������±�����Ӧ��ֵ
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args) {
		int[] num = new int[]{1,2,3};
		
		Scanner input = new Scanner(System.in);
		
		try {
			System.out.println("�����������±꣺");
			int sub = input.nextInt();
			
			System.out.println("�����ֵ��" + num[sub]);
		}catch(ArrayIndexOutOfBoundsException ax){
			System.err.println("�����±�Խ�磡");
			ax.printStackTrace();
		} catch (Exception e) {
			System.err.println("��������");
			e.printStackTrace();
		}
	}
}
