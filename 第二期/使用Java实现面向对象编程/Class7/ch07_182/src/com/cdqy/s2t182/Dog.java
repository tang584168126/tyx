package com.cdqy.s2t182;
/**
 * 狗狗类
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-14 上午11:32:01
 * @version 1.0
 */
public class Dog {

	//昵称
	private String name;
	//品种
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
