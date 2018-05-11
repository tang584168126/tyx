package com.cdqy.s2t182;

import java.util.*;

/**
 * 演示LinkedList的使用
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-14 上午11:52:07
 * @version 1.0
 */
public class LinkedListTest {

	public static void main(String[] args) {
		Dog beibei = new Dog("贝贝","京巴");
		Dog heibao = new Dog("黑豹","藏獒");
		Dog wangcai = new Dog("旺财","土狗");
		//创建LinkedList对象
		LinkedList list = new LinkedList();
		list.add(beibei);
		list.addFirst(heibao);
		list.addLast(wangcai);
		for(int i=0;i<list.size();i++){
			Dog dog = (Dog)list.get(i);
			System.out.println(dog.getName()+"\t"+dog.getStrain());
		}
		//获取第一个元素
		Dog dog1 = (Dog)list.getFirst();
		System.out.println("第一条狗名"+dog1.getName());
		//获取最后一条狗
		Dog dogLast = (Dog)list.getLast();
		System.out.println("最后一条狗名"+dogLast.getName());
		//移除第一条狗
		//list.remove(0);
		list.removeFirst();
		list.removeLast();
		System.out.println("还剩下:"+list.size()+"条狗");
		
	}

}
