package PetShop.dao;

import PetShop.entity.DealTable;

/**
 * ���׼�¼�ӿ�
 * @author Administrator
 *
 */
public interface DealTableDao {
	/**
	 * ���׼�¼��ѯ
	 */
	DealTable DealTableQuery(DealTable dlt);
	/**
	 * ���׼�¼����
	 */
	int DealTableAdd(DealTable dlt);
}
