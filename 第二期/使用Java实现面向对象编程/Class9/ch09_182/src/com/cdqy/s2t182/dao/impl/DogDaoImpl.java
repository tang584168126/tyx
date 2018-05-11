package com.cdqy.s2t182.dao.impl;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;

import com.cdqy.s2t182.dao.BaseDao;
import com.cdqy.s2t182.dao.DogDao;
import com.cdqy.s2t182.entity.Dog;

/**
 * ������ʵ����
 * 
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-19 ����4:07:49
 * @version 1.0
 */
public class DogDaoImpl extends BaseDao implements DogDao {

	@Override
	public int update(Dog dog) {
		/*
		// ���Ӷ���
		Connection conn = getConnection();
		// sql���
		String sql = "update [dog] set [name]=?,[health]=?,[love]=?,[strain]=? where [id]=?";
		// ִ��sql���Ķ���
		PreparedStatement ps = null;
		try {
			ps = conn.prepareStatement(sql);
			// �ǳ�
			ps.setString(1, dog.getName());
			// ����ֵ
			ps.setInt(2, dog.getHealth());
			// ���ܶ�
			ps.setInt(3, dog.getLove());
			// Ʒ��
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
		// ���Ӷ���
		Connection conn = getConnection();
		// sql���
		String sql = "insert into [Dog] values(?,?,?,?)";
		// ִ��sql���Ķ���
		PreparedStatement ps = null;
		try {
			ps = conn.prepareStatement(sql);
			// �ǳ�
			ps.setString(1, dog.getName());
			// ����ֵ
			ps.setInt(2, dog.getHealth());
			// ���ܶ�
			ps.setInt(3, dog.getLove());
			// Ʒ��
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
