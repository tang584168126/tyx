/**
 * 
 */
package cn.jbit.epetShop.dao.impl;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import cn.jbit.epetShop.dao.BaseDao;
import cn.jbit.epetShop.dao.PetStoreDao;
import cn.jbit.epetShop.entity.PetStore;

/**
 * @author �������� �����̵����ݿ������
 */
public class PetStoreDaoImpl extends BaseDao implements PetStoreDao {
	private Connection conn = null; // �������ݿ�����

	private PreparedStatement pstmt = null; // ����ִ��SQL���

	private ResultSet rs = null; // �û������ѯ�����

	/* (non-Javadoc)
	 * @see cn.jbit.epetShop.dao.impl.PetStoreDao#getAllStore()
	 */
	public List<PetStore> getAllStore() {
		List<PetStore> storeList = new ArrayList<PetStore>();
		try {
		String preparedSql = "select * from petstore ";
		conn = getConnection(); // �õ����ݿ�����
		pstmt = conn.prepareStatement(preparedSql); // �õ�PreparedStatement����
		rs = pstmt.executeQuery(); // ִ��SQL���
			while (rs.next()) {
				PetStore petStore = new PetStore();
				petStore.setId(rs.getInt(1));
				petStore.setName(rs.getString(2));
				petStore.setPassword(rs.getString(3));
				petStore.setBalance(rs.getDouble(4));
				storeList.add(petStore);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			super.closeAll(conn, pstmt, rs);
		}
		return storeList;
	}

	/* (non-Javadoc)
	 * @see cn.jbit.epetShop.dao.impl.PetStoreDao#getPetStore(java.lang.String, java.lang.String[])
	 */
	public PetStore getPetStore(String sql, String[] param) {

		PetStore petStore = null;
		try {
		conn = getConnection(); // �õ����ݿ�����
		pstmt = conn.prepareStatement(sql); // �õ�PreparedStatement����
		if (param != null) {
			for (int i = 0; i < param.length; i++) {
				pstmt.setString(i + 1, param[i]); // ΪԤ����sql���ò���
			}
		}
		rs = pstmt.executeQuery(); // ִ��SQL���
			while (rs.next()) {
				petStore = new PetStore();
				petStore.setId(rs.getInt(1));
				petStore.setName(rs.getString(2));
				petStore.setPassword(rs.getString(3));
				petStore.setBalance(rs.getDouble(4));
			}
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			super.closeAll(conn, pstmt, rs);
		}
		return petStore;
	}

	/* (non-Javadoc)
	 * @see cn.jbit.epetShop.dao.impl.PetStoreDao#updateStore(java.lang.String, java.lang.Object[])
	 */
	public int updateStore(String sql, Object[] param) {
		int count = super.executeSQL(sql, param);
		return count;
	}

}
