package class3;

import java.util.Scanner;

/**
 * 描述：什么情况下吃饭？
 * @author fun
 *
 */
public class Test2 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		//声明变量
		String answer = "";	//是否饿了的回答
		double money = 0 ;	//是否有钱的证据
		
		Scanner sc = new Scanner(System.in);
		
		//提问：
		System.out.println("您饿了吗？(Y/N)");
		answer = sc.next();
		
		
		//字符串判断
		if(answer.equals("Y") || answer.equals("y")){
			
			System.out.println("您有多少钱？(请输入金额)");
			money = sc.nextDouble();
			
			//判断金额是否足够吃饭
			if(money >= 10){
				System.out.println("找个小馆子吃饭/面/抄手");
			}
			else{
				System.out.println("借钱吧兄弟！！！");
			}
			
		}
		else{
			System.out.println("不饿就不用吃了！！！");
		}
		
		
		
		
		
		

	}

}
