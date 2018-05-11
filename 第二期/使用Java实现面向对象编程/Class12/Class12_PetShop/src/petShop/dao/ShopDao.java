package petShop.dao;

import java.util.List;

import petShop.entity.Shop;


/**
 * 商店：接口
 * @author Administrator
 *
 */
public interface ShopDao {
	
	/**
	 * 查询出所有宠物商店
	 */
	public abstract List<Shop> getAllStore();

	/**
	 * 根据查询条件查询出宠物商店
	 */
	public abstract Shop getPetStore(String sql, String[] param);

	/**
	 * 更新宠物商店信息
	 */
	public abstract int updateStore(String sql, Object[] param);

	
	
}
