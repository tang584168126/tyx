package PetShop.dao;

import java.util.List;

import PetShop.entity.Shop;

/**
 * 宠物商店接口
 * @author Administrator
 *
 */
public interface ShopDao {
	/**
	 * 商店登录
	 */
	Shop ShopQuery(Shop shop);
	
	/**
	 * 商店增加
	 */
	int ShopAdd(Shop shop);
	
	/**
	 * 商店修改
	 */
	int ShopUpdate(Shop shop);

	/**
	 * 查询
	 * @param id1 
	 * @return
	 */
	List<Shop> getShop();
}
