package com.cdqy.s2t182;

import java.io.Serializable;
/**
 * ѧ����
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-23 
 * @version 1.0
 */
 
public class Student implements Serializable {
	/**
	 * ѧ��������к�
	 */
	private static final long serialVersionUID = -4603573052083146598L;
	private String name;
	private int age;
	public Student(String name, int age) {
		this.name = name;
		this.age = age;
	}
	public int getAge() {
		return age;
	}

	public String getName() {
		return name;
	}
}
