package petShop.dao.impl;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import petShop.dao.AccountDao;
import petShop.dao.BaseDao;
import petShop.entity.Account;

/**
 * ��Ŀʵ����
 * @author Administrator
 *
 */
public class AccountDaoImpl extends BaseDao implements AccountDao {
	// �������ݿ�����
	private Connection conn = null;
	// ����ִ��SQL���
	private PreparedStatement pstmt = null; 
	// �û������ѯ�����
	private ResultSet rs = null; 
	
	@Override
	public int updateAccount(String sql, Object[] param) {
		// TODO Auto-generated method stub
		int count = super.executeUpdate(sql, param);
		return count;
	}

	@Override
	public List<Account> getPetStoreAccount(String sql, String[] param) {
		// TODO Auto-generated method stub
		List<Account> accountList = new ArrayList<Account>();
		try {
			// �õ����ݿ�����
			conn = getConnection(); 
			// �õ�PreparedStatement����
			pstmt = conn.prepareStatement(sql); 
			if (param != null) {
				for (int i = 0; i < param.length; i++) {
					pstmt.setString(i + 1, param[i]); //���ò���
				}
			}
			// ִ��SQL���
			rs = pstmt.executeQuery(); 
			Account account = null;
			while (rs.next()) {
				account = new Account();
				account.setId(rs.getInt(1));
				account.setDealType(rs.getInt(2));
				account.setPetId(rs.getInt(3));
				account.setSellerId(rs.getInt(4));
				account.setBuyerId(rs.getInt(5));
				account.setPrice(rs.getDouble(6));
				account.setDealTime(rs.getDate(7));
				accountList.add(account);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			super.closeAll(conn, pstmt, rs);
		}
		return accountList;
	}


}
