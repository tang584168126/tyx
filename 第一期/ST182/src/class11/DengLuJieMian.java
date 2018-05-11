package class11;

import java.util.Scanner;
/**
 * 登陆界面
 * @author fun
 *
 */

public class DengLuJieMian {
	String name;
	String secret;
	int i = 0;
	
	public void show(){
		Scanner sc = new Scanner(System.in);
		System.out.println("【奖客富翁系统 > 登陆】");
		for(i = 0 ; i <= 4 ; i++){
			System.out.println("请输入账号：");
			name = sc.next();
			System.out.println("请输入账号：");
			secret = sc.next();
			if(name.equals("admin") && secret.equals("admin")){
				System.out.println("登陆成功！");
			}else{
				
				System.out.println("请重新登陆！");
				System.out.println("您还有 " + (4-i) + " 次机会！");
					
				if(i == 4){
					System.out.println("输入错误！\n系统退出");
					System.exit(1);
				}
				
			}
				
		}
		
	
	}

}
