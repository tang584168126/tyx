package work4;

import java.util.InputMismatchException;
import java.util.Scanner;

import org.apache.log4j.Logger;

public class TestLog2 {
	//������־����
		static Logger logger = Logger.getLogger(TestLog2.class);

	/**
	 * @param args
	 */
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
			logger.warn("����Ϊ�㣡");
		}catch(InputMismatchException ex){
			logger.error("����Ƿ�");
		}finally{
			System.out.println("��лʹ�ñ�����");
		}
	}

}
