package exam5;

import java.util.*;

public class Test {
	public static void main(String[] args) {
		String name;	//�޸ĵ�����
		Integer score;	//�޸ĵĳɼ�
		Scanner input = new Scanner(System.in);
		
		//����HashMap����
		Map<String, Integer> map = new HashMap<String, Integer>();
		
		//���
		map.put("�ŷ�", 68);
		map.put("����", 89);
		map.put("�����", 96);
		map.put("��Ȩ", 92);
		
		//��ȡHashMap��key
		Set<String> keys = map.keySet();
		
		System.out.println("�޸�ǰ��");
		for(String nameStr: keys){
			Integer scoreInt = map.get(nameStr);
			
			System.out.println(nameStr + "\t" + scoreInt);
		}
		
		//�޸ĳɼ�
		System.out.println("\n�޸ĳɼ��У�");
		System.out.println("������������");
		name = input.next();
		
		if(map.containsKey(name)){
			System.out.println("������ɼ���");
			score = input.nextInt();
			
			map.put(name, score);
			
			//�޸ĺ�
			System.out.println("\n�޸ĺ�");
			for(String strName:keys){
				Integer scoreInt = map.get(strName);
				
				System.out.println(strName + "\t" + scoreInt);
			}
			
		}else{
			System.out.println("û�и�ͬѧ��");
		}
	}
}
