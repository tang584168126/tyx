package com.cdqy.s2t182.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

/**
 * ���ݿ����Ӻ͹ر�
 * 
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-19 ����3:53:06
 * @version 1.0
 */
public class BaseDao {
	// ��������
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
	 * ���ݿ������
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
	 * �ͷ���Դ
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
	 * ����,ɾ��,�޸�
	 */
	public int executeUpdate(String sql, Object[] param) {
		// ���Ӷ���
		Connection conn = getConnection();
		// ִ��sql���Ķ���
		PreparedStatement ps = null;
		try {
			ps = conn.prepareStatement(sql);
			if(param != null){
				for(int i=0;i<param.length;i++){
					// �ǳ�
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
