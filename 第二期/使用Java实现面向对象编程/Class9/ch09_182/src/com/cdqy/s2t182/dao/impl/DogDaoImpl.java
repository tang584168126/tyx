package com.cdqy.s2t182.dao.impl;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;

import com.cdqy.s2t182.dao.BaseDao;
import com.cdqy.s2t182.dao.DogDao;
import com.cdqy.s2t182.entity.Dog;

/**
 * 狗狗的实现类
 * 
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-19 下午4:07:49
 * @version 1.0
 */
public class DogDaoImpl extends BaseDao implements DogDao {

	@Override
	public int update(Dog dog) {
		/*
		// 连接对象
		Connection conn = getConnection();
		// sql语句
		String sql = "update [dog] set [name]=?,[health]=?,[love]=?,[strain]=? where [id]=?";
		// 执行sql语句的对象
		PreparedStatement ps = null;
		try {
			ps = conn.prepareStatement(sql);
			// 昵称
			ps.setString(1, dog.getName());
			// 健康值
			ps.setInt(2, dog.getHealth());
			// 亲密度
			ps.setInt(3, dog.getLove());
			// 品种
			ps.setString(4, dog.getStrain());
			// id
			ps.setInt(5, dog.getId());
			return ps.executeUpdate();
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			closeAll(conn, ps, null);
		}
		*/
		String sql = "update [dog] set [name]=?,[health]=?,[love]=?,[strain]=? where [id]=?";
		Object[] param = {dog.getName(),dog.getHealth(),dog.getLove(),dog.getStrain(),dog.getId()};
//		int result = executeUpdate(sql, null);
		int result = executeUpdate(sql, param);
		return result;
	}

	@Override
	public int save(Dog dog) {
		// 连接对象
		Connection conn = getConnection();
		// sql语句
		String sql = "insert into [Dog] values(?,?,?,?)";
		// 执行sql语句的对象
		PreparedStatement ps = null;
		try {
			ps = conn.prepareStatement(sql);
			// 昵称
			ps.setString(1, dog.getName());
			// 健康值
			ps.setInt(2, dog.getHealth());
			// 亲密度
			ps.setInt(3, dog.getLove());
			// 品种
			ps.setString(4, dog.getStrain());
			return ps.executeUpdate();
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			closeAll(conn, ps, null);
		}
		return 0;
	}

}
