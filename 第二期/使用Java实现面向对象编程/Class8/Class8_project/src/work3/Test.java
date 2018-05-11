package work3;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
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
		PreparedStatement ps = null;
		
		String url = "jdbc:sqlserver://localhost:1433;DataBaseName=epet";
		String user = "ds";
		String password = "sa";
		
		try {
			conn = DriverManager.getConnection(url, user, password);
			
			String sql = "insert into [dog] (name,health,love,strain) values (?,?,?,?)"; 
			
			ps = conn.prepareStatement(sql);
			ps.setString(1, "小花");
			ps.setInt(2, 89);
			ps.setInt(3, 51);
			ps.setString(4, "土狗");
			int result1 = ps.executeUpdate();
			ps.setString(1, "小白");
			ps.setInt(2, 79);
			ps.setInt(3,86);
			ps.setString(4, "狮子狗");
			int result2 = ps.executeUpdate();

			if(result1 > 0 && result2 >0){
				System.out.println("添加成功！");
			}else{
				System.out.println("添加失败！");
			}
		} catch (SQLException e) {
			System.out.println("连接数据库失败！");
			e.printStackTrace();
		}finally{
			try {
				if(ps != null){
					ps.close();
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
