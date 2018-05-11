package petShop.dao;

import java.util.List;

import petShop.entity.Shop;


/**
 * �̵꣺�ӿ�
 * @author Administrator
 *
 */
public interface ShopDao {
	
	/**
	 * ��ѯ�����г����̵�
	 */
	public abstract List<Shop> getAllStore();

	/**
	 * ���ݲ�ѯ������ѯ�������̵�
	 */
	public abstract Shop getPetStore(String sql, String[] param);

	/**
	 * ���³����̵���Ϣ
	 */
	public abstract int updateStore(String sql, Object[] param);

	
	
}
