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
 * ����ʵ����
 * @author Administrator
 *
 */
public class MasterDaoImpl extends BaseDao implements MasterDao {

	private Connection conn = null; // �������ݿ�����

	private PreparedStatement pstmt = null; // ����ִ��SQL���

	private ResultSet rs = null; // �û������ѯ�����
	
	/**
	 * ��ѯ���г���������Ϣ
	 */
	@Override
	public List<Master> getAllOwner() {
		// TODO Auto-generated method stub
		List<Master> masterList = new ArrayList<Master>();
		try {
		String preparedSql = "select * from PETOWNER ";
		// �õ����ݿ�����
		conn = getConnection(); 
		// �õ�PreparedStatement����
		pstmt = conn.prepareStatement(preparedSql); 
		// ִ��SQL���
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
	 * ���³���������Ϣ
	 */
	@Override
	public int updateOwner(String sql, String[] param) {
		// TODO Auto-generated method stub
		int count = super.executeUpdate(sql, param);
		return count;
	}
	/**
	 * ���ݲ�ѯ������ѯ����������Ϣ
	 */
	@Override
	public Master selectOwner(String sql, String[] param) {
		// TODO Auto-generated method stub
		Master master = null;
		try {
		// �õ����ݿ�����
		conn = getConnection();
		// �õ�PreparedStatement����
		pstmt = conn.prepareStatement(sql); 
		if (param != null) {
			for (int i = 0; i < param.length; i++) {
				// ���ò���
				pstmt.setString(i + 1, param[i]); 
			}
		}
		rs = pstmt.executeQuery(); // ִ��SQL���
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
