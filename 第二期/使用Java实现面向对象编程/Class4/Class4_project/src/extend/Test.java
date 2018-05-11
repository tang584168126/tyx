package extend;

import java.util.Scanner;

/**
 * 测试类
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args){
		double digtA = 0;		//输入的一个数字
		double digtB = 0;
		int choice;			//选择计算符号
		
		Scanner sc = new Scanner(System.in);
		
		Counter counter = new Counter();
		
		System.out.print("请输入数字：");
		digtA = sc.nextDouble();
		
		for(int i = 0; i <10000; i++){

			System.out.print("请选择计算符号(1.+  2.-  3.*  4./  5.=)：");
			choice = sc.nextInt();
			
			switch(choice){
				case 1:
					System.out.print("请输入数字：");
					digtB = sc.nextDouble();
					counter.add(digtA, digtB);
					System.out.println("结果为：" + counter.result);
					break;
				case 2:
					System.out.print("请输入数字：");
					digtB = sc.nextDouble();
					counter.subtract(digtA, digtB);
					System.out.println("结果为：" + counter.result);
					break;
				case 3:
					System.out.print("请输入数字：");
					digtB = sc.nextDouble();
					counter.pursue(digtA, digtB);
					System.out.println("结果为：" + counter.result);
					break;
				case 4:
					System.out.print("请输入数字：");
					digtB = sc.nextDouble();
					counter.remove(digtA, digtB);
					System.out.println("结果为：" + counter.result);
					break;
				case 5:
					counter.result = digtA;
					System.out.println("结果为：" + counter.result);
					break;
				default:
					System.out.println("没有该选项，请重新选择！");
					break;
			}
			
			System.out.print("请输入数字：");
			digtA = sc.nextDouble();
		}
	}
}
