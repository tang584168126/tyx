package class4;

import java.util.Scanner;

/**
 * 描述：用户输入月份，程序输出月份对应天数
 * @author fun
 *
 */
public class Test4 {

	public static void main(String[] args) {
		
		int year = 0 , month = 0 , day = 0 ;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入年份：");
		year = sc.nextInt();
		
		System.out.println("请输入月份：");
		month = sc.nextInt();
		
		switch(month){
		case 1:
		case 3:
		case 5:
		case 7:
		case 8:
		case 10:
		case 12:
			day = 31 ;
			break;
		case 2:
			//闰平年问题
			
			//如果 一个年份 能够被 4 整除的同时不能被100整除
			//或者 能够被 400 整除
			//符合以上条件的年份即为：闰年
			if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0){
				day = 29 ;
			}
			else{
				day = 28 ;
			}
			
			break;
		default:
			day = 30 ;
			break;
		}
		
		System.out.println(year + "年" + month + "月有：" + day + "天");
	}
	
}
