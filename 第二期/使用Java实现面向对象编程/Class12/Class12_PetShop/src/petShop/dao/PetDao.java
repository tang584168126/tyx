package petShop.dao;

import java.util.List;

import petShop.entity.Pet;

/**
 * 宠物：接口
 * @author Administrator
 *
 */
public interface PetDao {
	
	/**
	 * 新增宠物
	 */
	public abstract int getaddpet(String sql, Object[] param);
	
	/**
	 * 查询所有宠物信息
	 */
	public abstract List<Pet> getAllPet();
	
	/**
	 * 更新宠物信息
	 */
	public abstract int updatePet(String sql, Object[] param);
}
