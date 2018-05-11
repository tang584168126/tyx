package petShop.dao;

import java.sql.PreparedStatement;
import java.sql.Statement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

/**
 * ���ݿ����Ӻ͹ر�
 * @author Administrator
 *
 */
public class BaseDao {
	static{
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
	}
	
	// ��ʼ�������������ݿ����
	public Connection conn = null;
	public Statement st = null;
	public ResultSet rs = null;
	public  PreparedStatement pstm=null;
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
	 * ���ݿ�ر�
	 */
	public void closeAll(Connection conn,Statement st,ResultSet rs){
		try {
			if(rs != null){
				rs.close();
			}
			if(st != null){
				st.close();
			}
			if(conn != null){
				conn.close();
			}
		} catch (SQLException e) {
			
		}
	}
	
	/**
	 * ����ɾ����
	 */
	public int executeUpdate(String sql,Object[] param){
		//���Ӷ���
		Connection conn = getConnection();
		
		PreparedStatement ps = null;
		
		try {
			ps = conn.prepareStatement(sql);
			if(param != null){
				for(int i = 0; i < param.length;i++){
					ps.setObject(i + 1, param[i]);
				}
			}
			
			return ps.executeUpdate();
		} catch (SQLException e) {
			e.printStackTrace();
		}finally{
			closeAll(conn, ps, null);
		}
		
		return 0;
	} 
	
	/**
	 * ��ѯ
	 * 
	 * @param sql
	 * @param parm
	 * @return
	 */
	public ResultSet executequery(String sql, Object[] parm) {
		// ��ʼ�����Ӷ���
		Connection conn = null;
		// ��ʼ�����ݼ�
		ResultSet rs = null;
		// �������Ӷ���
		conn = getConnection();
		// ����ִ�ж���
		PreparedStatement ps = null;

		try {
			// ����ִ�ж���
			ps = conn.prepareStatement(sql);
			if (parm != null) {
				for (int i = 0; i < parm.length; i++) {
					try {
						// �ǳ�
						ps.setObject(i + 1, parm[i]);
					} catch (SQLException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
				}
			}

			// ����ִ�н��
			rs = ps.executeQuery();
			// ���ؽ����
			return rs;
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return rs;

	}
	

	
}
