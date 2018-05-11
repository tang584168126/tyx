package petShop.dao.impl;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import petShop.dao.BaseDao;
import petShop.dao.PetDao;
import petShop.entity.Pet;

/**
 * ����ʵ����
 * @author Administrator
 *
 */
public class PetDaoImpl extends BaseDao implements PetDao {

	private Connection conn = null; // �������ݿ�����

	private PreparedStatement pstmt = null; // ����ִ��SQL���

	private ResultSet rs = null; // �û������ѯ�����

	@Override
	public List<Pet> getAllPet() {
		// TODO Auto-generated method stub
		List<Pet> petList = new ArrayList<Pet>();
		try {
			String preparedSql = "select * from PET ";
			// �õ����ݿ�����
			conn = getConnection(); 
			// �õ�PreparedStatement����
			pstmt = conn.prepareStatement(preparedSql); 
			// ִ��SQL���
			rs = pstmt.executeQuery(); 

			while (rs.next()) {

				Pet pet = new Pet();
				pet.setId(rs.getInt(1));
				pet.setName(rs.getString(2));
				pet.setTypeName(rs.getString(3));
				pet.setHealth(rs.getInt(4));
				pet.setLove(rs.getInt(5));
				pet.setOwnerId(rs.getInt(6));
				pet.setStoreId(rs.getInt(7));
				petList.add(pet);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			super.closeAll(conn, pstmt, rs);
		}
		return petList;
	}

	@Override
	public int updatePet(String sql, Object[] param) {
		// TODO Auto-generated method stub
		int count = super.executeUpdate(sql, param);
		return count;
	}

	@Override
	public int getaddpet(String sql, Object[] param) {
		// TODO Auto-generated method stub
		int add = super.executeUpdate(sql, param);
		return add;
	}

	

}
