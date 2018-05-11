package work2;

import java.util.*;
import java.util.Scanner;

public class Test {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		//创建HashMap对象
		Map<String, String> map = new HashMap<String,String>();
		
		//在HashMap中增加数据
		map.put("小白", "狮子狗");
		map.put("旺财", "土狗");
		map.put("小黑", "藏獒");
		
		System.out.println("宠物的昵称有：" + map.keySet());
		System.out.print("请输入宠物昵称:");
		String name = sc.next();
		
		if(map.containsKey(name)){
			System.out.println(name + "\t" + map.get(name));
		}else{
			System.out.println("没有该宠物！");
		}
	}
}
