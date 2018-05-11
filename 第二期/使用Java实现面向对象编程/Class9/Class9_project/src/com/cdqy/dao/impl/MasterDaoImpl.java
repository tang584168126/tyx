package com.cdqy.dao.impl;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;

import com.cdqy.dao.BaseDao;
import com.cdqy.dao.MasterDao;
import com.cdqy.entity.Master;

/**
 * ����ʵ����
 * @author Administrator
 *
 */
public class MasterDaoImpl extends BaseDao implements MasterDao {

	@Override
	public int login(Master master) {
		//���Ӷ���
		Connection conn = getConnection();
		
		//sql���
		String sql = "select count(*) from [Master] where loginid = ? and password = ?";
		
		PreparedStatement ps = null;
		
		try {
			ps = conn.prepareStatement(sql);
			ps.setString(1, master.getLoginid());
			ps.setString(2, master.getPassword());
			
			return ps.executeUpdate();
		} catch (SQLException e) {
			e.printStackTrace();
		}finally{
			closeAll(conn, ps, null);
		}
		return 0;
	}
	
}
