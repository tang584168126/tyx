package com.cdqy.s2t182.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

/**
 * 数据库连接和关闭
 * 
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-19 下午3:53:06
 * @version 1.0
 */
public class BaseDao {
	// 加载驱动
	static {
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
	}
	// url
	private final static String URL = "jdbc:sqlserver://localhost:1434;DataBaseName=epet";
	private final static String USER = "sa";
	private final static String PASSWORD = "sql2008";

	/**
	 * 数据库的连接
	 */
	public Connection getConnection() {
		Connection conn = null;
		try {
			conn = DriverManager.getConnection(URL, USER, PASSWORD);
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return conn;
	}

	/**
	 * 释放资源
	 */
	public void closeAll(Connection conn, Statement st, ResultSet rs) {
		try {
			if (rs != null) {
				rs.close();
			}
			if (st != null) {
				st.close();
			}
			if (conn != null) {
				conn.close();
			}
		} catch (Exception ex) {
			ex.printStackTrace();
		}
	}

	/**
	 * 增加,删除,修改
	 */
	public int executeUpdate(String sql, Object[] param) {
		// 连接对象
		Connection conn = getConnection();
		// 执行sql语句的对象
		PreparedStatement ps = null;
		try {
			ps = conn.prepareStatement(sql);
			if(param != null){
				for(int i=0;i<param.length;i++){
					// 昵称
					ps.setObject(i+1, param[i]);
				}
			}
			return ps.executeUpdate();
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			closeAll(conn, ps, null);
		}
		return 0;
	}
}
