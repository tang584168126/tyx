package petShop.dao;
import java.util.List;

import petShop.entity.Account;

/**
 * ��Ŀ���ӿ�
 * @author Administrator
 *
 */
public interface AccountDao {
	
	/**
	 * ������Ŀ
	 * @param account
	 * @return
	 */
	public abstract int updateAccount(String sql, Object[] param);
	
	/**
	 * ��ѯ��Ŀ
	 * @param account
	 * @return
	 */
	public abstract List<Account> getPetStoreAccount(String sql, String[] param);


}
