package petShop.dao;
import java.util.List;

import petShop.entity.Account;

/**
 * 账目：接口
 * @author Administrator
 *
 */
public interface AccountDao {
	
	/**
	 * 更新账目
	 * @param account
	 * @return
	 */
	public abstract int updateAccount(String sql, Object[] param);
	
	/**
	 * 查询账目
	 * @param account
	 * @return
	 */
	public abstract List<Account> getPetStoreAccount(String sql, String[] param);


}
