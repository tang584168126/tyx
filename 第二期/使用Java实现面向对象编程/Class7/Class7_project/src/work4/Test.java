package work4;

import java.util.*;
import java.util.jar.Attributes.Name;

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
		Set<String> keys = map.keySet();
		
		//����
		for(String name:keys){
			//����ǳƶ�Ӧ���Ա�
			String sex = map.get(name);
			
			System.out.println(name + "\t" + sex);
		}
	}
}
