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
 * ����ʵ����
 * 
 * @author Υ����
 * 
 */
public class PetMasterDaoImpl extends BaseDao implements MasterDao {

	@Override
	// ��ѯ
	public List<Master> getPetOwner() {
		// TODO Auto-generated method stub
		// ���Ӷ���
		Connection conn = getConnection();

		// ִ��sql���Ķ���
		PreparedStatement ps = null;
		ResultSet rs = null;
		// ���ü���
		List<Master> lp1 = new ArrayList<Master>();
		// �������˶���
		Master mas = null;

		// ����SQL���
		String sql = "select * from [Master]";
		try {

			ps = conn.prepareStatement(sql);
			rs = ps.executeQuery();

			// �������������ڿ�
			if (rs != null) {
				while (rs.next()) {
					mas = new Master();
					// ��������id
					mas.setId(rs.getString("ID"));
					// ������������
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

	//��¼
	@Override
	public Master MasterQuery(Master master) {
		// ���Ӷ���
		Connection conn = getConnection();
		// ����ִ�ж���
		PreparedStatement pst = null;
		ResultSet rs = null;
		// SQL���
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
