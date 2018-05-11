package PetShop.dao;

import PetShop.entity.DealTable;

/**
 * 交易记录接口
 * @author Administrator
 *
 */
public interface DealTableDao {
	/**
	 * 交易记录查询
	 */
	DealTable DealTableQuery(DealTable dlt);
	/**
	 * 交易记录增加
	 */
	int DealTableAdd(DealTable dlt);
}
