package com.cdqy.s2t182;

import java.util.*;

/**
 * 演示HashMap的使用
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-14 下午12:08:55
 * @version 1.0
 */
public class HashMapTest {

	public static void main(String[] args) {
		//创建HashMap对象
		Map map = new HashMap();
		map.put("CN","中国");
		map.put("RU", "俄罗斯");
		map.put("JP", "日本");
		/*System.out.println("集合的长度:"+map.size());
		//获取元素
		String country = (String)map.get("CN");
		System.out.println("CN代表:"+country);
		//移除
		map.remove("JP");
		System.out.println("集合的长度:"+map.size());
		//获取key的集合
		Set keys = map.keySet();
		//获取value的集合
		Collection values = map.values();
		System.out.println("键的集合:"+keys);
		System.out.println("值的集合:"+values);*/
		//获取key的集合
		Set keys = map.keySet();
		//获取value的集合
		Collection values = map.values();
		
		//迭代器,迭代key的集合
		Iterator iter = map.keySet().iterator();
		while(iter.hasNext()){
			String key = (String)iter.next();
			System.out.println(key);
		}
		System.out.println("==========================");
		//迭代器,迭代value的集合
		Iterator iterVal = map.values().iterator();
		while(iterVal.hasNext()){
			String val = (String)iterVal.next();
			System.out.println(val);
		}
		System.out.println("使用for循环");
		for(Object obj : map.keySet()){
			String str = (String)obj;
			System.out.println(str);
		}
		
		
		
	}

}
