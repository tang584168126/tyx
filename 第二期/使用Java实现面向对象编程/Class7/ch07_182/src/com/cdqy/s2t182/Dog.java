package com.cdqy.s2t182;
/**
 * ������
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-14 ����11:32:01
 * @version 1.0
 */
public class Dog {

	//�ǳ�
	private String name;
	//Ʒ��
	private String strain;
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getStrain() {
		return strain;
	}
	public void setStrain(String strain) {
		this.strain = strain;
	}
	public Dog(String name, String strain) {
		super();
		this.name = name;
		this.strain = strain;
	}
	

}
