package exam5;

import java.util.Scanner;
import org.apache.log4j.Logger;

/**
 * 查找数组下标所对应的值
 * @author Administrator
 *
 */
public class Test {
	//创建日志对象
	static Logger logger = Logger.getLogger(Test.class);
	public static void main(String[] args) {
		int[] num = new int[]{1,2,3};
		
		Scanner input = new Scanner(System.in);
		
		try {
			System.out.println("请输入数组下标：");
			int sub = input.nextInt();
			
			System.out.println("数组的值：" + num[sub]);
		}catch(ArrayIndexOutOfBoundsException ax){
			logger.error("数组下标越界");
		} catch (Exception e) {
			logger.error("其他错误！");
		}finally{
			System.out.println("程序结束！");
		}
	}
}
