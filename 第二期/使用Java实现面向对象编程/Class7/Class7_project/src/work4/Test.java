package work4;

import java.util.*;
import java.util.jar.Attributes.Name;

public class Test {
	public static void main(String[] args) {
		//创建HashMap对象
		Map<String, String> map = new HashMap<String,String>();
				
		map.put("雪饼","Q仔");
		map.put("小白", "Q妹");
		map.put("旺财", "Q仔");
				
		//企鹅个数
		System.out.println("企鹅有" + map.size() + "只");
		
		//取出MapHash的key
		Set<String> keys = map.keySet();
		
		//遍历
		for(String name:keys){
			//企鹅昵称对应的性别
			String sex = map.get(name);
			
			System.out.println(name + "\t" + sex);
		}
	}
}
