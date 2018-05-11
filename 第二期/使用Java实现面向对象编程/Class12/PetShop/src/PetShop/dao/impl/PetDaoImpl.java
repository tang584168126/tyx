package PetShop.dao.impl;

import java.sql.*;
import java.util.ArrayList;
import java.util.List;

import PetShop.dao.BaseDao;
import PetShop.dao.PetDao;
import PetShop.entity.Pet;

/**
 * ����ʵ����
 * 
 * @author Υ����
 * 
 */
public class PetDaoImpl extends BaseDao implements PetDao {

	@Override
	public List<Pet> select() {
		// TODO Auto-generated method stub
		// ���Ӷ���
		Connection conn = getConnection();

		// ִ��sql���Ķ���
		PreparedStatement ps = null;
		ResultSet rs = null;
		// ���ü���
		List<Pet> lp = new ArrayList<Pet>();
		// ���ó������
		Pet pet = null;

		// ����SQL���
		String sql = "select * from Pet";
		try {
			// ����ִ�ж���
			ps = conn.prepareStatement(sql);
			rs = ps.executeQuery();
			// �������������ڿ�
			if (rs != null) {
				while (rs.next()) {
					pet = new Pet();
					// ����PETid
					pet.setId(rs.getInt("id"));
					// ���ó�������
					pet.setName(rs.getString("Name"));
					lp.add(pet);
				}
			}
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally {
			closeAll(conn, ps, rs);
		}

		return lp;
	}

	@Override
	public int PetAdd(Pet pet) {
		// ���Ӷ���
		Connection conn = getConnection();
		// sql���
		String sql = "insert into Pet values(?,?,default,default,?,?,2)";
		// ִ��sql���Ķ���
		PreparedStatement ps = null;
		try {
			ps = conn.prepareStatement(sql);
			// �ǳ�
			ps.setString(1, pet.getName());
			// ��������
			ps.setString(2, pet.getTypeName());
			//�۸�
			ps.setInt(3, pet.getPrice());
			//������ID
			ps.setString(4, pet.getMasOrShopID());
			return ps.executeUpdate();
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			closeAll(conn, ps, null);
		}
		return 0;
	}

	@Override
	public int PetUpdate(Pet pet) {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public int PetDelete(Pet pet) {
		// TODO Auto-generated method stub
		return 0;
	}
}
