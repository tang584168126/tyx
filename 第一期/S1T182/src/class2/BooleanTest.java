package class2;

import java.util.*;

public class BooleanTest {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//有两个变量需要存储值：张、李 的成绩
		double zhangScore = 0 , liScore = 80 ;
		
		boolean isOk = true;
		
		//做好接收用户输入的准备
		Scanner sc = new Scanner(System.in);

		//给予用户提示
		System.out.println("请输入张三的分数：");
		zhangScore = sc.nextDouble();
		
		//获得 比较的结果
		isOk = zhangScore > liScore ;
		
		System.out.println("张三的分数比李四的分数高吗？");
		System.out.println(isOk);
	}
}


