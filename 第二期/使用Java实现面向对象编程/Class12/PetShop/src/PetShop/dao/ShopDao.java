package PetShop.dao;

import java.util.List;

import PetShop.entity.Shop;

/**
 * �����̵�ӿ�
 * @author Administrator
 *
 */
public interface ShopDao {
	/**
	 * �̵��¼
	 */
	Shop ShopQuery(Shop shop);
	
	/**
	 * �̵�����
	 */
	int ShopAdd(Shop shop);
	
	/**
	 * �̵��޸�
	 */
	int ShopUpdate(Shop shop);

	/**
	 * ��ѯ
	 * @param id1 
	 * @return
	 */
	List<Shop> getShop();
}
