package com.cdqy.entity;
/**
 * ������
 * @author Administrator
 *
 */
/**
 * @author Administrator
 *
 */
public class Pet {
	private int type_id ;		//��������id
	private String name;	//�ǳ�
	public Pet(int type_id, String name) {
		super();
		this.type_id = type_id;
		this.name = name;
	}
	public int getType_id() {
		return type_id;
	}
	public void setType_id(int type_id) {
		this.type_id = type_id;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}

}
