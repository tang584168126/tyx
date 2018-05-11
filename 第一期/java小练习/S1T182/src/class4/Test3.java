package class4;

import java.util.Scanner;

public class Test3 {

	public static void main(String[] args) {
		
		int num = 0 ;	//用户拨号结果
		Scanner sc = new Scanner(System.in);
		
		System.out.println("1、爸");
		System.out.println("2、妈");
		System.out.println("3、爷");
		System.out.println("4、奶");
		System.out.println("选择拨号按键：");
		
		if(!sc.hasNextInt()){
			System.out.println("您拨打的是空号！");
			System.exit(1);
		}
		
		num = sc.nextInt();
		
		switch(num){
		case 1:
			System.out.println("正在拨打：爸爸的电话......");
			break;
		case 2:
			System.out.println("正在拨打：妈妈的电话......");
			break;
		case 3:
			System.out.println("正在拨打：爷爷的电话......");
			break;
		case 4:
			System.out.println("正在拨打：奶奶的电话......");
			break;
		default:
			System.out.println("请设置该按键！！");
			break;
		}
		
	}
	
}
