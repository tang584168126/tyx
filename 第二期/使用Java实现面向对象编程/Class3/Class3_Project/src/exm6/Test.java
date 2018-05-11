package exm6;

import java.util.Scanner;

/**
 * 测试类
 * @author Administrator
 *
 */
public class Test {

	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		Person person = new Person("牛犇");
		int index;
		
		System.out.println("(1.中国朋友2.美国朋友)来拜访！");
		index = sc.nextInt();
		Friend friend = person.getFriend(index);
		if(friend != null){
			System.out.println("朋友来了！");
			friend.print();
		}else{
			System.out.println("(1.中国朋友2.美国朋友)来拜访！");
		}
	}
}
