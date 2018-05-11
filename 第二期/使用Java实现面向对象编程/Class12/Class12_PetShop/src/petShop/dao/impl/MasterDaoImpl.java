package petShop.dao.impl;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import petShop.dao.MasterDao;

import petShop.dao.BaseDao;
import petShop.entity.Master;

/**
 * 主人实例类
 * @author Administrator
 *
 */
public class MasterDaoImpl extends BaseDao implements MasterDao {

	private Connection conn = null; // 保存数据库连接

	private PreparedStatement pstmt = null; // 用于执行SQL语句

	private ResultSet rs = null; // 用户保存查询结果集
	
	/**
	 * 查询所有宠物主人信息
	 */
	@Override
	public List<Master> getAllOwner() {
		// TODO Auto-generated method stub
		List<Master> masterList = new ArrayList<Master>();
		try {
		String preparedSql = "select * from PETOWNER ";
		// 得到数据库连接
		conn = getConnection(); 
		// 得到PreparedStatement对象
		pstmt = conn.prepareStatement(preparedSql); 
		// 执行SQL语句
		rs = pstmt.executeQuery(); 
			while (rs.next()) {
				Master master = new Master();
				master.setId(rs.getInt(1));
				master.setName(rs.getString(2));
				master.setPassword(rs.getString(3));
				master.setMoney(rs.getDouble(4));
				masterList.add(master);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			super.closeAll(conn, pstmt, rs);
		}
		return masterList;
	}

	/**
	 * 更新宠物主人信息
	 */
	@Override
	public int updateOwner(String sql, String[] param) {
		// TODO Auto-generated method stub
		int count = super.executeUpdate(sql, param);
		return count;
	}
	/**
	 * 根据查询条件查询宠物主人信息
	 */
	@Override
	public Master selectOwner(String sql, String[] param) {
		// TODO Auto-generated method stub
		Master master = null;
		try {
		// 得到数据库连接
		conn = getConnection();
		// 得到PreparedStatement对象
		pstmt = conn.prepareStatement(sql); 
		if (param != null) {
			for (int i = 0; i < param.length; i++) {
				// 设置参数
				pstmt.setString(i + 1, param[i]); 
			}
		}
		rs = pstmt.executeQuery(); // 执行SQL语句
			while (rs.next()) {
				master = new Master();
				master.setId(rs.getInt(1));
				master.setName(rs.getString(2));
				master.setPassword(rs.getString(3));
				master.setMoney(rs.getDouble(4));
			}
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			super.closeAll(conn, pstmt, rs);
		}
		return master;
	}
}
