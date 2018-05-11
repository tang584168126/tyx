package com.cdqy.s2t182.entity;
/**
 * 狗狗实体类
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-19 下午4:04:56
 * @version 1.0
 */
public class Dog {
	private int id;
	private String name;
	private int health;
	private int love;
	private String strain;
	
	public String getStrain() {
		return strain;
	}
	public void setStrain(String strain) {
		this.strain = strain;
	}
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getHealth() {
		return health;
	}
	public void setHealth(int health) {
		this.health = health;
	}
	public int getLove() {
		return love;
	}
	public void setLove(int love) {
		this.love = love;
	}
	
	public Dog(int id, String name, int health, int love, String strain) {
		super();
		this.id = id;
		this.name = name;
		this.health = health;
		this.love = love;
		this.strain = strain;
	}
	public Dog() {
		super();
	}
	
	
}
