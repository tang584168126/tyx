package petShop.dao.impl;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import petShop.dao.BaseDao;
import petShop.dao.ShopDao;
import petShop.entity.Shop;

/**
 * �̵�ʵ����
 * @author Administrator
 *
 */
public class ShopDaoImpl extends BaseDao implements ShopDao {

	private Connection conn = null; // �������ݿ�����

	private PreparedStatement pstmt = null; // ����ִ��SQL���

	private ResultSet rs = null; // �û������ѯ�����
	
	@Override
	public List<Shop> getAllStore() {
		// TODO Auto-generated method stub
		List<Shop> storeList = new ArrayList<Shop>();
		try {
		String preparedSql = "select * from petstore ";
		// �õ����ݿ�����
		conn = getConnection();
		 // �õ�PreparedStatement����
		pstmt = conn.prepareStatement(preparedSql);
		 // ִ��SQL���
		rs = pstmt.executeQuery();
			while (rs.next()) {
				Shop shop = new Shop();
				shop.setId(rs.getInt(1));
				shop.setName(rs.getString(2));
				shop.setPassword(rs.getString(3));
				shop.setBalance(rs.getDouble(4));
				storeList.add(shop);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			super.closeAll(conn, pstmt, rs);
		}
		return storeList;
	}

	@Override
	public Shop getPetStore(String sql, String[] param) {
		// TODO Auto-generated method stub
		Shop shop = null;
		try {
		// �õ����ݿ�����
		conn = getConnection(); 
		pstmt = conn.prepareStatement(sql); // �õ�PreparedStatement����
		if (param != null) {
			for (int i = 0; i < param.length; i++) {
				pstmt.setString(i + 1, param[i]); // ΪԤ����sql���ò���
			}
		}
		rs = pstmt.executeQuery(); // ִ��SQL���
			while (rs.next()) {
				shop = new Shop();
				shop.setId(rs.getInt(1));
				shop.setName(rs.getString(2));
				shop.setPassword(rs.getString(3));
				shop.setBalance(rs.getDouble(4));
			}
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			super.closeAll(conn, pstmt, rs);
		}
		return shop;
	}

	@Override
	public int updateStore(String sql, Object[] param) {
		// TODO Auto-generated method stub
		int count = super.executeUpdate(sql, param);
		return count;
	}


}
