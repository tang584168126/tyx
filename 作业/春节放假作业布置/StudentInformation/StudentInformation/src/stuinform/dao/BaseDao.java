package stuinform.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

/**
 * ���ݿ����Ӻ͹ر�
 */
public class BaseDao {
	//��������
	static{
		
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriverer");
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
	}
	
	//url
	private final static String URL = "jdbc:sqlserver://localhost:1434;DataBaseName=StudentInformation"; 
	//user
	private final static String USER = "sa";
	//password
	private final static String PASSWORD = "sql2008";
	
	/**
	 * ���ݿ������
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
	 */
	public void closeAll(Connection conn, PreparedStatement ps, ResultSet rs){
		
		try {
			if(rs != null){rs.close();}
			
			if(ps != null){ps.close();}
			
			if(conn != null){conn.close();}
		} catch (Exception e) {
			
		}
	}
	
}
