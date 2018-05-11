package work4;

import java.util.InputMismatchException;
import java.util.Scanner;

import org.apache.log4j.Logger;

public class TestLog2 {
	//创建日志对象
		static Logger logger = Logger.getLogger(TestLog2.class);

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int num1;		//被除数
		int num2;		//除数
		int result;		//结果
		
		Scanner sc = new Scanner(System.in);
		
		try{
			System.out.print("请输入被除数：");
			num1 = sc.nextInt();
			
			System.out.print("请输入除数：");
			num2 = sc.nextInt();
			
			result = num1 / num2;
			
			System.out.println("结果是：" + result);
		}catch(ArithmeticException e){
			logger.warn("除数为零！");
		}catch(InputMismatchException ex){
			logger.error("输入非法");
		}finally{
			System.out.println("感谢使用本程序！");
		}
	}

}
