package petShop.dao;

import java.util.List;

import petShop.entity.Master;


/**
 * 主人：接口
 * @author Administrator
 *
 */
public interface MasterDao {
	
	/**
	 * 查询所有宠物主人信息
	 */
	public abstract List<Master> getAllOwner();

	/**
	 * 更新宠物主人信息
	 */
	public abstract int updateOwner(String sql, String[] param);

	/**
	 * 根据查询条件查询宠物主人信息
	 */
	public abstract Master selectOwner(String sql, String[] param);

}
