package com.cdqy.dao;


/**
 * ����ӿ�
 * @author Administrator
 *
 */
public interface PetDao {
	/**
	 * ��ȡ��������
	 */
	void strain();
	
	/**
	 * �����������������֮��Ĺ�ϵ
	 */
	void type(String type);
	
	/**
	 * ��������
	 */
	int add(String name);
}
