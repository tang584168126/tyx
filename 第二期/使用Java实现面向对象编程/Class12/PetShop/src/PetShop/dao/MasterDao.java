package PetShop.dao;

import java.util.List;

import PetShop.entity.Master;

/**
 * 主人接口
 * @author Administrator
 *
 */
public interface MasterDao {
	/**
	 * 主人登录
	 */
	Master MasterQuery(Master master);
	
	/**
	 * 主人增加
	 */
	int MasterAdd(Master master);
	
	/**
	 * 主人修改
	 */
	int MasterUpdate(Master master);
	// 查询宠物主人信息
	List<Master> getPetOwner();
}
