package exam5;

import java.util.*;

public class Test {
	public static void main(String[] args) {
		String name;	//修改的姓名
		Integer score;	//修改的成绩
		Scanner input = new Scanner(System.in);
		
		//创建HashMap对象
		Map<String, Integer> map = new HashMap<String, Integer>();
		
		//添加
		map.put("张飞", 68);
		map.put("刘备", 89);
		map.put("诸葛亮", 96);
		map.put("孙权", 92);
		
		//获取HashMap的key
		Set<String> keys = map.keySet();
		
		System.out.println("修改前：");
		for(String nameStr: keys){
			Integer scoreInt = map.get(nameStr);
			
			System.out.println(nameStr + "\t" + scoreInt);
		}
		
		//修改成绩
		System.out.println("\n修改成绩中：");
		System.out.println("请输入姓名：");
		name = input.next();
		
		if(map.containsKey(name)){
			System.out.println("请输入成绩：");
			score = input.nextInt();
			
			map.put(name, score);
			
			//修改后
			System.out.println("\n修改后：");
			for(String strName:keys){
				Integer scoreInt = map.get(strName);
				
				System.out.println(strName + "\t" + scoreInt);
			}
			
		}else{
			System.out.println("没有该同学！");
		}
	}
}
