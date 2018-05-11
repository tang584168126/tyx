package com.cdqy.dao.impl;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import com.cdqy.dao.BaseDao;
import com.cdqy.dao.PetDao;
import com.cdqy.entity.Master;
import com.cdqy.entity.Pet;

/**
 * 宠物实现类
 * @author Administrator
 *
 */
public class PetDaoImpl extends BaseDao implements PetDao {
	//连接对象
	Connection conn = getConnection();
	PreparedStatement ps = null;
	Statement st = null;
	ResultSet rs = null;
	
	@Override
	public void strain() {
		//sql语句
		String sql = "select * from [pet_type]";
		
		try {
			st = conn.createStatement();
			
			rs = st.executeQuery(sql);
			
			while(rs.next()){
				String name = rs.getString("name");
				System.out.println(name + " 丨  ");
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}finally{
			closeAll(conn, st, rs);
		}
	}

	public void type(String type) {
		//sql语句
		String sql = "select count(*) from [pet_type] where name = ?";
		
		
		
		try {
			ps = conn.prepareStatement(sql);
			
			ps.setString(1, type);
			
			int result = ps.executeUpdate();
			if(result == 1){
				//sql语句
				String sql1 = "select id from [pet_type] where name = name";
				
				st = conn.createStatement();
				rs = st.executeQuery(sql1);
				while(rs.next()){
					int id = rs.getInt("id");
					System.out.println("你选择的宠物编号是：" + id);
				}
				
			}else{
				System.out.println("宠物类型有误，领养失败！");
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}finally{
			closeAll(conn, st, rs);
		}
		
		
	}

	@Override
	public int add(String name) {
		Pet pet = null;
		//sql语句
		String sql = "insert into [Pet] (master_id,name,type_id,health,love,adopt_time,status) values (?,'?',?,default,default,default,default)";
		try {
			ps = conn.prepareStatement(sql);
			ps.setInt(1, Master.getId());
			ps.setString(2, name);
			ps.setInt(3, pet.getType_id());
			return ps.executeUpdate();
		} catch (SQLException e) {
			e.printStackTrace();
		}finally{
			closeAll(conn, st, rs);
		}
		
		return 0;
	}



}
