package class9;

import java.util.Scanner;

public class Test5 {
	public static void main(String[] args){
		int i = 0 ;
		int j = 0 ;
		int pw = 0 ;			//密码
		double money = 0;
		Scanner sc = new Scanner(System.in);
		for(i = 0 ; i <= 3 ; i++){
			System.out.print("请输入密码：");
			pw = sc.nextInt();
			if(pw == 111111){
				for(j = 0 ; ; j++){
					System.out.print("请输入金额：");
					money = sc.nextDouble();
					if(money >= 0 && money <= 1000 && (money % 100 == 0)){
						System.out.println("您取了：" + money);
						System.out.println("交易完成，请取卡");
						System.exit(1);
					}else{
						System.out.println("您输入的金额不合法，请重新输入：");
						
					}
				}
			} if( i == 2 ){
				System.out.println("密码错误，请取卡");
				break;
			}
		}
	}

}
