package PetShop.dao;

import java.util.List;

import PetShop.entity.Pet;

/**
 * 宠物接口
 * @author Administrator
 *
 */
public interface PetDao {
	/**
	 * 宠物增加
	 */
	int PetAdd(Pet pet);
	
	/**
	 * 宠物修改
	 */
	int PetUpdate(Pet pet);
	
	/**
	 * 宠物删除
	 */
	int PetDelete(Pet pet);
	
	/**
	 * 宠物查询
	 */
	 List<Pet> select();
}
