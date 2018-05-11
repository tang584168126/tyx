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
 * 商店实例类
 * @author Administrator
 *
 */
public class ShopDaoImpl extends BaseDao implements ShopDao {

	private Connection conn = null; // 保存数据库连接

	private PreparedStatement pstmt = null; // 用于执行SQL语句

	private ResultSet rs = null; // 用户保存查询结果集
	
	@Override
	public List<Shop> getAllStore() {
		// TODO Auto-generated method stub
		List<Shop> storeList = new ArrayList<Shop>();
		try {
		String preparedSql = "select * from petstore ";
		// 得到数据库连接
		conn = getConnection();
		 // 得到PreparedStatement对象
		pstmt = conn.prepareStatement(preparedSql);
		 // 执行SQL语句
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
		// 得到数据库连接
		conn = getConnection(); 
		pstmt = conn.prepareStatement(sql); // 得到PreparedStatement对象
		if (param != null) {
			for (int i = 0; i < param.length; i++) {
				pstmt.setString(i + 1, param[i]); // 为预编译sql设置参数
			}
		}
		rs = pstmt.executeQuery(); // 执行SQL语句
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
