package work2;

import java.util.Scanner;

/**
 * 测试类
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		
		Master master = new Master("小王",100);
		
		System.out.println("请选择玩耍的宠物：(1.狗狗 2.企鹅)");
		int index = sc.nextInt();
		Pet pet = master.getPet(index);
		if(pet != null){
			System.out.println("选择宠物成功！");
			master.play(pet);
		}else{
			System.out.println("没有这只宠物！");
		}
	}
}
