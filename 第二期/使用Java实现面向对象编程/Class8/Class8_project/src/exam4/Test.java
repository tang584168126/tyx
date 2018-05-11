package exam4;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class Test {
	static{
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
	}
	public static void main(String[] args) {
		//创建连接对象
		Connection conn = null;
		//创建执行sql对象
		Statement st = null;
		//创建结果集
		ResultSet rs = null;
				
		//url
		String url = "jdbc:sqlserver://localhost:1433;DataBaseName=Class8_Example";
		//用户名
		String user = "sa";
		//密码
		String password = "123";
		
		try {
			conn = DriverManager.getConnection(url, user, password);
			//创建sql语句
			String sql = "select * from student";
			
			st = conn.createStatement();
			
			rs = st.executeQuery(sql);
			while(rs.next()){
				int id = rs.getInt("id");
				String name = rs.getString("name");
				System.out.println(id + "\t" + name);
			}
		} catch (SQLException e) {
			System.out.println("连接数据库失败！");
			e.printStackTrace();
		}finally{
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
			} catch (Exception e2) {
				e2.printStackTrace();
			}
		}
	}
}
