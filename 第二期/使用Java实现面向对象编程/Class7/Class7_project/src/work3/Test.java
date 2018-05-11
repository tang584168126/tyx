package work3;

import java.util.*;

import work1.Penguin;

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
		Set keys = map.keySet();
		
		//创建Iterator对象
		Iterator ite = keys.iterator();
		while(ite.hasNext()){
			String name =(String)ite.next();
			
			String sex = map.get(name);
			
			System.out.println(name + "\t" +sex);
		}
	}
}
