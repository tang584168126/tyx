package exam5;

import java.util.Scanner;
import org.apache.log4j.Logger;

/**
 * ���������±�����Ӧ��ֵ
 * @author Administrator
 *
 */
public class Test {
	//������־����
	static Logger logger = Logger.getLogger(Test.class);
	public static void main(String[] args) {
		int[] num = new int[]{1,2,3};
		
		Scanner input = new Scanner(System.in);
		
		try {
			System.out.println("�����������±꣺");
			int sub = input.nextInt();
			
			System.out.println("�����ֵ��" + num[sub]);
		}catch(ArrayIndexOutOfBoundsException ax){
			logger.error("�����±�Խ��");
		} catch (Exception e) {
			logger.error("��������");
		}finally{
			System.out.println("���������");
		}
	}
}
