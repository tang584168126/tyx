package com.cdqy.s2t182;

import java.util.*;

/**
 * ��ʾHashMap��ʹ��
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-14 ����12:08:55
 * @version 1.0
 */
public class HashMapTest {

	public static void main(String[] args) {
		//����HashMap����
		Map map = new HashMap();
		map.put("CN","�й�");
		map.put("RU", "����˹");
		map.put("JP", "�ձ�");
		/*System.out.println("���ϵĳ���:"+map.size());
		//��ȡԪ��
		String country = (String)map.get("CN");
		System.out.println("CN����:"+country);
		//�Ƴ�
		map.remove("JP");
		System.out.println("���ϵĳ���:"+map.size());
		//��ȡkey�ļ���
		Set keys = map.keySet();
		//��ȡvalue�ļ���
		Collection values = map.values();
		System.out.println("���ļ���:"+keys);
		System.out.println("ֵ�ļ���:"+values);*/
		//��ȡkey�ļ���
		Set keys = map.keySet();
		//��ȡvalue�ļ���
		Collection values = map.values();
		
		//������,����key�ļ���
		Iterator iter = map.keySet().iterator();
		while(iter.hasNext()){
			String key = (String)iter.next();
			System.out.println(key);
		}
		System.out.println("==========================");
		//������,����value�ļ���
		Iterator iterVal = map.values().iterator();
		while(iterVal.hasNext()){
			String val = (String)iterVal.next();
			System.out.println(val);
		}
		System.out.println("ʹ��forѭ��");
		for(Object obj : map.keySet()){
			String str = (String)obj;
			System.out.println(str);
		}
		
		
		
	}

}
