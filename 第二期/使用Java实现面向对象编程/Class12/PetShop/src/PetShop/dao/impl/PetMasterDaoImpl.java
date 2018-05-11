package PetShop.dao.impl;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import PetShop.dao.BaseDao;
import PetShop.dao.MasterDao;
import PetShop.entity.Master;

/**
 * 主人实现类
 * 
 * @author 违心人
 * 
 */
public class PetMasterDaoImpl extends BaseDao implements MasterDao {

	@Override
	// 查询
	public List<Master> getPetOwner() {
		// TODO Auto-generated method stub
		// 连接对象
		Connection conn = getConnection();

		// 执行sql语句的对象
		PreparedStatement ps = null;
		ResultSet rs = null;
		// 设置集合
		List<Master> lp1 = new ArrayList<Master>();
		// 设置主人对象
		Master mas = null;

		// 创建SQL语句
		String sql = "select * from [Master]";
		try {

			ps = conn.prepareStatement(sql);
			rs = ps.executeQuery();

			// 如果结果集不等于空
			if (rs != null) {
				while (rs.next()) {
					mas = new Master();
					// 设置主人id
					mas.setId(rs.getString("ID"));
					// 设置主人名称
					mas.setName(rs.getString("Name"));
					lp1.add(mas);

				}
			}
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally {
			closeAll(conn, ps, rs);
		}

		return lp1;
	}

	//登录
	@Override
	public Master MasterQuery(Master master) {
		// 连接对象
		Connection conn = getConnection();
		// 创建执行对象
		PreparedStatement pst = null;
		ResultSet rs = null;
		// SQL语句
		String sql = "select * from Master where ID = ? and PassWord = ?";

		try {
			pst = conn.prepareStatement(sql);
			pst.setString(1, master.getId());
			pst.setString(2, master.getPassWord());

			rs = pst.executeQuery();

			if (rs.next()) {
				master.setName(rs.getString("Name"));
				master.setMoney(rs.getInt("Money"));
				return master;
			}
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			closeAll(conn, pst, rs);
		}
		return null;
	}

	@Override
	public int MasterAdd(Master master) {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public int MasterUpdate(Master master) {
		// TODO Auto-generated method stub
		return 0;
	}

}
