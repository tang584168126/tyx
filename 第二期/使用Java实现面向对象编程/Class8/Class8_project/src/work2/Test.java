package work2;

import java.sql.ResultSet;
import java.sql.Statement;
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
		Connection conn = null;
		Statement st = null;
		ResultSet rs = null;
		
		String url = "jdbc:sqlserver://localhost:1433;DataBaseName=epet";
		String user = "sa";
		String password = "sa";
		
		try {
			conn = DriverManager.getConnection(url,user,password);
			
			String sql = "select id,name,money from [master]";
			st = conn.createStatement();
			rs = st.executeQuery(sql);
			
			System.out.println("*************主人信息列表************");
			while(rs.next()){
				int id = rs.getInt("id");
				String name = rs.getString("name");
				int money = rs.getInt("money");
				System.out.println(id + "\t" + name + "\t" + money);
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
