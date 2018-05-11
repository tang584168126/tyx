package work3;

import java.util.InputMismatchException;
import java.util.Scanner;
import org.apache.log4j.Logger;

public class TestLog1 {
	//������־�ļ�����
	static Logger logger = Logger.getLogger(TestLog1.class);
	public static void main(String[] args) {
		int num1;		//������
		int num2;		//����
		int result;		//���
		
		Scanner sc = new Scanner(System.in);
		
		try{
			System.out.print("�����뱻������");
			num1 = sc.nextInt();
			
			System.out.print("�����������");
			num2 = sc.nextInt();
			
			result = num1 / num2;
			
			System.out.println("����ǣ�" + result);
		}catch(ArithmeticException e){
			logger.debug("����Ϊ�㣡");
		}catch(InputMismatchException ex){
			logger.debug("����Ƿ�");
		}finally{
			System.out.println("��лʹ�ñ�����");
		}
	}
}
