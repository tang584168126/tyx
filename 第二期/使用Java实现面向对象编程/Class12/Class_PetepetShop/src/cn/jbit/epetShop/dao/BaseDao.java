package cn.jbit.epetShop.dao;

import java.sql.PreparedStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

/**
 * @author �������� ���ݿ��������
 */
public class BaseDao {
	static{
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
	}
	
	private final static String URL = "jdbc:sqlserver://localhost:1433;DataBaseName=PetShop";		//url
	private final static String USER= "sa";
	private final static String PASSWORD = "sql2008";
	
	/**
	 * ���ݿ�����
	 */
	public Connection getConnection(){
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
	 * 
	 * @param conn
	 *            ���ݿ�����
	 * @param pstmt
	 *            PreparedStatement����
	 * @param rs
	 *            �����
	 */
	public void closeAll(Connection conn, PreparedStatement pstmt, ResultSet rs) {

		/* ���rs���գ��ر�rs */
		if (rs != null) {
			try {
				rs.close();
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}
		/* ���pstmt���գ��ر�pstmt */
		if (pstmt != null) {
			try {
				pstmt.close();
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}
		/* ���conn���գ��ر�conn */
		if (conn != null) {
			try {
				conn.close();
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}

	}


	/**
	 * ִ��SQL��䣬���Խ�������ɾ���ĵĲ���������ִ�в�ѯ
	 * 
	 * @param sql
	 *            Ԥ����� SQL ���
	 * @param param
	 *            Ԥ����� SQL ����еġ������������ַ�������
	 * @return Ӱ�������
	 */
	public int executeSQL(String preparedSql, Object[] param) {
		Connection conn = null;
		PreparedStatement pstmt = null;
		int num = 0;

		/* ����SQL,ִ��SQL */
		try {
			conn = getConnection(); // �õ����ݿ�����
			pstmt = conn.prepareStatement(preparedSql); // �õ�PreparedStatement����
			if (param != null) {
				for (int i = 0; i < param.length; i++) {
					pstmt.setObject(i + 1, param[i]); // ΪԤ����sql���ò���
				}
			}
			// System.out.println(preparedSql);
			num = pstmt.executeUpdate(); // ִ��SQL���
		} catch (SQLException e) {
			e.printStackTrace(); // ����SQLException�쳣
		} finally {
			this.closeAll(conn, pstmt, null);
		}
		return num;
	}
}
