package exam3;

import java.util.Scanner;

/**
 * 查找数组下标所对应的值
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args) {
		int[] num = new int[]{1,2,3};
		
		Scanner input = new Scanner(System.in);
		
		try {
			System.out.println("请输入数组下标：");
			int sub = input.nextInt();
			
			System.out.println("数组的值：" + num[sub]);
		}catch(ArrayIndexOutOfBoundsException ax){
			System.err.println("数组下标越界！");
			ax.printStackTrace();
		} catch (Exception e) {
			System.err.println("其他错误！");
			e.printStackTrace();
		}
	}
}
