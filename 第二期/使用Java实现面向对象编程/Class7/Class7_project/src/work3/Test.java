package work3;

import java.util.*;

import work1.Penguin;

public class Test {
	public static void main(String[] args) {
		//����HashMap����
		Map<String, String> map = new HashMap<String,String>();
		
		map.put("ѩ��","Q��");
		map.put("С��", "Q��");
		map.put("����", "Q��");
		
		//������
		System.out.println("�����" + map.size() + "ֻ");
		
		//ȡ��MapHash��key
		Set keys = map.keySet();
		
		//����Iterator����
		Iterator ite = keys.iterator();
		while(ite.hasNext()){
			String name =(String)ite.next();
			
			String sex = map.get(name);
			
			System.out.println(name + "\t" +sex);
		}
	}
}
