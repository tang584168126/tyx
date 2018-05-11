package PetShop.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

/**
 * ���ݿ����Ӻ͹ر�
 * 
 * 
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
	private final static String URL = "jdbc:sqlserver://localhost:1434;DataBaseName=PetShop";
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
	public void closeAll(Connection conn, PreparedStatement st, ResultSet rs) {
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
	 * ����,ɾ��,��
	 */
	public int executeUpdate(String sql, Object[] param) {
		// ���Ӷ���
		Connection conn = getConnection();
		// ִ��sql���Ķ���
		PreparedStatement ps = null;
		try {
			ps = conn.prepareStatement(sql);
			if (param != null) {
				for (int i = 0; i < param.length; i++) {
					// �ǳ�
					ps.setObject(i + 1, param[i]);
				}

			}
			int num = ps.executeUpdate();
			return num;
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			closeAll(conn, ps, null);
		}
		return 0;
	}
}
