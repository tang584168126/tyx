package com.cdqy.s2t182;

import java.util.*;

/**
 * ��ʾArrayList���ϵ�ʹ��
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-14 ����11:31:38
 * @version 1.0
 */
public class ArrayListTest {

	public static void main(String[] args) {
		Dog beibei = new Dog("����","����");
		Dog heibao = new Dog("�ڱ�","����");
		Dog wangcai = new Dog("����","����");
		//����ArrayList����
		List list = new ArrayList();
//		ArrayList list = new ArrayList();
		//���Ԫ��
		list.add(beibei);
		list.add(heibao);
		list.add(wangcai);
		list.add(1234);
		System.out.println("һ����"+list.size()+"����");
		for(int i= 0;i<list.size();i++){
			Dog dog  =(Dog)list.get(i);
			System.out.println(dog.getName()+"\t"+dog.getStrain());
		}
		//�Ƴ�����
		list.remove(0);
		//list.remove(heibao);
		if(list.contains(beibei)){
			System.out.println("����������");
		}else{
			System.out.println("���������Ƴ���");
		}
		System.out.println("���ϵĳ���"+list.size());
		
		Iterator iter = list.iterator();
		while(iter.hasNext()){
			Dog dog = (Dog)iter.next();
			
		}
		for(Object obj :list){
			Dog dog = (Dog)obj;
		}
	}

}
