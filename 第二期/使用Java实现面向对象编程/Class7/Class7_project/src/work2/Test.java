package work2;

import java.util.*;
import java.util.Scanner;

public class Test {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		//����HashMap����
		Map<String, String> map = new HashMap<String,String>();
		
		//��HashMap����������
		map.put("С��", "ʨ�ӹ�");
		map.put("����", "����");
		map.put("С��", "����");
		
		System.out.println("������ǳ��У�" + map.keySet());
		System.out.print("����������ǳ�:");
		String name = sc.next();
		
		if(map.containsKey(name)){
			System.out.println(name + "\t" + map.get(name));
		}else{
			System.out.println("û�иó��");
		}
	}
}
