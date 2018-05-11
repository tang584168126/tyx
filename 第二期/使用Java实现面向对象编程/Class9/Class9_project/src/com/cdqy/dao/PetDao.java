package com.cdqy.dao;


/**
 * 宠物：接口
 * @author Administrator
 *
 */
public interface PetDao {
	/**
	 * 获取宠物类型
	 */
	void strain();
	
	/**
	 * 检验宠物类型与主人之间的关系
	 */
	void type(String type);
	
	/**
	 * 新增宠物
	 */
	int add(String name);
}
