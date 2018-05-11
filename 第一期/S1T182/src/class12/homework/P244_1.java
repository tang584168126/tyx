package class12.homework;

import java.util.Scanner;

/**
 * 根据输入的月份，判断季节
 * 使用方法定义四个季节
 * @author fun
 *
 */
public class P244_1 {

	int month ;	//月份
	
	/**
	 * 一个方法判断四季
	 */
	public void 四季(){
		
		switch(month){
		case 3:
		case 4:
		case 5:
			System.out.println("春季");
			break;
		case 6:
		case 7:
		case 8:
			System.out.println("夏季");
			break;
		case 9:
		case 10:
		case 11:
			System.out.println("秋季");
			break;
		case 12:
		case 1:
		case 2:
			System.out.println("冬季");
			break;
		default:
			System.out.println("请输入正确的月份！！！");
			break;
		}
		
		
	}
	
	
	/**
	 * 测试季节
	 * @param args
	 */
	public static void main(String[] args) {
		
		P244_1 p = new P244_1();
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("请输入月份：");
		p.month = sc.nextInt();
		
		p.四季();
		

	}

}
