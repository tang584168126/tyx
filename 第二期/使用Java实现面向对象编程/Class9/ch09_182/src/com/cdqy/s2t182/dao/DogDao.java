package com.cdqy.s2t182.dao;

import com.cdqy.s2t182.entity.Dog;

/**
 * dog�ӿ�
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-19 ����4:02:55
 * @version 1.0
 */
public interface DogDao {
	/**
	 * �޸ķ���
	 */
	int update(Dog dog);
	/**
	 * ����
	 */
	int save(Dog dog);
}
