package work1;

import java.util.*;

/**
 * ������
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args) {
		//����������
		Penguin xueBing = new Penguin("ѩ��","Q��");
		Penguin xiaoBai = new Penguin("С��", "Q��");
		Penguin wangCai = new Penguin("����", "Q��");
		
		//����ArrayList����
		List<Penguin> list = new ArrayList<Penguin>(); 
		
		list.add(xueBing);
		list.add(xiaoBai);
		list.add(1,wangCai);
		
		//��������Ŀ
		System.out.println("�����" + list.size() + "ֻ");
		
		//ѭ��������
		for(int i = 0; i < list.size(); i++){
			Penguin pen = list.get(i);
			System.out.println(pen.getName() + "\t" + pen.getSex());
		}
		
		//ɾ���±�Ϊ1�����
		Penguin pen1 = list.get(1);
		System.out.println("�±�Ϊ1�����Ϊ��" + pen1.getName());
		list.remove(1);
		
		//�ж��Ƿ��и����
		if(list.contains(1)){
			System.out.println("���и���죡");
		}else{
			System.out.println("û�и���죡");
		}
	}

}
