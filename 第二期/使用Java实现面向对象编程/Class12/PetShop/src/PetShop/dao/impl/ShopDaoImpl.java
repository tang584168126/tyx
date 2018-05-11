package PetShop.dao.impl;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import PetShop.dao.BaseDao;
import PetShop.dao.ShopDao;
import PetShop.entity.Shop;

public class ShopDaoImpl extends BaseDao implements ShopDao {
	@Override
	// ��ѯ
	public List<Shop> getShop() {
		// TODO Auto-generated method stub
		// ���Ӷ���
		Connection conn = getConnection();

		// ִ��sql���Ķ���
		PreparedStatement ps = null;
		ResultSet rs = null;
		// ���ü���
		List<Shop> lp2 = new ArrayList<Shop>();
		// �������˶���
		Shop shop = null;

		// ����SQL���
		String sql = "select * from Shop";
		try {

			ps = conn.prepareStatement(sql);
			rs = ps.executeQuery();

			// �������������ڿ�
			if (rs != null) {
				while (rs.next()) {
					 shop = new Shop();
					// �����̵�id
					 shop.setId(rs.getString("ID"));
					// �����̵�����
					shop.setName(rs.getString("Name"));
					lp2.add(shop);

				}
			}
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally {
			closeAll(conn, ps, rs);
		}

		return lp2;
	}

	@Override
	public Shop ShopQuery(Shop shop) {
		// ���Ӷ���
		Connection conn = getConnection();
		// ����ִ�ж���
		PreparedStatement pst = null;
		ResultSet rs = null;
		// SQL���
		String sql = "select * from Shop where ID = ? and PassWord = ?";

		try {
			pst = conn.prepareStatement(sql);
			pst.setString(1, shop.getId());
			pst.setString(2, shop.getPassWord());
			
			rs = pst.executeQuery();

			if (rs.next()) {
				shop.setName(rs.getString("Name"));
				shop.setBalance(rs.getInt("Balance"));
				return shop;
			}
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			closeAll(conn, pst, rs);
		}
		return null;
	}

	@Override
	public int ShopAdd(Shop shop) {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public int ShopUpdate(Shop shop) {
		// TODO Auto-generated method stub
		return 0;
	}

}
