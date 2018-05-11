package work1;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class Test {
	
	static{
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
	}
	
	public static void main(String[] args) {
		String url = "jdbc:sqlserver://localhost:1433";
		String user = "sa";
		String passWord = "123";
		Connection conn = null;
			
		try {
			conn = DriverManager.getConnection(url, user, passWord);
			System.out.println("建立连接成功！");
		} catch (SQLException e) {
			System.out.println("建立连接失败！");
			e.printStackTrace();
		}finally{
			if(conn != null){
				try {
					conn.close();
					System.out.println("数据库关闭！");
				} catch (SQLException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			}
		}
	}
}
