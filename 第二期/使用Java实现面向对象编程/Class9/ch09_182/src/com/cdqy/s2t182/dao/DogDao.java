package com.cdqy.s2t182.dao;

import com.cdqy.s2t182.entity.Dog;

/**
 * dog接口
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-19 下午4:02:55
 * @version 1.0
 */
public interface DogDao {
	/**
	 * 修改方法
	 */
	int update(Dog dog);
	/**
	 * 增加
	 */
	int save(Dog dog);
}
