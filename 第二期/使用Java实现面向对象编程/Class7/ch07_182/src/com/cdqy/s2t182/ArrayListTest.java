package com.cdqy.s2t182;

import java.util.*;

/**
 * 演示ArrayList集合的使用
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-14 上午11:31:38
 * @version 1.0
 */
public class ArrayListTest {

	public static void main(String[] args) {
		Dog beibei = new Dog("贝贝","京巴");
		Dog heibao = new Dog("黑豹","藏獒");
		Dog wangcai = new Dog("旺财","土狗");
		//创建ArrayList集合
		List list = new ArrayList();
//		ArrayList list = new ArrayList();
		//添加元素
		list.add(beibei);
		list.add(heibao);
		list.add(wangcai);
		list.add(1234);
		System.out.println("一共有"+list.size()+"条狗");
		for(int i= 0;i<list.size();i++){
			Dog dog  =(Dog)list.get(i);
			System.out.println(dog.getName()+"\t"+dog.getStrain());
		}
		//移除对象
		list.remove(0);
		//list.remove(heibao);
		if(list.contains(beibei)){
			System.out.println("含有这条狗");
		}else{
			System.out.println("这条狗被移除了");
		}
		System.out.println("集合的长度"+list.size());
		
		Iterator iter = list.iterator();
		while(iter.hasNext()){
			Dog dog = (Dog)iter.next();
			
		}
		for(Object obj :list){
			Dog dog = (Dog)obj;
		}
	}

}
