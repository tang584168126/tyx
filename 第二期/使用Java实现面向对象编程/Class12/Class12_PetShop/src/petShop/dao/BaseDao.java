package petShop.dao;

import java.sql.PreparedStatement;
import java.sql.Statement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

/**
 * 数据库连接和关闭
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
	
	// 初始化各类连接数据库对象
	public Connection conn = null;
	public Statement st = null;
	public ResultSet rs = null;
	public  PreparedStatement pstm=null;
	private final static String URL = "jdbc:sqlserver://localhost:1433;DataBaseName=PetShop";		//url
	private final static String USER= "sa";
	private final static String PASSWORD = "sql2008";
	
	/**
	 * 数据库连接
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
	 * 数据库关闭
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
	 * 增，删，该
	 */
	public int executeUpdate(String sql,Object[] param){
		//连接对象
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
	 * 查询
	 * 
	 * @param sql
	 * @param parm
	 * @return
	 */
	public ResultSet executequery(String sql, Object[] parm) {
		// 初始化连接对象
		Connection conn = null;
		// 初始化数据集
		ResultSet rs = null;
		// 设置连接对象
		conn = getConnection();
		// 创建执行对象
		PreparedStatement ps = null;

		try {
			// 设置执行对象
			ps = conn.prepareStatement(sql);
			if (parm != null) {
				for (int i = 0; i < parm.length; i++) {
					try {
						// 昵称
						ps.setObject(i + 1, parm[i]);
					} catch (SQLException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
				}
			}

			// 接受执行结果
			rs = ps.executeQuery();
			// 返回结果集
			return rs;
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return rs;

	}
	

	
}
