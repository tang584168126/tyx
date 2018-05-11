package PetShop.dao.impl;

import java.sql.*;
import java.util.ArrayList;
import java.util.List;

import PetShop.dao.BaseDao;
import PetShop.dao.PetDao;
import PetShop.entity.Pet;

/**
 * 宠物实现类
 * 
 * @author 违心人
 * 
 */
public class PetDaoImpl extends BaseDao implements PetDao {

	@Override
	public List<Pet> select() {
		// TODO Auto-generated method stub
		// 连接对象
		Connection conn = getConnection();

		// 执行sql语句的对象
		PreparedStatement ps = null;
		ResultSet rs = null;
		// 设置集合
		List<Pet> lp = new ArrayList<Pet>();
		// 设置宠物对象
		Pet pet = null;

		// 创建SQL语句
		String sql = "select * from Pet";
		try {
			// 设置执行对象
			ps = conn.prepareStatement(sql);
			rs = ps.executeQuery();
			// 如果结果集不等于空
			if (rs != null) {
				while (rs.next()) {
					pet = new Pet();
					// 设置PETid
					pet.setId(rs.getInt("id"));
					// 设置宠物名称
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
		// 连接对象
		Connection conn = getConnection();
		// sql语句
		String sql = "insert into Pet values(?,?,default,default,?,?,2)";
		// 执行sql语句的对象
		PreparedStatement ps = null;
		try {
			ps = conn.prepareStatement(sql);
			// 昵称
			ps.setString(1, pet.getName());
			// 宠物类型
			ps.setString(2, pet.getTypeName());
			//价格
			ps.setInt(3, pet.getPrice());
			//所属的ID
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
