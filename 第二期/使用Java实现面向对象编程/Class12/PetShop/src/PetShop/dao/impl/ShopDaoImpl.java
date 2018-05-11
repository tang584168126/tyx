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
	// 查询
	public List<Shop> getShop() {
		// TODO Auto-generated method stub
		// 连接对象
		Connection conn = getConnection();

		// 执行sql语句的对象
		PreparedStatement ps = null;
		ResultSet rs = null;
		// 设置集合
		List<Shop> lp2 = new ArrayList<Shop>();
		// 设置主人对象
		Shop shop = null;

		// 创建SQL语句
		String sql = "select * from Shop";
		try {

			ps = conn.prepareStatement(sql);
			rs = ps.executeQuery();

			// 如果结果集不等于空
			if (rs != null) {
				while (rs.next()) {
					 shop = new Shop();
					// 设置商店id
					 shop.setId(rs.getString("ID"));
					// 设置商店名称
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
		// 连接对象
		Connection conn = getConnection();
		// 创建执行对象
		PreparedStatement pst = null;
		ResultSet rs = null;
		// SQL语句
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
