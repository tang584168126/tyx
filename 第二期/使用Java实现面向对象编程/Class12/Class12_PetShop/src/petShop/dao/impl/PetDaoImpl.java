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
 * 宠物实例类
 * @author Administrator
 *
 */
public class PetDaoImpl extends BaseDao implements PetDao {

	private Connection conn = null; // 保存数据库连接

	private PreparedStatement pstmt = null; // 用于执行SQL语句

	private ResultSet rs = null; // 用户保存查询结果集

	@Override
	public List<Pet> getAllPet() {
		// TODO Auto-generated method stub
		List<Pet> petList = new ArrayList<Pet>();
		try {
			String preparedSql = "select * from PET ";
			// 得到数据库连接
			conn = getConnection(); 
			// 得到PreparedStatement对象
			pstmt = conn.prepareStatement(preparedSql); 
			// 执行SQL语句
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
