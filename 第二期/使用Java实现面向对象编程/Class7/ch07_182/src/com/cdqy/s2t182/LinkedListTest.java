package com.cdqy.s2t182;

import java.util.*;

/**
 * ��ʾLinkedList��ʹ��
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-14 ����11:52:07
 * @version 1.0
 */
public class LinkedListTest {

	public static void main(String[] args) {
		Dog beibei = new Dog("����","����");
		Dog heibao = new Dog("�ڱ�","����");
		Dog wangcai = new Dog("����","����");
		//����LinkedList����
		LinkedList list = new LinkedList();
		list.add(beibei);
		list.addFirst(heibao);
		list.addLast(wangcai);
		for(int i=0;i<list.size();i++){
			Dog dog = (Dog)list.get(i);
			System.out.println(dog.getName()+"\t"+dog.getStrain());
		}
		//��ȡ��һ��Ԫ��
		Dog dog1 = (Dog)list.getFirst();
		System.out.println("��һ������"+dog1.getName());
		//��ȡ���һ����
		Dog dogLast = (Dog)list.getLast();
		System.out.println("���һ������"+dogLast.getName());
		//�Ƴ���һ����
		//list.remove(0);
		list.removeFirst();
		list.removeLast();
		System.out.println("��ʣ��:"+list.size()+"����");
		
	}

}
